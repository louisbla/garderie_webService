using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfService1.Model;

namespace WcfService1.DAO
{
    public class CategorieDAO
    {
        public static Categorie[] GetCategories()
        {
            //string conf = ConfigurationManager.ConnectionStrings["garderie.garderie.dbo"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection("Data Source=tcp:garderie.database.windows.net,1433;Initial Catalog=garderie;User Id=garderie_admin;Password=reallyStrongPwd123;Integrated Security=False;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False");
            
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM CategoriesArticle", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            ICollection<Categorie> categories = new List<Categorie>();

            while (reader.Read())
            {
                categories.Add(new Categorie((int)reader[0], reader[1].ToString()));
            }

            conn.Close();

            return categories.ToArray();
        }
        

        public static Categorie GetCategorieById(int id)
        {
            var q = from c in GetCategories()
                    where c.idCategorie == id
                    select c;
            try
            {
                return q.ToList()[0];
            }
            catch { }
            return new Categorie(0, "Categorie inexistante");
        }

        internal static Categorie GetCategorieByName(string name)
        {
            var q = from c in GetCategories()
                    where c.nom == name
                    select c;
            try
            {
                return q.ToList()[0];
            }
            catch { }
            return new Categorie(0, "Categorie inexistante");
        }
    }
}