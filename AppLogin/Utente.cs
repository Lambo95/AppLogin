using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogin
{
    internal  class Utente
    {
        public List<DateTime> UtenteDate = new List<DateTime>();

        public DateTime dataEntrata;

        public DateTime dataUscita;
            

        private bool _login;
        public  bool Login {
            get 
            {
                return _login;            
            }
            set 
            {
                _login = Login;  

    }
}
       
        private  bool _logout;
        public  bool Logout {
            get
            {
                return _logout;
            }
            set
            {
                _logout = Logout;
                dataUscita = DateTime.Now;
            }
        }

        public  string Nome { get; set; }
        public  string Password { get; set; }

        public Utente() { }

        public Utente(string nome, string password) {
            Nome= nome;
            Password= password;
        }
        
        public void StampaListaAccessi() {
            
            foreach(var data in UtenteDate) { 
                Console.WriteLine(data.ToString());
            }
        }

    }
}
