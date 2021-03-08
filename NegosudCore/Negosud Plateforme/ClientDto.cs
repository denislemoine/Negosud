using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud_Plateforme
{
    class ClientDto
    {
        public long Id { get; set; }
        public string nom { get; set; }
        public string mail { get; set; }
        public string Adresse { get; set; }
        public string tel { get; set; }
        public bool isActive { get; set; }
    }
  
    class Datalist
    {
        public List<ClientDto> ListClient { get; set; }
    }
}
