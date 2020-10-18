using Domain.Model;
using Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class PessoaRepository : IPessoaRepository
    {
        List<Pessoa> pessoas = new List<Pessoa>
        {
            new Pessoa{ID = 1, Nome = "Ayrton", Sobrenome = "Guttier"}
        };
        public IEnumerable<Pessoa> GetAll()
        {
            return pessoas;
        }

        public Pessoa GetPessoaPorNome(string nome)
        {
            return pessoas.FirstOrDefault(x => x.Nome == nome);
        }
    }
}
