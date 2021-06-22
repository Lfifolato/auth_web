using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace auth_web.Models
{
    public class escola
    {   
        [Key]
        public int id { get; set; }

        public string nome { get; set; }

        public string cidade { get; set; }

        public string contato { get; set; }

        public string telefone { get; set; }
    }
}
