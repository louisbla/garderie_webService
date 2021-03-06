﻿using System.Runtime.Serialization;
using WcfService1.Model;

namespace WcfService1
{
    [DataContract]
    public class Article
    {
        public Article(int idArticle, string nom, int quantite, string Photo, string Description, int InventaireId, int EnfantInventaireId, Categorie Categorie)
        {
            this.idArticle = idArticle;
            this.nom = nom;
            this.quantite = quantite;
            this.Photo = Photo;
            this.Description = Description;
            this.InventaireId = InventaireId;
            this.EnfantInventaireId = EnfantInventaireId;
            this.Categorie = Categorie;
        }
        public Article(int idArticle, string nom)
        {
            this.idArticle = idArticle;
            this.nom = nom;
        }

        [DataMember]
        public int idArticle { get; set; }
        [DataMember]
        public string nom { get; set; }
        [DataMember]
        public int quantite { get; set; }
        [DataMember]
        public string Photo { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int InventaireId { get; set; }
        [DataMember]
        public int EnfantInventaireId { get; set; }
        [DataMember]
        public Categorie Categorie { get; set; }
    }
}