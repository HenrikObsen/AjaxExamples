﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoMZ.Models.ViewModels
{
    public class ProduktListe
    {
        public Kategori Kategori { get; set; }
        public List<Produkt> Produkter { get; set; }
    }
}
