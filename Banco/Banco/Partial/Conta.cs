using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    partial class Conta
    {
        public string NomeTitularTratado {
            get {
                return Titular.Nome;
            }
        }
    }
}
