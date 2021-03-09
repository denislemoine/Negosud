using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud_Plateforme
{
    class FamilleDto
    {
        public long Id { get; set; }
        public string libele { get; set; }
        public bool isActive { get; set; }
    }

    class Datalist_Familles
    {
        public List<ClientDto> ListFamille { get; set; }
    }

}
