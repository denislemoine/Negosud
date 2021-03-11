﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud_Plateforme
{
    class CommandeDto
    {
        public long id { get; set; }
        public float prixTotal { get; set; }
        public bool isActive { get; set; }
        public string status { get; set; }

      
    }


    class Datalist_Commande
    {
        public List<CommandeDto> Listcommande{ get; set; }
    }
}
