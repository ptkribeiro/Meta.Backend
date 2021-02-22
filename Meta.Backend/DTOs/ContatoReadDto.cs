using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meta.Backend.DTOs
{
    public class ContatoReadDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string canal { get; set; }
        public string valor { get; set; }
        public string obs { get; set; }
    }
}
