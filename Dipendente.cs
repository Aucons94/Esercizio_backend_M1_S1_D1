using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_D1
{
    internal class Dipendente
    {
        private string _nome;
        private string _cognome;
        private string _reddito;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                _cognome = value;
            }
        }

        public string Reddito
        {
            get
            {
                return _reddito;
            }
            set
            {
                _reddito = value;
            }
        }
    }
}
