using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud_Plateforme
{
    class CommandeDto
    {
        public long Id { get; set; }
        public long IdClient { get; set; }
        public float PrixTotal { get; set; }
        public DateTime DateCommande { get; set; }
        public string contenant { get; set; }

        public bool isActive { get; set; }
     
    }




    class Datalist_Commande
    {
        public List<CommandeDto> Listcommande{ get; set; }
    }
}
