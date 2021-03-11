using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud_Plateforme
{
    class LigneCommandeInterneDto
    {
        public long idProduit { get; set; }
        public long quantite { get; set; }
        public long prixTotal { get; set; }

    }


    class Datalist_Commande_Interne_Select
    {
        public List<CommandeInterneDto> ListcommandeInterne { get; set; }
    }
}
