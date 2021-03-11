using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud_Plateforme
{
    class CommandeInterneDto
     {
        public long id { get; set; }
        public long prixTotal { get; set; }
        public bool isActive { get; set; }
        public string status { get; set; }


    }


    class Datalist_Commande_Interne
    {
        public List<CommandeInterneDto> ListcommandeInterne { get; set; }
    }
}
