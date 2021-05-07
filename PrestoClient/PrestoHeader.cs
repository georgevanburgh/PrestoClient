namespace BAMCIS.PrestoClient
{
    /// <summary>
    /// Available Presto headers
    /// https://github.com/prestodb/presto/blob/master/presto-client/src/main/java/com/facebook/presto/client/PrestoHeaders.java
    /// </summary>
    public class PrestoHeader
    {
        private PrestoHeader(string value) { Value = value; }

        public string Value { get; set; }

        public static readonly PrestoHeader PRESTO_USER = new PrestoHeader("X-Trino-User");
        public static readonly PrestoHeader PRESTO_SOURCE = new PrestoHeader("X-Trino-Source");
        public static readonly PrestoHeader PRESTO_CATALOG = new PrestoHeader("X-Trino-Catalog");
        public static readonly PrestoHeader PRESTO_SCHEMA = new PrestoHeader("X-Trino-Schema");
        public static readonly PrestoHeader PRESTO_TIME_ZONE = new PrestoHeader("X-Trino-Time-Zone");
        public static readonly PrestoHeader PRESTO_LANGUAGE = new PrestoHeader("X-Trino-Language");
        public static readonly PrestoHeader PRESTO_SESSION = new PrestoHeader("X-Trino-Session");
        public static readonly PrestoHeader PRESTO_SET_CATALOG = new PrestoHeader("X-Trino-Set-Catalog");
        public static readonly PrestoHeader PRESTO_SET_SCHEMA = new PrestoHeader("X-Trino-Set-Schema");
        public static readonly PrestoHeader PRESTO_SET_SESSION = new PrestoHeader("X-Trino-Set-Session");
        public static readonly PrestoHeader PRESTO_CLEAR_SESSION = new PrestoHeader("X-Trino-Clear-Session");
        public static readonly PrestoHeader PRESTO_PREPARED_STATEMENT = new PrestoHeader("X-Trino-Prepared-Statement");
        public static readonly PrestoHeader PRESTO_ADDED_PREPARE = new PrestoHeader("X-Trino-Added-Prepare");
        public static readonly PrestoHeader PRESTO_DEALLOCATED_PREPARE = new PrestoHeader("X-Trino-Deallocated-Prepare");
        public static readonly PrestoHeader PRESTO_TRANSACTION_ID = new PrestoHeader("X-Trino-Transaction-Id");
        public static readonly PrestoHeader PRESTO_STARTED_TRANSACTION_ID = new PrestoHeader("X-Trino-Started-Transaction-Id");
        public static readonly PrestoHeader PRESTO_CLEAR_TRANSACTION_ID = new PrestoHeader("X-Trino-Clear-Transaction-Id");
        public static readonly PrestoHeader PRESTO_CLIENT_INFO = new PrestoHeader("X-Trino-Client-Info");
        public static readonly PrestoHeader PRESTO_CLIENT_TAGS = new PrestoHeader("X-Trino-Client-Tags");

        public static readonly PrestoHeader PRESTO_CURRENT_STATE = new PrestoHeader("X-Trino-Current-State");
        public static readonly PrestoHeader PRESTO_MAX_WAIT = new PrestoHeader("X-Trino-Max-Wait");
        public static readonly PrestoHeader PRESTO_MAX_SIZE = new PrestoHeader("X-Trino-Max-Size");
        public static readonly PrestoHeader PRESTO_TASK_INSTANCE_ID = new PrestoHeader("X-Trino-Task-Instance-Id");
        public static readonly PrestoHeader PRESTO_PAGE_TOKEN = new PrestoHeader("X-Trino-Page-Sequence-Id");
        public static readonly PrestoHeader PRESTO_PAGE_NEXT_TOKEN = new PrestoHeader("X-Trino-Page-End-Sequence-Id");
        public static readonly PrestoHeader PRESTO_BUFFER_COMPLETE = new PrestoHeader("X-Trino-Buffer-Complete");

        public static readonly PrestoHeader PRESTO_DATA_NEXT_URI = new PrestoHeader("X-Trino-Data-Next-Uri");

        public override string ToString()
        {
            return this.Value;
        }
    }
}