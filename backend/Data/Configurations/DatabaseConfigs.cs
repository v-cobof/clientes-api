namespace backend.Data.Configurations
{
    public class DatabaseConfigs : IDatabaseConfigs
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
    }
}
