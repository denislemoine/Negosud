using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NegosudWeb.Models
{
    public class Fournisseur
    {
        public long Id { get; set; }
        public string NomEntreprise { get; set; }
        public string NomContact { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public bool IsActive { get; set; }

    }
}