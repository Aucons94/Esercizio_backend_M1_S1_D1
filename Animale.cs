using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_D1
{
    internal class Animale
    { 
        private string _specie;
        private string _razza;
        public string Specie
        {  
          get
            {
               return _specie;
            }
            set 
            {
                _specie = value;
            }
        }
        public string Razza 
        { 
            get
            {
                return _razza;
            }
            set
            {
                _razza = value;
            } 
        }

    }
}
