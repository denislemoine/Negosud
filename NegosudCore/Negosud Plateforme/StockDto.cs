using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud_Plateforme
{
    class StockDto
    {
        public long id { get; set; }
        public long idProduit { get; set; }
        public int quantite { get; set; }
        public int quantiteCommande { get; set; }
    }


    class Datalist_Stock
    {
        public List<StockDto> ListStock { get; set; }
    }
}
