using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace JobsDBTool.Helper
{
    #region TIndexField
	
    [System.AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class SolrAttribute : System.Attribute
    {
        public bool IsUniqueKey = false;
    }


	
    public class SolrExample : ISolr
    {
        public IList<string> title { get; set; }
    }	
	
    public class TalentSearch : ISolr
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public bool ishasresume { get; set; }
        public int profileprivacylevel { get; set; }
        public DateTime? utclastmodifiedtime { get; set; }
        public DateTime? utclastactivitytime { get; set; }
        public string countryofresidence { get; set; }
        public int? yearofexperience { get; set; }
        public int? educationlevel { get; set; }
        public int? nationality { get; set; }
        public int? locationid { get; set; }

        public IList<string> eligibletowork { get; set; }
        public IList<string> skills { get; set; }

        public string company_1 { get; set; }
        public string company_2 { get; set; }
        public string company_3 { get; set; }

        public string position_1 { get; set; }
        public string position_2 { get; set; }
        public string position_3 { get; set; }

        public DateTime? employmentstartdate_1 { get; set; }
        public DateTime? employmentstartdate_2 { get; set; }
        public DateTime? employmentstartdate_3 { get; set; }

        public DateTime? employmentenddate_1 { get; set; }
        public DateTime? employmentenddate_2 { get; set; }
        public DateTime? employmentenddate_3 { get; set; }

        public string jobfunction_1 { get; set; }
        public string jobfunction_2 { get; set; }
        public string jobfunction_3 { get; set; }

        public bool isemploymenttopresent_1 { get; set; }
        public bool isemploymenttopresent_2 { get; set; }
        public bool isemploymenttopresent_3 { get; set; }
        
    }
    public class TalentSearchStatus
    {
        private string _id;
        [Solr(IsUniqueKey = true)]
        public string id
        {
            get
            {
                if (jobseekerid != default(long) || employerid != default(long))
                {
                    return this.jobseekerid + "-" + this.employerid;
                }
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public long jobseekerid { get; set; }
        public long employerid { get; set; }
        public byte status { get; set; }
        public long? jobadid { get; set; }
        public DateTime? utcexpirytime { get; set; }
        public DateTime utccreatedtime { get; set; }
        public DateTime utclastmodifiedtime { get; set; }
    }
    #endregion
}
