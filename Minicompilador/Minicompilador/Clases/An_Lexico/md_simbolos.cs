using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Compilador.Clases.An_Lexico
{
   public class md_simbolos
    {

        public string valor;
        public int NumLinea;
        public int id;
        public string tipo;
        public string descripcion;

        public md_simbolos(string valor, int num_linea, int id, string tipo, string descrip)
        {

            this.valor = valor;
            NumLinea = num_linea;
            this.id = id;
            this.tipo = tipo;
            descripcion = descrip;

            
        }
        public md_simbolos()
        {


        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        public int Numero_de_linea
        {
            get { return NumLinea; }
            set { NumLinea = value; }
        }
        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

    }
}
