using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories
{
    public interface IPessoaRepository : IRepository<Model.Pessoa>
    {
        Model.Pessoa GetPessoaPorNome(string nome);
    }
}
