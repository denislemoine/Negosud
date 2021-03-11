using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NegosudWeb.Models
{
    public class Famille
    {
        public long Id { get; set; }
        public string Libelle { get; set; }
        public bool IsActive { get; set; }

    }
}