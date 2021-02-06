namespace Domain.Entities
{
    public class DslikerDatabaseSettings : IDslikerDatabaseSettings
    {
        public string DslikerCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IDslikerDatabaseSettings
    {
        string DslikerCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
