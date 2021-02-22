using Meta.Backend.Context;
using Meta.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meta.Backend.Data
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly ContatoContext _context;

        public ContatoRepository(ContatoContext context)
        {
            _context = context;
        }

        public void CreateContato(Contato contato)
        {
            if (contato == null)
                throw new ArgumentNullException(nameof(contato));

            _context.Contatos.Add(contato);
        }

        public void DeleteContato(Contato contato)
        {
            if (contato == null)
                throw new ArgumentNullException(nameof(contato));

            _context.Contatos.Remove(contato);
        }

        public IEnumerable<Contato> GetAllContatos()
        {
            return _context.Contatos.ToList();
        }

        public Contato GetContatoById(int id)
        {
            return _context.Contatos.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateContato(Contato contato)
        {

        }
    }
}
