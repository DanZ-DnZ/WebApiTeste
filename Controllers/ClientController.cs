using Microsoft.AspNetCore.Mvc;
using System;
using WebApiTeste.Models;
using WebApiTeste.Services;

namespace WebApiTeste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        int daysTo18 = 6570;

        private readonly IClientService ClientService;

        public ClientController(IClientService clientService)
        {
            ClientService = clientService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var ClientList = ClientService.GetClients();

            return Ok(ClientList);
        }

        [HttpPost]
        public IActionResult Post([FromQuery] string nome, [FromQuery] int cpf, [FromQuery] DateTime date, [FromQuery] string pass, [FromQuery] bool hd)
        {
            

            if(DateTime.Now.Subtract(date).TotalDays >= daysTo18)
            {
                ClientService.Add(new ClientModel()
                {
                    Nome = nome,
                    Cpf = cpf,
                    BirthDate = date,
                    Pass = pass,
                    HaveDebits = hd
                });
                return Ok();
            }

            return ValidationProblem("Idade Inferior a 18 Anos");
        }

        [HttpPut]
        public IActionResult Put([FromQuery] string nome, [FromQuery] int cpf, [FromQuery] DateTime date, [FromQuery] string pass, [FromQuery] bool hd)
        {
            if (DateTime.Now.Subtract(date).TotalDays >= daysTo18)
            {
                ClientService.Update(new ClientModel()
                {
                    Nome = nome,
                    Cpf = cpf,
                    BirthDate = date,
                    Pass = pass,
                    HaveDebits = hd
                });
                return Ok();
            }
            return ValidationProblem("Idade Inferior a 18 Anos");
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] int id)
        {
            ClientService.Delete(id);

            return Ok();
        }
    }
}
