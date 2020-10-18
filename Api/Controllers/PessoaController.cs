using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepository repository;

        public PessoaController(IPessoaRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public IEnumerable<Domain.Model.Pessoa> GetPessoas()
        {
            return repository.GetAll();
        }
    }
}
