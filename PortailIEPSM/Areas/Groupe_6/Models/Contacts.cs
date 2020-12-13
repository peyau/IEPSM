using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortailIEPSM.Areas.Groupe_6.Models
{
    public class Contacts
    {
        private string _IdContact;
        private string _Nom;
        private string _Prenom;
        private string _GSM;
        private string _Telephone;
        private string _Mail;
        private string _Nationalite;
        private string _Genre;

        public string IdContact { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string GSM { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        public string Nationalite { get; set; }
        public string Genre { get; set; }


        public Contacts()
        {

        }

        public Contacts(string idContact, string nom, string prenom, string gsm, string telephone, string mail, string nationalite, string genre)
        {
            IdContact = idContact;
            Nom = nom;
            Prenom = prenom;
            GSM = gsm;
            Telephone = telephone;
            Mail = mail;
            Nationalite = nationalite;
            Genre = genre;
        }


    }
}
