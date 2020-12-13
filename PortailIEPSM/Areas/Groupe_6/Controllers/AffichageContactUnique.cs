using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PortailIEPSM.Areas.Groupe_6.Models;
using System.Data.SqlClient;
using System.Dynamic;

namespace PortailIEPSM.Areas.Groupe_6.Controllers
{
    [Area("Groupe_6")]
    public class AffichageContactUnique : Controller
    {

        SqlCommand selectContact = new SqlCommand();
        SqlDataReader dataRead;
        SqlConnection con = new SqlConnection();
        private readonly ILogger<AffichageContacts> _logger;

        public List<Contacts> GetContact(int id)
        {
            List<Contacts> contacts = new List<Contacts>();
            try
            {
                con.Open();
                selectContact.Connection = con;
                selectContact.CommandText = "SELECT * FROM [GestionContact].[dbo].[Contacts] where idContact = " + id;
                dataRead = selectContact.ExecuteReader();
                while (dataRead.Read())
                {
                    contacts.Add(new Contacts()
                    {
                        IdContact = dataRead["IdContact"].ToString(),
                        Nom = dataRead["Nom"].ToString(),
                        Prenom = dataRead["Prenom"].ToString(),
                        GSM = dataRead["GSM"].ToString(),
                        Telephone = dataRead["Telephone"].ToString(),
                        Mail = dataRead["Mail"].ToString(),
                        Genre = dataRead["Genre"].ToString(),
                        Nationalite = dataRead["Nationalite"].ToString(),

                    });
                }
                con.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return contacts;
        }

        public AffichageContactUnique(ILogger<AffichageContacts> logger)
        {
            _logger = logger;
            con.ConnectionString = PortailIEPSM.Properties.Resources.ConnectionString;
        }

        public IActionResult Index(int id)
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.ContactMod = GetContact(id);
            return View(mymodel);
        }


    }
}
