using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService1.DAO;
using WcfService1.Model;

namespace WcfService1.Services
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "GarderieService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez GarderieService.svc ou GarderieService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class GarderieService : IGarderieService
    {
        public List<Article> GetAllArticles()
        {
            return ArticleDAO.GetArticles().ToList();
        }

        public Article GetArticleById(int idArticle)
        {
            return ArticleDAO.GetArticleById(idArticle);
        }

        public Article GetArticleByName(string name)
        {
            return ArticleDAO.GetArticleByName(name);
        }

        public List<Categorie> GetAllCategories()
        {
            return CategorieDAO.GetCategories().ToList();
        }

        public Categorie GetCategorieById(int idCategorie)
        {
            return CategorieDAO.GetCategorieById(idCategorie);
        }

        public Categorie GetCategorieByName(string name)
        {
            return CategorieDAO.GetCategorieByName(name);
        }
    }
}
