using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_D1
{
    internal class Atleta
    {
        private string _codicetessera;
        private string _firstname;
        private string _lastname;   
        public string CodiceTessera(int tessera)
        {
            if (tessera == 1000)
            {
                return "Complimenti sei il nostro millesimo atleta";
            }
            else
            {
                return "Grazie di allenarti con noi";
            }
        }
        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }
    }
}
