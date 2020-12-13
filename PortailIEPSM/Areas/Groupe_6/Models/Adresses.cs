using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortailIEPSM.Areas.Groupe_6.Models
{
    public class Adresses
    {
        private string _IdAdresse;
        private string _Rue;
        private string _Numero;
        private string _Ville;
        private string _Code_Postal;
        private string _Pays;
        private string _FK_IdContact;


        public string IdAdresse { get; set; }
        public string Rue { get; set; }
        public string Numero { get; set; }
        public string Ville { get; set; }
        public string Code_Postal { get; set; }
        public string Pays { get; set; }
        public string FK_IdContact { get; set; }


        public Adresses()
        {

        }

        public Adresses(string idAdresse, string rue, string numero, string ville, string code_Postal, string pays, string fk_IdContact)
        {
            IdAdresse = idAdresse;
            Rue = rue;
            Numero = numero;
            Ville = ville;
            Code_Postal = code_Postal;
            Pays = pays;
            FK_IdContact = fk_IdContact;
        }
    }
}
