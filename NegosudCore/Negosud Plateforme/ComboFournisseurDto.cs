using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud_Plateforme
{
    class ComboFournisseurDto
    {
        public long Id { get; set; }
        public string nomEntreprise { get; set; }
    }

    class Datalist_Fournisseur_List
    {
        public List<ComboFournisseurDto> ListfournisseurList { get; set; }
    }
}
