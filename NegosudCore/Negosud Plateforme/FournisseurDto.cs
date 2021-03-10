using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud_Plateforme
{
    class FournisseurDto
    {
        public long Id { get; set; }
        public string nomEntreprise { get; set; }
        public string nomContact { get; set; }
        public string adresse { get; set; }
        public string tel { get; set; }
        public string mail { get; set; }
        public bool isActive { get; set; }
    }

    class Datalist_Fournisseur
    {
        public List<FournisseurDto> Listfournisseur { get; set; }
    }
}
