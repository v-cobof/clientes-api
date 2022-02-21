using backend.Models.InputModels;
using MongoDB.Bson.Serialization.Attributes;

namespace backend.Models
{
    public class Cliente
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }

        public Cliente(ClienteInputModel cliente)
        {
            Nome = cliente.Nome;
            Telefone = cliente.Telefone;
            Endereco = cliente.Endereco;
        }

        public void AtualizarCliente(string nome, string telefone, string endereco)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }
    }
}
