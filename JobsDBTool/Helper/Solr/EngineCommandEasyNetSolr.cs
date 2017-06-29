using System;
using System.Collections.Generic;
using System.Text;

using EasyNet.Solr;
using EasyNet.Solr.Commons;
using EasyNet.Solr.Impl;

namespace JobsDBTool.Helper
{
    /// <summary>
    /// SearchEngine 封装命令
    /// </summary>
    public class EngineCommandEasyNetSolr:IEngineCommand
    {
        private const char EngineUrlseparator = '#';
        private const string DeleteQuery = "<delete><query>{0}</query></delete>";

        static OptimizeOptions optimizeOptions = new OptimizeOptions();
        static ISolrResponseParser<NamedList, ResponseHeader> binaryResponseHeaderParser = new BinaryResponseHeaderParser();
        static IUpdateParametersConvert<NamedList> updateParametersConvert = new BinaryUpdateParametersConvert();
        private ISolrUpdateConnection<NamedList, NamedList> solrUpdateConnection;
        private ISolrUpdateOperations<NamedList> updateOperations;

        private static void splitEngineCoreUrl(string engineCoreUrl, out string serverUrl, out string collection)
        {
            if (engineCoreUrl.Substring(engineCoreUrl.Length - 1) == "/")
            {
                engineCoreUrl = engineCoreUrl.Substring(0, engineCoreUrl.Length - 1);
            }
            serverUrl = engineCoreUrl.Substring(0, engineCoreUrl.LastIndexOf('/') + 1);
            collection = engineCoreUrl.Substring(engineCoreUrl.LastIndexOf('/') + 1);
        }

        public IList<TIndexField> Search<TIndexField>(string engineCoreUrl, string searchQuery)
            where TIndexField : new()
        {
            SolrQueryOption option = new SolrQueryOption()
            {
                PageIndex = 1,
                PageSize = 20
            };
            return Search<TIndexField>(engineCoreUrl, searchQuery, option);
        }

        public IList<TIndexField> Search<TIndexField>(string engineCoreUrl, string searchQuery, SolrQueryOption solrQueryOption)
            where TIndexField : new()
        {
            return SearchByJavabin<TIndexField>(engineCoreUrl, searchQuery, solrQueryOption);
        }

        public IList<TIndexField> SearchByJavabin<TIndexField>(string engineCoreUrl, string searchQuery, SolrQueryOption solrQueryOption)
            where TIndexField:new()
        {
            string serverUrl = string.Empty;
            string collection = string.Empty;
            splitEngineCoreUrl(engineCoreUrl, out serverUrl, out collection);

            ISolrResponseParser<NamedList, ResponseHeader> binaryResponseHeaderParser = new BinaryResponseHeaderParser();
            ISolrQueryConnection<NamedList> connection = new SolrQueryConnection<NamedList>() { ServerUrl = serverUrl };
            ISolrQueryOperations<NamedList> operations = new SolrQueryOperations<NamedList>(connection) { ResponseWriter = "javabin" };
            
            ISolrResponseParser<NamedList, QueryResults<TIndexField>> binaryQueryResultsParser = new BinaryQueryResultsParser<TIndexField>(new SolrObjectDeSerializer<TIndexField>());
            
            SolrQuery solrQuery = new SolrQuery(searchQuery);

            IDictionary<string, ICollection<string>> queryOption = new Dictionary<string, ICollection<string>>();
            
            queryOption[CommonParams.WT] = new string[] { "javabin" };
            if (solrQueryOption != null)
            {
                if (solrQueryOption.Fields != null && solrQueryOption.Fields.Count > 0)
                {
                    queryOption[CommonParams.FL] = new string[] { "id", "name" };
                }
                if (solrQueryOption.PageSize > 0)
                {
                    solrQueryOption.PageIndex = solrQueryOption.PageIndex <= 0 ? 1 : solrQueryOption.PageIndex;
                    queryOption[CommonParams.START] = new string[] { ((solrQueryOption.PageIndex - 1) * solrQueryOption.PageSize).ToString() };
                    queryOption[CommonParams.ROWS] = new string[] { solrQueryOption.PageSize.ToString() };
                }
                if (solrQueryOption.SortOrder != null && solrQueryOption.SortOrder.Count > 0)
                {
                    string sb = string.Empty;
                    foreach (var item in solrQueryOption.SortOrder)
                    {
                        sb += (string.IsNullOrEmpty(sb)?"":",") + item.Key + " " + (item.Value ? "asc" : "desc");
                    }
                    queryOption[CommonParams.SORT] = new string[] { sb };
                }

                //queryOption[HighlightParams.HIGHLIGHT] = new string[] { "true" };
                //queryOption[HighlightParams.FIELDS] = new string[] { "id" };                
            }
            
            NamedList searchResult = operations.Query(collection, "/select", solrQuery, queryOption);             
            
            //解析返回头信息
            var responseHeader = binaryResponseHeaderParser.Parse(searchResult);
            //Console.WriteLine("Query Status:{0} QTime:{1}", responseHeader.Status, responseHeader.QTime);

            //解析查询结果            
            QueryResults<TIndexField> queryResult = binaryQueryResultsParser.Parse(searchResult);
            //Console.WriteLine("Total:{0} Result:{1}", queryResult.NumFound, queryResult.Count);

            //解析高亮
            /*
            var binaryHighlightingParser = new BinaryHighlightingParser();
            var hightlightResult = binaryHighlightingParser.Parse(searchResult);
            foreach (var h in hightlightResult)
            {
                Console.WriteLine("{0}-", h.Key);
                foreach (var item in h.Value)
                {
                    Console.WriteLine("{0}:{1}", item.Key, item.Value[0].ToString());
                }
            }
            */

            //facetResult = binaryFacetFieldsParser.Parse(searchResult);
            IList<TIndexField> records = new List<TIndexField>();
            foreach (var item in queryResult)
            {
                records.Add(item);
            }            
            return records;
        }

