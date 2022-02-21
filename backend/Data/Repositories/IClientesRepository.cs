using backend.Models;
using System.Collections.Generic;

namespace backend.Data.Repositories
{
    public interface IClientesRepository
    {
        void Adicionar(Cliente cliente);

        void Atualizar(string Id, Cliente clienteAtualizado);

        IEnumerable<Cliente> Buscar();

        Cliente Buscar(string Id);

        void Remover(string id);
    }
}
