using System.Collections.Generic;

namespace JobsDBTool.Helper
{
    public interface IEngineCommand
    {
        IList<TIndexField> Search<TIndexField>(string engineCoreUrl, string searchQuery) where TIndexField : new();
        IList<TIndexField> Search<TIndexField>(string engineCoreUrl, string searchQuery, SolrQueryOption solrQueryOption) where TIndexField : new();

        bool DeleteByQuery(string engineCoreUrl, string searchQuery);

        bool Post<TIndexField>(string engineCoreUrl, IList<TIndexField> indexFields);
        bool Post<TIndexField>(string engineCoreUrl, IList<TIndexField> indexFields, OperateType operateType);

        bool AtomSet<TIndexField>(string engineCoreUrl, IList<TIndexField> indexFields, IList<string> atomFields);
        //原子更新 <add><doc><field name='id'>{0}</field><field name='{1}' update='set'>{2}</field></doc></add>"       
        //注意主键id是没有update='set'的
        bool AtomAdd<TIndexField>(string engineCoreUrl, IList<TIndexField> indexFields, IList<string> atomFields);
    }
}
