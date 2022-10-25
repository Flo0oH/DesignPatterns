using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton2
{
    class UserContext
    {
        
        public int UserId { get; set; }
        public string UserName { get; set; }

        public void Load()
        {
            UserId = 1;
            UserName = "Florian";
        }
        
        
        //Beispiel für frühe Initialisierung
        public static UserContext instance = new UserContext();
        //Beispiel für späte Initialisierung
        public static UserContext instancelate;
        private UserContext() { }

        static UserContext Instance { get
            {
                instance.Load();
                return instance;
            }
        }   
        static UserContext Instancelate
        {
            get
            {
                if (instancelate == null)
                    instancelate = new UserContext();
                return instancelate;
            }
        }
    }
}
