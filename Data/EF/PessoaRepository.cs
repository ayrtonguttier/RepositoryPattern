using Data.EF.Configuration;
using Domain.Model;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.EF
{
    public class PessoaRepository : IPessoaRepository
    {
        DbSet<Pessoa> set;
        public PessoaRepository(Context context)
        {
            this.set = context.Set<Pessoa>();
        }

        public IEnumerable<Pessoa> GetAll()
        {
            return set;
        }

        public Pessoa GetPessoaPorNome(string nome)
        {
            return set.FirstOrDefault(x => x.Nome.Equals(nome));
        }
    }
}
