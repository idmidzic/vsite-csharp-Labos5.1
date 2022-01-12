using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Data;

namespace vsite_csharp_Labos5._1
{
    public partial class LogIn : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool CheckUsernamePasword()
        {
            XElement korisnici = XElement.Load(@"C:\Users\Ida\source\repos\vsite-csharp-Labos5.1\vsite-csharp-Labos5.1\App_Data\korisnici.xml");
            var users = from user in korisnici.Elements("korisnik")
                        select new
                        {
                            username = (string)user.Element("korisničkoIme"),
                            Password = (string)user.Element("lozinka")
                        };
            foreach (var user in users)
            {
                if (string.Compare(user.username,TextBoxUsername.Text) == 0 
                    && (user.Password == TextBoxPassword.Text))
                return true;
            }
            return false;
        }
        
        protected void DisplayBooks()
        {
            PanelDisplay.Visible = true;
            using (DataSet ds = new DataSet())
            {
                ds.ReadXml(@"C:\Users\Ida\source\repos\vsite-csharp-Labos5.1\vsite-csharp-Labos5.1\App_Data\popisKnjiga.xml");
                GridViewData.DataSource = ds;
                GridViewData.DataBind();
            }

        }
        
        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (!CheckUsernamePasword())
                PanelError.Visible = true;
            else DisplayBooks();
        }
    }
}