        public bool DeleteByQuery(string engineCoreUrl, string searchQuery)
        {
            bool ret;
            CommitOptions commitOptions = new CommitOptions();
            string serverUrl = string.Empty;
            string collection = string.Empty;
            splitEngineCoreUrl(engineCoreUrl, out serverUrl, out collection);
            
            try
            {
                solrUpdateConnection = new SolrUpdateConnection<NamedList, NamedList>() { ServerUrl = serverUrl };

                updateOperations = new SolrUpdateOperations<NamedList, NamedList>(solrUpdateConnection,
                    updateParametersConvert)
                {
                    ResponseWriter = "javabin"
                };

                var result = updateOperations.Update(collection, "/update", new UpdateOptions()
                {
                    CommitOptions = commitOptions,
                    DelByQ = new string[] { searchQuery },
                    //DelById = new string[] { "SOLR1000" },
                });
                var header = binaryResponseHeaderParser.Parse(result);
                //Console.WriteLine("Update Status:{0} QTime:{1}", header.Status, header.QTime);
                ret = header.Status == 0;
            }
            catch
            {
                ret = false;

            }
            return ret;
        }

        public bool Post<TIndexField>(string engineCoreUrl, IList<TIndexField> indexFields)
        {
            return Post<TIndexField>(engineCoreUrl, indexFields, OperateType.Javabin);
        }

        public bool Post<TIndexField>(string engineCoreUrl, IList<TIndexField> indexFields, OperateType operateType)
        {
            IObjectSerializer<TIndexField> objectSerializer = new SolrObjectSerializer<TIndexField>();
            IEnumerable<SolrInputDocument> solrInputDocument = objectSerializer.Serialize(indexFields);
            return PostByJavabin(engineCoreUrl, solrInputDocument);

            bool methodResults = false;
            switch (operateType)
            {
                case OperateType.Xml:
                    break;
                case OperateType.Javabin:
                    methodResults = PostByJavabin(engineCoreUrl, solrInputDocument);
                    break;
            }
            return methodResults;
        }
        
        public bool PostByJavabin(string engineCoreUrl, IEnumerable<SolrInputDocument> solrInputDocument)
        {
            bool ret;
            string serverUrl = string.Empty;
            string collection = string.Empty;
            splitEngineCoreUrl(engineCoreUrl, out serverUrl, out collection);
            try
            {
                solrUpdateConnection = new SolrUpdateConnection<NamedList, NamedList>() { ServerUrl = serverUrl };
                updateOperations = new SolrUpdateOperations<NamedList, NamedList>(solrUpdateConnection,
                    updateParametersConvert)
                {
                    ResponseWriter = "javabin"
                };

                var result = updateOperations.Update(collection, "/update", new UpdateOptions()
                {
                    OptimizeOptions = optimizeOptions,
                    Docs = solrInputDocument
                });
                var header = binaryResponseHeaderParser.Parse(result);
                //Console.WriteLine("Update Status:{0} QTime:{1}", header.Status, header.QTime);
                ret = header.Status == 0;
            }
            catch
            {
                ret = false;

            }
            return ret;
        }


        public bool AtomAdd<TIndexField>(string engineCoreUrl, IList<TIndexField> indexFields, IList<string> atomFields)
        {
            SolrObjectSerializer<TIndexField> objectSerializer = new SolrObjectSerializer<TIndexField>();
            IEnumerable<SolrInputDocument> solrInputDocument = objectSerializer.Serialize(indexFields, atomFields, OperateMethod.AtomAdd);
            return Atom(engineCoreUrl, solrInputDocument);
        }

        public bool AtomSet<TIndexField>(string engineCoreUrl, IList<TIndexField> indexFields, IList<string> atomFields)
        {
            SolrObjectSerializer<TIndexField> objectSerializer = new SolrObjectSerializer<TIndexField>();
            IEnumerable<SolrInputDocument> solrInputDocument = objectSerializer.Serialize(indexFields, atomFields, OperateMethod.AtomSet);
            return Atom(engineCoreUrl, solrInputDocument);
        }
        
        public bool Atom(string engineCoreUrl, IEnumerable<SolrInputDocument> solrInputDocument)
        {
            bool ret;
            string serverUrl = string.Empty;
            string collection = string.Empty;
            splitEngineCoreUrl(engineCoreUrl, out serverUrl, out collection);
            try
            {
                solrUpdateConnection = new SolrUpdateConnection<NamedList, NamedList>() { ServerUrl = serverUrl };
                updateOperations = new SolrUpdateOperations<NamedList, NamedList>(solrUpdateConnection,
                    updateParametersConvert)
                {
                    ResponseWriter = "javabin"
                };

                var result = updateOperations.Update(collection, "/update", new UpdateOptions()
                { 
                    OptimizeOptions = optimizeOptions,
                    Docs = solrInputDocument
                });
                var header = binaryResponseHeaderParser.Parse(result);
                
                //Console.WriteLine("Update Status:{0} QTime:{1}", header.Status, header.QTime);
                ret = header.Status == 0;
            }
            catch
            {
                ret = false;

            }
            return ret;
        }
    }
}
