using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobsDBTool.Helper
{
    public struct CommonParams
    {
        /// <summary>
        /// the query type - which query handler should handle the request
        /// </summary>
        public const string QT = "qt";

        /// <summary>
        /// the response writer type - the format of the response
        /// </summary>
        public const string WT = "wt";

        /// <summary>
        /// query string
        /// </summary>
        public const string Q = "q";

        /// <summary>
        /// sort order
        /// </summary>
        public const string SORT = "sort";

        /// <summary>
        /// Lucene query string(s) for filtering the results without affecting scoring
        /// </summary>
        public const string FQ = "fq";

        /// <summary>
        /// zero based offset of matching documents to retrieve
        /// </summary>
        public const string START = "start";

        /// <summary>
        /// number of documents to return starting at "start" 
        /// </summary>
        public const string ROWS = "rows";

        /// <summary>
        /// stylesheet to apply to XML results
        /// </summary>
        public const string XSL = "xsl";

        /// <summary>
        /// version parameter to check request-response compatibility
        /// </summary>
        public const string VERSION = "version";

        /// <summary>
        /// query and init param for field list
        /// </summary>
        public const string FL = "fl";

        /// <summary>
        /// default query field
        /// </summary>
        public const string DF = "df";

        /// <summary>
        /// whether to include debug data
        /// </summary>
        public const string DEBUG_QUERY = "debugQuery";

        /// <summary>
        /// boolean indicating whether score explanations should structured (true),or plain text (false)
        /// </summary>
        public const string EXPLAIN_STRUCT = "debug.explain.structured";

        /// <summary>
        /// another query to explain against
        /// </summary>
        public const string EXPLAIN_OTHER = "explainOther";

        /// <summary>
        /// If the content stream should come from a URL (using URLConnection)
        /// </summary>
        public const string STREAM_URL = "stream.url";

        /// <summary>
        /// If the content stream should come from a File (using FileReader)
        /// </summary>
        public const string STREAM_FILE = "stream.file";

        /// <summary>
        /// If the content stream should come directly from a field
        /// </summary>
        public const string STREAM_BODY = "stream.body";

        /// <summary>
        /// Explicitly set the content type for the input stream
        /// If multiple streams are specified, the explicit contentType
        /// will be used for all of them.
        /// </summary>
        public const string STREAM_CONTENTTYPE = "stream.contentType";

        /// <summary>
        /// Timeout value in milliseconds.  If not set, or the value is <= 0, there is no timeout.
        /// </summary>
        public const string TIME_ALLOWED = "timeAllowed";

        /// <summary>
        /// 'true' if the header should include the handler name
        /// </summary>
        public const string HEADER_ECHO_HANDLER = "echoHandler";

        /// <summary>
        /// include the parameters in the header
        /// </summary>
        public const string HEADER_ECHO_PARAMS = "echoParams";

        /// <summary>
        /// include header in the response
        /// </summary>
        public const string OMIT_HEADER = "omitHeader";

        public enum EchoParamStyle
        {
            EXPLICIT,
            ALL,
            NONE
        }

        public const string EXCLUDE = "ex";
        public const string TAG = "tag";
        public const string TERMS = "terms";
        public const string OUTPUT_KEY = "key";
        public const string FIELD = "f";
        public const string VALUE = "v";
        public const string TRUE = "true";
        public const string FALSE = "false";

        /// <summary>
        /// Used as a local parameter on queries.  cache=false means don't check any query or filter caches.
        /// cache=true is the default.
        /// </summary>
        public const string CACHE = "cache";

        /// <summary>
        /// Used as a local param on filter queries in conjunction with cache=false.  Filters are checked in order, from
        /// smallest cost to largest. If cost>=100 and the query implements PostFilter, then that interface will be used to do post query filtering.
        /// </summary>
        public const string COST = "cost";
    }
}
