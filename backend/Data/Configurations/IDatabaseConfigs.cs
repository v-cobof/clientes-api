namespace backend.Data.Configurations
{
    public interface IDatabaseConfigs
    {
        // nas interfaces as props não são públicas
        // não tem ClientesCollectionName, estou definindo o nome de cada collection no Repository

        string DatabaseName { get; set; }

        string ConnectionString { get; set; }


    }
}
