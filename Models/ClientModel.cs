using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTeste.Models
{
    public class ClientModel
    {
        [Key]
        public int Id { get; set; }
      
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public DateTime BirthDate { get; set; }
        public string Pass { get; set; }
        public bool HaveDebits { get; set; } = false;

    }
}
