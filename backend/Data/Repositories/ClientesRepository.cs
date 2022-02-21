using backend.Data.Configurations;
using backend.Models;
using MongoDB.Driver;
using System.Collections.Generic;

namespace backend.Data.Repositories
{
    public class ClientesRepository : IClientesRepository
    {

        private readonly IMongoCollection<Cliente> _clientes;

        public ClientesRepository(IDatabaseConfigs dbConfig)
        {
            var mongoClient = new MongoClient(dbConfig.ConnectionString);
            var db = mongoClient.GetDatabase(dbConfig.DatabaseName);
            _clientes = db.GetCollection<Cliente>("clientes");
        }
        
        public void Adicionar(Cliente cliente)
        {
            _clientes.InsertOne(cliente);
        }

        public void Atualizar(string Id, Cliente clienteAtualizado)
        {
            _clientes.ReplaceOne(cliente => cliente.Id == Id, clienteAtualizado);
        }

        public IEnumerable<Cliente> Buscar()
        {
            return _clientes.Find(cliente => true).ToList();
        }

        public Cliente Buscar(string Id)
        {
            return _clientes.Find(cliente => cliente.Id == Id).FirstOrDefault();
        }

        public void Remover(string id)
        {
            _clientes.DeleteOne(cliente => cliente.Id == id);
        }
    }
}
