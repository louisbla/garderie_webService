using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.Model
{
    [DataContract]
    public class Categorie
    {
        public Categorie(int idCategorie, string nom)
        {
            this.idCategorie = idCategorie;
            this.nom = nom;
        }

        [DataMember]
        public int idCategorie { get; set; }
        [DataMember]
        public string nom { get; set; }


    }
}