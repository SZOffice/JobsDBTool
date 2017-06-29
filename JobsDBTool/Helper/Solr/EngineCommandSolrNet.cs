using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.ServiceLocation;

using SolrNet;
using SolrNet.Impl;
using SolrNet.Commands.Parameters;
using SolrNet.Commands;

namespace JobsDBTool.Helper
{
    /// <summary>
    /// SearchEngine 封装命令
    /// </summary>
    public class EngineCommandSolrNet : IEngineCommand
    {
        private const char EngineUrlseparator = '#';
        private const string DeleteQuery = "<delete><query>{0}</query></delete>";

        public QueryOptions ComposeQueryOption(SolrQueryOption solrQueryOption) {
            QueryOptions option = new QueryOptions();
            if (solrQueryOption != null) { 
                if (solrQueryOption.PageSize > 0) {
                    solrQueryOption.PageIndex = solrQueryOption.PageIndex <= 0 ? 1 : solrQueryOption.PageIndex;
                    option.Start= (solrQueryOption.PageIndex - 1) * solrQueryOption.PageSize;
                    option.Rows = solrQueryOption.PageSize;
                }
                if (solrQueryOption.SortOrder != null && solrQueryOption.SortOrder.Count > 0) {
                    foreach (var item in solrQueryOption.SortOrder)
                    {
                        option.OrderBy.Add(new SortOrder(item.Key, item.Value ? Order.ASC : Order.DESC));
                    }
                }
                if (solrQueryOption.Fields != null && solrQueryOption.Fields.Count > 0)
                {
                    option.Fields = solrQueryOption.Fields;
                }
            }
            return option;
        }

        public IList<Dictionary<string, object>> Search(string engineCoreUrl, string searchQuery)
        {
            SolrQueryOption option = new SolrQueryOption()
            {
                PageIndex = 1,
                PageSize = 20
            };
            return Search(engineCoreUrl, searchQuery, option);        
        }

        public IList<Dictionary<string, object>> Search(string engineCoreUrl, string searchQuery, SolrQueryOption solrQueryOption)
        {
            var connection = new SolrConnection(engineCoreUrl);
            connection.Timeout = 10000;
            //if (Startup.Container == null)
            //{
                Startup.Init<Dictionary<string, object>>(connection);
            //}
            var solr = ServiceLocator.Current.GetInstance<ISolrOperations<Dictionary<string, object>>>();
            
            QueryOptions options = ComposeQueryOption(solrQueryOption);
            
            IList<Dictionary<string, object>> results = solr.Query(searchQuery, options);
            
            //List<long> JobIdList = new List<long>();
            //foreach (Dictionary<string, object> resumeData in results)
            //{
            //    if (resumeData.ContainsKey("id"))
            //    {
            //        JobIdList.Add(long.Parse(resumeData["id"].ToString()));
            //    }
            //}
            return results;
        }

        public IList<TIndexField> Search<TIndexField>(string engineCoreUrl, string searchQuery)
            where TIndexField:new()
        {
            IList<Dictionary<string, object>> searchResult = Search(engineCoreUrl, searchQuery);
            return IndexFieldFactorySolrNet.Deserialize<TIndexField>(searchResult);
        }

        public IList<TIndexField> Search<TIndexField>(string engineCoreUrl, string searchQuery, SolrQueryOption solrQueryOption) 
            where TIndexField:new()
        {
            IList<Dictionary<string, object>> searchResult = Search(engineCoreUrl, searchQuery, solrQueryOption);
            return IndexFieldFactorySolrNet.Deserialize<TIndexField>(searchResult);
        }

        public bool DeleteByQuery(string engineCoreUrl, string searchQuery)
        {
            StringBuilder sbComm = new StringBuilder();
            sbComm.AppendFormat(DeleteQuery, searchQuery);
            return PostByXml(engineCoreUrl, sbComm.ToString());
        }

        public bool Post<TIndexField>(string engineCoreUrl, IList<TIndexField> indexFields) {
            return Post<TIndexField>(engineCoreUrl, indexFields, OperateType.Xml);
        }

        public bool Post<TIndexField>(string engineCoreUrl, IList<TIndexField> indexFields, OperateType operateType)
        {
            //step 1: get record index xml.
            string indexFieldXmls = IndexFieldFactorySolrNet.ComposeIndexFieldXml(indexFields, true);
            var arr = engineCoreUrl.Split('/');

            bool methodResults = false;
            switch (operateType) { 
                case OperateType.Xml:
                    methodResults = PostByXml(engineCoreUrl, indexFieldXmls);
                    break;
                case OperateType.Javabin:
                    break;
            }
            
            return methodResults;
        }

        public Dictionary<string, bool> PostByXml(List<string> engineUrls, string coreName, string indexFieldXml)
        {
            Dictionary<string, bool> results = new Dictionary<string, bool>();
            foreach (string searchEngineUrl in engineUrls)
            {
                var searchEngineData = searchEngineUrl.Split(EngineUrlseparator);
                string engineCore = searchEngineData[0].Trim();

                bool post = PostByXml(searchEngineData[1].Trim() + "/" + coreName, indexFieldXml);

                results.Add(engineCore, post);
            }
            return results;
        }

        public bool PostByXml(string engineCoreUrl, string indexFieldXml)
        {
            bool result = true;
            var connection = new SolrConnection(engineCoreUrl);
            try
            {
                connection.Post("/update", indexFieldXml);
                
                //connection.Post("/update", "<commit />");
                CommitCommand commitCommand = new CommitCommand();
                string commandResult = commitCommand.Execute(connection);
            }
            catch
            {
                result = false;

            }
            return result;
        }

        public bool AtomAdd<TIndexField>(string engineCoreUrl, IList<TIndexField> indexFields, IList<string> atomFields)
        {
            string indexFieldXmls = IndexFieldFactorySolrNet.ComposeIndexFieldXml(indexFields, true, atomFields, OperateMethod.AtomAdd);
            var arr = engineCoreUrl.Split('/');
            
            return PostByXml(engineCoreUrl, indexFieldXmls);
        }

        public bool AtomSet<TIndexField>(string engineCoreUrl, IList<TIndexField> indexFields, IList<string> atomFields)
        {
            string indexFieldXmls = IndexFieldFactorySolrNet.ComposeIndexFieldXml(indexFields, true, atomFields, OperateMethod.AtomSet);
            
            return PostByXml(engineCoreUrl, indexFieldXmls);
        }
    }
}
