using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Compilador.Clases.An_Lexico
{
    public class Tabla_Simbolos
    {
        public static List<md_simbolos> reglas = new List<md_simbolos>();
        public static List<md_simbolos> Tabla_simbolos = new List<md_simbolos>();
        public int cc = 0, cj = 0, cp = 0, ct=0, cpl = 0, cht=0;
        public List<md_simbolos> TSimbolos2
        {
            get { return reglas; }
            set { reglas = value; }
        }

        public List<md_simbolos> versimbolos()
        {
            return Tabla_simbolos;
        }
        public void limpiar()
        {
            Tabla_simbolos = new List<md_simbolos>();
        }
        public void establecer_reglas()
        {
            md_simbolos ts = new md_simbolos("marca", 0, 0, "Palabra reservada", "Palabra para asignar la marca del telefono");
            reglas.Add(ts);
            //0 sql 5 t y 6 pl
            //1 pascal
            //2 JS
            //3 c++
            //4 html
            #region Palabras Reservadas
            ts = new md_simbolos("alter", 0, 65, "Palabra reservada", "Palabra para realizar modificaciones");
            reglas.Add(ts);
            ts = new md_simbolos("into", 0, 65, "Palabra reservada", "Palabra para ingresar datos con insert");
            reglas.Add(ts);
            ts = new md_simbolos("group", 0, 65, "Palabra reservada", "Palabra para establecer grupos");
            reglas.Add(ts);
            ts = new md_simbolos("all", 0, 65, "Palabra reservada", "Palabra seleccionar todos");
            reglas.Add(ts);
            ts = new md_simbolos("program", 0, 1, "Palabra reservada", "Palabra para inicializar nuevo programa");
            reglas.Add(ts);
            ts = new md_simbolos("label", 0, 1, "Palabra reservada", "Palabra para etiqueta");
            reglas.Add(ts);
            ts = new md_simbolos("external", 0, 1, "Palabra reservada", "Palabra para definir instruccion");
            reglas.Add(ts);
            ts = new md_simbolos("object", 0, 1, "Palabra reservada", "Palabra para de objeto");
            reglas.Add(ts);
            ts = new md_simbolos("mod", 0, 1, "Palabra reservada", "Palabra para establecer mod");
            reglas.Add(ts);
            ts = new md_simbolos("integer", 0, 1, "Palabra reservada", "Palabra para definir un entero");
            reglas.Add(ts);
            ts = new md_simbolos("log", 0, 2, "Palabra reservada", "Palabra de javascript");
            reglas.Add(ts);
            ts = new md_simbolos("public", 0, 230, "Palabra reservada", "Palabra para hacer publico");
            reglas.Add(ts);
            ts = new md_simbolos("primary", 0, 5, "Palabra reservada", "Palabra para establecer primariedad");
            reglas.Add(ts);
            ts = new md_simbolos("private", 0, 213, "Palabra reservada", "Palabra para establecer proteccion");
            reglas.Add(ts);
            ts = new md_simbolos("default", 0, 2, "Palabra reservada", "Palabra para un valor por defecto");
            reglas.Add(ts);
            ts = new md_simbolos("console", 0, 2, "Palabra reservada", "Palabra para llamar consola");
            reglas.Add(ts);
            ts = new md_simbolos("class", 0, 32, "Palabra reservada", "Palabra para establecer una clase");
            reglas.Add(ts);
            ts = new md_simbolos("asm", 0, 3, "Palabra reservada", "Palabra de c++");
            reglas.Add(ts);
            ts = new md_simbolos("delete", 0, 652, "Palabra reservada", "Palabra para eliminar");
            reglas.Add(ts); 
            ts = new md_simbolos("begin", 0, 651, "Palabra reservada", "Palabra para inicializar");
            reglas.Add(ts);
            ts = new md_simbolos("declare", 0, 65, "Palabra reservada", "Palabra para realizar declaraciones");
            reglas.Add(ts);
            ts = new md_simbolos("on", 0, 65, "Palabra reservada", "Palabra para definir lugar");
            reglas.Add(ts);
            ts = new md_simbolos("else", 0, 12365, "Palabra reservada", "Palabra para definir accion");
            reglas.Add(ts);
            ts = new md_simbolos("if", 0, 12365, "Palabra reservada", "Palabra para definir accion");
            reglas.Add(ts);
            ts = new md_simbolos("select", 0, 65, "Palabra reservada", "Palabra para realizar seleccion");
            reglas.Add(ts);
            ts = new md_simbolos("insert", 0, 65, "Palabra reservada", "Palabra para realizar inserciones");
            reglas.Add(ts);
            ts = new md_simbolos("update", 0, 65, "Palabra reservada", "Palabra para realizar una actualizacion");
            reglas.Add(ts);
            ts = new md_simbolos("of", 0, 65, "Palabra reservada", "Palabra de SQL");
            reglas.Add(ts);
            ts = new md_simbolos("values", 0, 65, "Palabra reservada", "Palabra para asignar valores");
            reglas.Add(ts);
            ts = new md_simbolos("table", 0, 65, "Palabra reservada", "Palabra para definir una tabla");
            reglas.Add(ts);
            ts = new md_simbolos("create", 0, 65, "Palabra reservada", "Palabra para crear");
            reglas.Add(ts);
            ts = new md_simbolos("as", 0, 65, "Palabra reservada", "Palabra para definir");
            reglas.Add(ts);
            ts = new md_simbolos("procedure", 0, 65, "Palabra reservada", "Palabra para crear un procedimiento");
            reglas.Add(ts);
            ts = new md_simbolos("proc", 0, 5, "Palabra reservada", "Palabra para crear un procedimiento");
            reglas.Add(ts);
            ts = new md_simbolos("catch", 0, 23, "Palabra reservada", "Palabra para capturar un valor");
            reglas.Add(ts);
            ts = new md_simbolos("restore", 0, 5, "Palabra reservada", "Palabra para restaurar datos");
            reglas.Add(ts);
            ts = new md_simbolos("from", 0, 65, "Palabra reservada", "Palabra para realizar manipulacion de datos");
            reglas.Add(ts);
            ts = new md_simbolos("set", 0, 651, "Palabra reservada", "Palabra para asignar dato");
            reglas.Add(ts);
            ts = new md_simbolos("inner", 0, 5, "Palabra reservada", "Palabra para unir");
            reglas.Add(ts);
            ts = new md_simbolos("join", 0, 5, "Palabra reservada", "Palabra para unir");
            reglas.Add(ts);
            ts = new md_simbolos("null", 0, 6523, "Palabra reservada", "Palabra para definir valor nulo");
            reglas.Add(ts);
            ts = new md_simbolos("database", 0, 5, "Palabra reservada", "Palabra para definir base de datos");
            reglas.Add(ts);
            ts = new md_simbolos("data_base", 0, 6, "Palabra reservada", "Palabra para definir base de datos");
            reglas.Add(ts);
            ts = new md_simbolos("schedule", 0, 6, "Palabra reservada", "Palabra para crear esquema");
            reglas.Add(ts);
            ts = new md_simbolos("cin", 0, 3, "Palabra reservada", "Palabra para hacer lectura");
            reglas.Add(ts);
            ts = new md_simbolos("cout", 0, 3, "Palabra reservada", "Palabra para escribir en pantalla");
            reglas.Add(ts);
            ts = new md_simbolos("int", 0, 6523, "Palabra reservada", "Palabra para dato entero");
            reglas.Add(ts);
            ts = new md_simbolos("double", 0, 6523, "Palabra reservada", "Palabra para dato double");
            reglas.Add(ts);
            ts = new md_simbolos("const", 0, 321, "Palabra reservada", "Palabra para definir constante");
            reglas.Add(ts);
            ts = new md_simbolos("return", 0, 6523, "Palabra reservada", "Palabra para retornar valor");
            reglas.Add(ts);
            ts = new md_simbolos("namespace", 0, 3, "Palabra reservada", "Palabra para hacer uso de libs");
            reglas.Add(ts);
            ts = new md_simbolos("main", 0, 3, "Palabra reservada", "Palabra para nueva clase principal");
            reglas.Add(ts);
            ts = new md_simbolos("#include", 0, 3, "Palabra reservada", "Palabra para utilizar librerias");
            reglas.Add(ts);
            ts = new md_simbolos("end", 0, 165, "Palabra reservada", "Palabra para finalizar instruccion");
            reglas.Add(ts);
            ts = new md_simbolos("string", 0, 126, "Palabra reservada", "Palabra para dato de cadena");
            reglas.Add(ts);
            ts = new md_simbolos("var", 0, 124, "Palabra reservada", "Palabra para definir variable");
            reglas.Add(ts);
            ts = new md_simbolos("let", 0, 2, "Palabra reservada", "Palabra para JavaScript");
            reglas.Add(ts);
            ts = new md_simbolos("break", 0, 2316, "Palabra reservada", "Palabra para suspender proceso");
            reglas.Add(ts);
            ts = new md_simbolos("interface", 0, 216, "Palabra reservada", "Palabra para utilizar interfaces");
            reglas.Add(ts);
            ts = new md_simbolos("void", 0, 236, "Palabra reservada", "Palabra para crear nuevo metodo");
            reglas.Add(ts);
            ts = new md_simbolos("with", 0, 2165, "Palabra reservada", "Palabra para acompañar dato");
            reglas.Add(ts);
            ts = new md_simbolos("enum", 0, 32, "Palabra reservada", "Palabra para enumerar");
            reglas.Add(ts);
            ts = new md_simbolos("continue", 0, 2351, "Palabra reservada", "Palabra para continuar instruccion");
            reglas.Add(ts);
            ts = new md_simbolos("final", 0, 26, "Palabra reservada", "Palabra para definir final de instrccion");
            reglas.Add(ts);
            ts = new md_simbolos("new", 0, 6123, "Palabra reservada", "Palabra para hace uso de nuevos");
            reglas.Add(ts);
            ts = new md_simbolos("package", 0, 26, "Palabra reservada", "Palabra para utilizar paquetes");
            reglas.Add(ts);
            ts = new md_simbolos("this", 0, 23, "Palabra reservada", "Palabra para referenciar la clase actual");
            reglas.Add(ts);
            ts = new md_simbolos("<script>", 0, 2, "Palabra reservada", "Palabra para referenciar script");
            reglas.Add(ts);
            ts = new md_simbolos("</script>", 0, 2, "Palabra reservada", "Palabra para finalizar script");
            reglas.Add(ts);
            ts = new md_simbolos("function", 0, 2, "Palabra reservada", "Palabra establecer funcion");
            reglas.Add(ts);
            ts = new md_simbolos("<!DOCTYPE html>", 0, 4, "Palabra reservada", "Palabra para inicializar html");
            reglas.Add(ts);
            ts = new md_simbolos("<html>", 0, 4, "Palabra reservada", "Palabra para inicializar html");
            reglas.Add(ts);
            ts = new md_simbolos("<head>", 0, 4, "Palabra reservada", "Palabra establecer cabecera");
            reglas.Add(ts);
            ts = new md_simbolos("<body>", 0, 4, "Palabra reservada", "Palabra para inicializar body");
            reglas.Add(ts);
            ts = new md_simbolos("<title>", 0, 4, "Palabra reservada", "Palabra para inicializar title");
            reglas.Add(ts);
            ts = new md_simbolos("<p>", 0, 4, "Palabra reservada", "Palabra para inicializar p");
            reglas.Add(ts);
            ts = new md_simbolos("<b>", 0, 4, "Palabra reservada", "Palabra para inicializar b");
            reglas.Add(ts);
            ts = new md_simbolos("<em>", 0, 4, "Palabra reservada", "Palabra para inicializar em");
            reglas.Add(ts);
            ts = new md_simbolos("<strong>", 0, 4, "Palabra reservada", "Palabra para inicializar strong");
            reglas.Add(ts);
            ts = new md_simbolos("<form>", 0, 4, "Palabra reservada", "Palabra para inicializar form");
            reglas.Add(ts);
            ts = new md_simbolos("<form>", 0, 4, "Palabra reservada", "Palabra para inicializar button");
            reglas.Add(ts);
            ts = new md_simbolos("<select>", 0, 4, "Palabra reservada", "Palabra para inicializar select");
            reglas.Add(ts);
            ts = new md_simbolos("</html>", 0, 4, "Palabra reservada", "Palabra para finalizar html");
            reglas.Add(ts);
            ts = new md_simbolos("</head>", 0, 4, "Palabra reservada", "Palabra para finalizar head");
            reglas.Add(ts);
            ts = new md_simbolos("</body>", 0, 4, "Palabra reservada", "Palabra para finalizar body");
            reglas.Add(ts);
            ts = new md_simbolos("</title>", 0, 4, "Palabra reservada", "Palabra para finalizar title");
            reglas.Add(ts);
            ts = new md_simbolos("</p>", 0, 4, "Palabra reservada", "Palabra para finalizar p");
            reglas.Add(ts);
            ts = new md_simbolos("</b>", 0, 4, "Palabra reservada", "Palabra para finalizar b");
            reglas.Add(ts);
            ts = new md_simbolos("</em>", 0, 4, "Palabra reservada", "Palabra para finalizar em");
            reglas.Add(ts);
            ts = new md_simbolos("</strong>", 0, 4, "Palabra reservada", "Palabra para finalizar strong");
            reglas.Add(ts);
            ts = new md_simbolos("</form>", 0, 4, "Palabra reservada", "Palabra para finalizar form");
            reglas.Add(ts);
            ts = new md_simbolos("</button>", 0, 4, "Palabra reservada", "Palabra para finalizar button");
            reglas.Add(ts);
            ts = new md_simbolos("</select>", 0, 4, "Palabra reservada", "Palabra para finalizar select");
            reglas.Add(ts);
            #endregion

            #region Expresiones logicas
            ts = new md_simbolos("xor", 0, 1, "Expresion logica", "Expresion XOR");
            reglas.Add(ts);
            ts = new md_simbolos("and", 0, 651, "Expresion logica", "Expresion XOR");
            reglas.Add(ts);
            ts = new md_simbolos(":=", 0, 1, "Operador de asignacion", "Operador de asignacion de valores");
            reglas.Add(ts);
            ts = new md_simbolos("=", 0, 235, "Operador de asignacion", "Operador de asignacion");
            reglas.Add(ts);
            ts = new md_simbolos(":", 0, 1, "Operador Relacional", "Operador Relacional");
            reglas.Add(ts);
            ts = new md_simbolos(";", 0, 213, "Operador Relacional", "Operador Relacional");
            reglas.Add(ts);
            ts = new md_simbolos("(", 0, 65231, "Operador Relacional", "Operador Relacional");
            reglas.Add(ts);
            ts = new md_simbolos(")", 0, 65231, "Operador Relacional", "Operador Relacional");
            reglas.Add(ts);
            ts = new md_simbolos("{", 0, 23, "Operador Relacional", "Operador Relacional");
            reglas.Add(ts);
            ts = new md_simbolos("}", 0, 23, "Operador Relacional", "Operador Relacional");
            reglas.Add(ts);
            ts = new md_simbolos("[", 0, 2365, "Operador Relacional", "Operador Relacional");
            reglas.Add(ts);
            ts = new md_simbolos("]", 0, 2365, "Operador Relacional", "Operador Relacional");
            reglas.Add(ts);
            ts = new md_simbolos("<", 0, 32165, "Operador Relacional", "Operador Relacional");
            reglas.Add(ts);
            ts = new md_simbolos(">", 0, 32165, "Operador Relacional", "Operador Relacional");
            reglas.Add(ts);
            ts = new md_simbolos("<=", 0, 32165, "Operador Relacional", "Operador Relacional");
            reglas.Add(ts);
            ts = new md_simbolos(">=", 0, 32165, "Operador Relacional", "Operador Relacional");
            reglas.Add(ts);
            ts = new md_simbolos("<>", 0, 651, "Operador Relacional", "Operador Relacional");
            reglas.Add(ts);
            ts = new md_simbolos("==", 0, 2, "Operador Relacional", "Operador Relacional");
            reglas.Add(ts);
            ts = new md_simbolos("!=", 0, 2365, "Operador Relacional", "Operador Relacional");
            reglas.Add(ts);
            ts = new md_simbolos("like", 0, 65, "Expresion logica", "Expresion like");
            reglas.Add(ts);
            ts = new md_simbolos("in", 0, 2, "Expresion logica", "Expresion in");
            reglas.Add(ts);
            ts = new md_simbolos("&&", 0, 23, "Expresion logica", "Expresion &&");
            reglas.Add(ts);
            ts = new md_simbolos("||", 0, 23, "Expresion logica", "Expresion ||");
            reglas.Add(ts);
            ts = new md_simbolos("<<", 0, 3, "Expresion logica", "Expresion <<");
            reglas.Add(ts);
            ts = new md_simbolos(">>", 0, 3, "Expresion logica", "Expresion >>");
            reglas.Add(ts);
            #endregion
            #region Expresiones matematicas
            ts = new md_simbolos("+", 0, 16523, "Expresiones matematicas", "Expresion ");
            reglas.Add(ts);
            ts = new md_simbolos("-", 0, 16523, "Expresiones matematicas", "Expresion ");
            reglas.Add(ts);
            ts = new md_simbolos("*", 0, 16523, "Expresiones matematicas", "Expresion ");
            reglas.Add(ts);
            ts = new md_simbolos("/", 0, 16523, "Expresiones matematicas", "Expresion ");
            reglas.Add(ts);
            ts = new md_simbolos("++", 0, 23, "Expresiones matematicas", "Expresion ");
            reglas.Add(ts);
            ts = new md_simbolos("--", 0, 23, "Expresiones matematicas", "Expresion ");
            reglas.Add(ts);
            ts = new md_simbolos("+", 0, 16523, "Expresiones matematicas", "Expresion ");
            reglas.Add(ts);
            ts = new md_simbolos("+", 0, 16523, "Expresiones matematicas", "Expresion ");
            reglas.Add(ts);
            #endregion
            #region ciclos
            ts = new md_simbolos("for", 0, 23651, "Ciclos", "Ciclo FOR ");
            reglas.Add(ts);
            ts = new md_simbolos("do", 0, 231, "Ciclos", "Ciclo do ");
            reglas.Add(ts);
            ts = new md_simbolos("while", 0, 23651, "Ciclos", "Ciclo while ");
            reglas.Add(ts);
            #endregion
            #region Condicionales
            ts = new md_simbolos("if", 0, 23651, "Condicionales", "Condicional if ");
            reglas.Add(ts);
            ts = new md_simbolos("switch", 0, 231, "Condicionales", "Condicional switch ");
            reglas.Add(ts);
            ts = new md_simbolos("then", 0, 651, "Condicionales", "Condicional then ");
            reglas.Add(ts);
            ts = new md_simbolos("where", 0, 65, "Condicionales", "Condicional where ");
            reglas.Add(ts);
            #endregion
            #region funciones
            ts = new md_simbolos("Date", 0, 2, "Funciones", "Funcion Date ");
            reglas.Add(ts);
            ts = new md_simbolos("ToString", 0, 2, "Funciones", "Funcion  ToString");
            reglas.Add(ts);
            ts = new md_simbolos("length", 0, 2, "Funciones", "Funcion length ");
            reglas.Add(ts);
            ts = new md_simbolos("getHours", 0, 2, "Funciones", "Funcion getHours ");
            reglas.Add(ts);
            ts = new md_simbolos("getMinutes", 0, 2, "Funciones", "Funcion  getMinutes");
            reglas.Add(ts);
            ts = new md_simbolos("getSeconds", 0, 2, "Funciones", "Funcion getSeconds ");
            reglas.Add(ts);
            ts = new md_simbolos("write", 0, 1, "Funciones", "Funcion write ");
            reglas.Add(ts);
            ts = new md_simbolos("writeln", 0, 1, "Funciones", "Funcion write writeln");
            reglas.Add(ts);
            ts = new md_simbolos("readln", 0, 1, "Funciones", "Funcion write ");
            reglas.Add(ts);
            ts = new md_simbolos("read", 0, 5, "Funciones", "Funcion write read");
            reglas.Add(ts);
            ts = new md_simbolos("by", 0, 6, "Funciones", "Funcion write by ");
            reglas.Add(ts);
            #endregion

        }
        public bool verificar(string palabra, int num_linea, int id)
        {
            establecer_reglas();
            bool r = false;
            foreach(var pal in reglas)
            {
                if(pal.valor == palabra)
                {
                    md_simbolos tab = new md_simbolos(pal.valor, num_linea, id, pal.tipo, pal.descripcion);
                    Tabla_simbolos.Add(tab);
                    r = true;
                    if (pal.id.ToString().Contains("1"))
                    {
                        cp += 1;
                    }
                    if (pal.id.ToString().Contains("2"))
                    {
                        cj += 1;
                    }
                    if (pal.id.ToString().Contains("3"))
                    {
                        cc += 1;
                    }
                    if (pal.id.ToString().Contains("4"))
                    {
                        cht += 1;
                    }
                    if (pal.id.ToString().Contains("5"))
                    {
                        ct += 1;
                    }
                    if (pal.id.ToString().Contains("6"))
                    {
                        cpl += 1;
                    }
                    break;
                }
                else
                {
                    r = false;
                }
            }
            reglas.Clear();
            return r;
        }
        public void añadir_objeto(md_simbolos Ts)
        {
            Tabla_simbolos.Add(Ts);
        }

    }
}
