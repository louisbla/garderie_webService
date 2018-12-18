using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfService1.Model;

namespace WcfService1.DAO
{
    public class ArticleDAO
    {
        public static Article[] GetArticles()
        {
            //string conf = ConfigurationManager.ConnectionStrings["garderie.garderie.dbo"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection("Data Source=tcp:garderie.database.windows.net,1433;Initial Catalog=garderie;User Id=garderie_admin;Password=reallyStrongPwd123;Integrated Security=False;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False");

            try
            {
                conn.Open();
            }
            catch (Exception e)
            {

            }

            SqlCommand cmd = new SqlCommand("SELECT ArticleId, Nom, Quantite, Photo, Description, InventaireId, EnfantInventaireId, CategorieId FROM Articles WHERE visible = 1", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            ICollection<Article> Articles = new List<Article>();

            while (reader.Read())
            {
                int a = (int)reader[0];
                string b = reader[1].ToString();
                int c = reader.GetInt32(2);
                string d = reader[3].ToString();
                string e = reader[4].ToString();
                int f;
                try
                {
                    f = reader.GetInt32(5);
                }
                catch { f = 0; }
                int g;
                try
                {
                    g = reader.GetInt32(6);
                }
                catch { g = 0; }
                Categorie h;
                try
                {
                    h = CategorieDAO.GetCategorieById(reader.GetInt32(7));
                }
                catch { h = null; }

                Articles.Add(new Article((int)reader[0], reader[1].ToString(), (int)reader[2], reader[3].ToString(), reader[4].ToString(), f, g, h));
            }

            conn.Close();

            return Articles.ToArray();
        }


        public static Article GetArticleById(int id)
        {
            var q = from c in GetArticles()
                    where c.idArticle == id
                    select c;
            try
            {
                return q.ToList()[0];
            }
            catch { }
            return new Article(0, "Article inexistant");
        }

        internal static Article GetArticleByName(string name)
        {
            var q = from c in GetArticles()
                    where c.nom == name
                    select c;
            try
            {
                return q.ToList()[0];
            }
            catch { }
            return new Article(0, "Article inexistante");
        }
    }
}
