using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NegoduxAPI.Models
{
    public class CommandeInterne
    {
        public int Id { get; set; }
        public float PrixTotal { get; set; }
        public DateTime DateCommande { get; set; }
        public bool IsActive { get; set; }
        public string Status { get; set; }
    }
}
