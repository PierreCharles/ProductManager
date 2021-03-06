﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.ProductManager.Entities
{
    /// <summary>
    ///  Entité Produit
    /// </summary>
    public class Produit
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Nom { get; set; }
        public string Status { get; set; }
        public int Stock { get; set; }
        public float Prix { get; set; }
        public int CategorieID { get; set; }
        public Categorie Categorie { get; set; }
        public int CommandeID { get; set; }
        public Commande Commande { get; set; }
        public virtual ICollection<LogProduit> LogProduits { get; set; }
    }
}
