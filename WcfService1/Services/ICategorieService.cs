﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService1.Model;

namespace WcfService1.Services
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "ICategorieService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ICategorieService
    {
        [OperationContract]
        Categorie GetCategorieById(int idCategorie);

        [OperationContract]
        List<Categorie> GetAllCategories();

        [OperationContract]
        Categorie GetCategorieByName(string name);

    }
}
