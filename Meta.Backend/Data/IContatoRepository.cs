using Meta.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meta.Backend.Data
{
    public interface IContatoRepository
    {
        bool SaveChanges();

        IEnumerable<Contato> GetAllContatos();
        Contato GetContatoById(int id);
        void CreateContato(Contato contato);
        void UpdateContato(Contato contato);
        void DeleteContato(Contato contato);

    }
}
