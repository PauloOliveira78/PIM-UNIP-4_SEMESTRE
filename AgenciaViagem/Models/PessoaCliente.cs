using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViagem.Models
{
    internal class PessoaCliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Genero { get; set; }
        public string? CPF { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
        public string? Cidade { get; set; }
        public string? Pais { get; set; }
        public string? Email { get; set; }
        public string? Login { get; set; }
        public int Senha { get; set; }
    }
}
