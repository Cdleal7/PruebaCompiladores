using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Compilador.Clases
{
    class Manejo_errores
    {
        
        public static List<md_errores> TErrores2 = new List<md_errores>();

        public void reinicialista() 
        { 
            TErrores2 = new List<md_errores>();
        }
        public List<md_errores> llamatablaE()
        {
            return TErrores2;
        }
        public void nuevoerror(md_errores error)
        {
            TErrores2.Add(error);  
        }
    }
}

