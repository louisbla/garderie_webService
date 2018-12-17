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
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "CategorieService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez CategorieService.svc ou CategorieService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class CategorieService : ICategorieService
    {
        
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
