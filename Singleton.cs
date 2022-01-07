using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigleton
{
    public class Singleton
    {
        public static  Singleton instancia { get; set; }
        public static string nome { get; set; }
        public static Singleton getInstance()
        {
            if (instancia == null)
            {
                instancia = new Singleton();
                nome = "Ana";

            }
            return instancia;
        }
    }
}
