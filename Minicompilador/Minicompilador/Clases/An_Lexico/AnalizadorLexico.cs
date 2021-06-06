using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Mini_Compilador.Clases.An_Lexico
{
    public class AnalizadorLexico
    {
        
        Tabla_Simbolos reg = new Tabla_Simbolos();
        private principal frm;
        Manejo_errores te = new Manejo_errores();
        public static int numero_de_lineas = 0;
        Regex identificadores = new Regex(@"^[a-zA-Z]+$"); // Expresion regular para reconocer identificadores
        public void puerta(principal form)
        {
            this.frm = form;
        }
        public int aplicar_AnalizadorLexico(string archivo)
        {
            int i = 0;
            int c = 0;
            string leer="", linea, txt ="";
            int errores = 0;
            try
            {
                List<string> Palabras_Separadas = new List<string>();
                string[] lineas = archivo.Split('\n');
                List<string> list = new List<string>();
                frm.txtcodigo.Select(0, frm.txtcodigo.SelectionStart);
                for(i = 0; i < lineas.Length; i++)
                {
                    numero_de_lineas = i + 1;
                    linea = lineas[i];
                    if(Regex.IsMatch(linea, @"(\()|(\))")) //separar ()
                    {
                        if(!Regex.IsMatch(linea, @"((\s\(\s)|(\s\)\s))"))
                        {
                            Match m = Regex.Match(linea, @"(\()");
                            Match n = Regex.Match(linea, @"(\))");
                            if(m.Value != null) { linea = Regex.Replace(linea, @"(\()", " " + m.Value.ToString() + " "); }
                            if (n.Value != null) { linea = Regex.Replace(linea, @"(\))", " " + n.Value.ToString() + " "); }
                        }
                    }
                    if (Regex.IsMatch(linea, @"(\[)|(\])")) //separar []
                    {
                        if (!Regex.IsMatch(linea, @"((\s\[\s)|(\s\]\s))"))
                        {
                            Match m = Regex.Match(linea, @"(\[)");
                            Match n = Regex.Match(linea, @"(\])");
                            if (m.Value != null) { linea = Regex.Replace(linea, @"(\[)", " " + m.Value.ToString() + " "); }
                            if (n.Value != null) { linea = Regex.Replace(linea, @"(\])", " " + n.Value.ToString() + " "); }
                        }
                    }
                    if (Regex.IsMatch(linea, @"(\<\<)|(\>\>)")) //separar << >>
                    {
                        if (!Regex.IsMatch(linea, @"((\s\<\<\s)|(\s\>\>\s))"))
                        {
                            Match m = Regex.Match(linea, @"(\<\<)");
                            Match n = Regex.Match(linea, @"(\>\>)");
                            if (m.Value != null) { linea = Regex.Replace(linea, @"(\<\<)", " " + m.Value.ToString() + " "); }
                            if (n.Value != null) { linea = Regex.Replace(linea, @"(\>\>)", " " + n.Value.ToString() + " "); }
                        }
                    }
                    if (Regex.IsMatch(linea, @"(\=)")) //separar =
                    {
                        if (!Regex.IsMatch(linea, @"((\s\=\s)|(\=\=)|(\:\=)|(<=)|(>=))"))
                        {
                            Match m = Regex.Match(linea, @"(\=)");
                            if (m.Value != null) { linea = Regex.Replace(linea, @"(\=)", " " + m.Value.ToString() + " "); }
                        }
                    }
                    if (Regex.IsMatch(linea, @"(\.)")) //separar .
                    {
                        if (!Regex.IsMatch(linea, @"((\s\.\s))"))
                        {
                            Match m = Regex.Match(linea, @"(\.)");
                            if (m.Value != null) { linea = Regex.Replace(linea, @"(\.)", " " + m.Value.ToString() + " "); }
                        }
                    }
                    if (Regex.IsMatch(linea, @"(\+)")) //separar +
                    {
                        if (!Regex.IsMatch(linea, @"((\s\+\s)|(\+\+))"))
                        {
                            Match m = Regex.Match(linea, @"(\+)");
                            if (m.Value != null) { linea = Regex.Replace(linea, @"(\+)", " " + m.Value.ToString() + " "); }
                        }
                    }
                    if (Regex.IsMatch(linea, @"(\-)")) //separar -
                    {
                        if (!Regex.IsMatch(linea, @"((\s\-\s)|(\-\-))"))
                        {
                            Match m = Regex.Match(linea, @"(\-)");
                            if (m.Value != null) { linea = Regex.Replace(linea, @"(\-)", " " + m.Value.ToString() + " "); }
                        }
                    }
                    if (Regex.IsMatch(linea, @"(\/)")) //separar .
                    {
                        if (!Regex.IsMatch(linea, @"((\s\/\s))"))
                        {
                            Match m = Regex.Match(linea, @"(\/)");
                            if (m.Value != null) { linea = Regex.Replace(linea, @"(\/)", " " + m.Value.ToString() + " "); }
                        }
                    }
                    if (Regex.IsMatch(linea, @"(\*)")) //separar .
                    {
                        if (!Regex.IsMatch(linea, @"((\s\*\s))"))
                        {
                            Match m = Regex.Match(linea, @"(\*)");
                            if (m.Value != null) { linea = Regex.Replace(linea, @"(\*)", " " + m.Value.ToString() + " "); }
                        }
                    }
                    if (Regex.IsMatch(linea, @"(\:)")) //separar .
                    {
                        if (!Regex.IsMatch(linea, @"((\s\:\s)|(\:\=))"))
                        {
                            Match m = Regex.Match(linea, @"(\:)");
                            if (m.Value != null) { linea = Regex.Replace(linea, @"(\:)", " " + m.Value.ToString() + " "); }
                        }
                    }
                    if (Regex.IsMatch(linea, @"(\;)")) //separar ;
                    {
                        if (!Regex.IsMatch(linea, @"((\s\;\s))"))
                        {
                            Match m = Regex.Match(linea, @"(\;)");
                            if (m.Value != null) { linea = Regex.Replace(linea, @"(\;)", " ; "); }
                        }
                    }
                    if (Regex.IsMatch(linea, @"(\:\=)")) //separar :=
                    {
                        if (!Regex.IsMatch(linea, @"((\s\:\=\s))"))
                        {
                            Match m = Regex.Match(linea, @"(\:\=)");
                            if (m.Value != null) { linea = Regex.Replace(linea, @"(\:\=)", " := "); }
                        }
                    }
                    if (Regex.IsMatch(linea, @"(\<\=)")) //separar <=
                    {
                        if (!Regex.IsMatch(linea, @"((\s\<\=\s))"))
                        {
                            Match m = Regex.Match(linea, @"(\<\=)");
                            if (m.Value != null) { linea = Regex.Replace(linea, @"(\<\=)", " <= "); }
                        }
                    }
                    if (Regex.IsMatch(linea, @"(\>\=)")) //separar <=
                    {
                        if (!Regex.IsMatch(linea, @"((\s\>\=\s))"))
                        {
                            Match m = Regex.Match(linea, @"(\>\=)");
                            if (m.Value != null) { linea = Regex.Replace(linea, @"(\>\=)", " >= "); }
                        }
                    }
                    if (Regex.IsMatch(linea, @"(\=\=)")) //separar <=
                    {
                        if (!Regex.IsMatch(linea, @"((\s\=\=\s))"))
                        {
                            Match m = Regex.Match(linea, @"(\=\=)");
                            if (m.Value != null) { linea = Regex.Replace(linea, @"(\=\=)", " == "); }
                        }
                    }
                    if (Regex.IsMatch(linea, @"(\!\=)")) //separar <=
                    {
                        if (!Regex.IsMatch(linea, @"((\s\!\=\s))"))
                        {
                            Match m = Regex.Match(linea, @"(\!\=)");
                            if (m.Value != null) { linea = Regex.Replace(linea, @"(\!\=)", " != "); }
                        }
                    }
                    if (Regex.IsMatch(linea, @"(\<\>)")) //separar <=
                    {
                        if (!Regex.IsMatch(linea, @"((\s\<\>\s))"))
                        {
                            Match m = Regex.Match(linea, @"(\<\>)");
                            if (m.Value != null) { linea = Regex.Replace(linea, @"(\<\>)", " <> "); }
                        }
                    }
                    if (Regex.IsMatch(linea, @"(\+\+)")) //separar <=
                    {
                        if (!Regex.IsMatch(linea, @"((\s\+\+\s))"))
                        {
                            Match m = Regex.Match(linea, @"(\+\+)");
                            if (m.Value != null) { linea = Regex.Replace(linea, @"(\+\+)", " ++ "); }
                        }
                    }
                    if (Regex.IsMatch(linea, @"(\-\-)")) //separar <=
                    {
                        if (!Regex.IsMatch(linea, @"((\s\-\-\s))"))
                        {
                            Match m = Regex.Match(linea, @"(\-\-)");
                            if (m.Value != null) { linea = Regex.Replace(linea, @"(\-\-)", " -- "); }
                        }
                    }
                    if (Regex.IsMatch(linea, @"" + "(\"" + "(.*)" + "\")|('.*')"))
                    {
                        if (Regex.IsMatch(linea, @"" + "(\"" + "(.*)" + "\")"))
                        {
                            leer = linea;
                            linea = Regex.Replace(linea, @"" + "(\"" + "(.*)" + "\")", "x");
                        }
                        if (Regex.IsMatch(linea, @"('.+')"))
                        {
                            leer = linea;
                            linea = Regex.Replace(linea, @"('.+')", "x");
                        }

                    }
                    if (Regex.IsMatch(linea, @"\s(\s)+")) //quitar espacios
                    {
                        linea = Regex.Replace(linea, @"\s(\s)+", " ");
                    }
                    #region texto html
                    if (Regex.IsMatch(linea, @"(\>.+\<)"))
                    {
                        txt = Regex.Match(linea, @"(\>.+\<)").ToString();
                        linea = Regex.Replace(linea, @"(\>.+\<)", "> y <");

                    }
                    #endregion
                    Palabras_Separadas = linea.Trim().Split(' ').ToList();
                    Match z = Regex.Match(leer, @"" + "(\"" + "(.*)" + "\")|('.*')");
                    if (z.Value.ToString() != "")
                    {
                        var x = Palabras_Separadas.FindIndex(y => Regex.IsMatch(y, @"x"));
                        string p = Palabras_Separadas[x];
                        Palabras_Separadas[x] = z.Value.ToString();
                        if (p != "x")
                        {
                            Palabras_Separadas.Add(";");
                        }
                        leer = "";
                    }

                    if (txt != "")
                    {
                        var x = Palabras_Separadas.FindIndex(h => Regex.IsMatch(h, @"y"));
                        Palabras_Separadas[x] = txt;
                        txt = "";
                    }
                    foreach (var palabra in Palabras_Separadas)
                    {
                        if (Regex.IsMatch(palabra, @"(\>[a-zA-Z]+\<)|(\>[a-zA-Z]+)|([a-zA-Z]+\<)"))
                        {
                            string p = "";
                            string html1 = "";

                            #region HTML
                            if (Regex.IsMatch(palabra, @"(\>.+\<)|(\>.+)|(.+\<)"))
                            {

                                Match m = Regex.Match(palabra, @"(\>.+\<)|(\>.+)|(.+\<)");
                                foreach (Match match in m.Captures)
                                {
                                    Match m2 = Regex.Match(match.Value.ToString(), @"(.+)");
                                    foreach (Match match1 in m2.Captures)
                                    {
                                        p = match1.Value.ToString().TrimEnd('<').TrimStart('>');
                                        html1 += p + " ";
                                        md_simbolos nuevo = new md_simbolos(html1.Trim(), numero_de_lineas, numero_de_lineas, "Texto", "de html");
                                        reg.añadir_objeto(nuevo);
                                        html1 = "";
                                    }

                                }
                            }
                            #endregion
                        }
                        //-----------------------------------------------------------------------
                        else if (reg.verificar(palabra.ToString(), numero_de_lineas, c ))// se manda a comparar la palabra con la tabla de simbolos
                        {
                            
                        }
                        
                        else 
                        {
                            if (identificadores.IsMatch(palabra))
                            {
                                md_simbolos nuevo = new md_simbolos(palabra, numero_de_lineas, c, "Identificador", "Representa a un indentificador definido por el usuario");
                                reg.añadir_objeto(nuevo);
                            }
                            else if(Regex.IsMatch(palabra, @"" + "(\"" + "(.*)" + "\")|('.*')"))
                            {
                                md_simbolos nuevo = new md_simbolos(palabra, numero_de_lineas, c, "Cadena", "Representa a una cadena de texto definido por el usuario");
                                reg.añadir_objeto(nuevo);
                            }
                            else
                            {
                                md_simbolos nuevo = new md_simbolos(palabra, numero_de_lineas, c, "Desconocido", "No coincide con la tabla prederteminada");
                                reg.añadir_objeto(nuevo);
                                md_errores md_E = new md_errores(c,numero_de_lineas, "Comando desconocido", "Verique que la palabra este bien escrita", "Sucede cuando una palabra u operador esta mal escrito, si es un texto ignore el error");
                                te.nuevoerror(md_E);
                                errores++;
                            }
                        }
                        c++;
                    }

                }
                comparar_contadores();
                Palabras_Separadas = null;
                MessageBox.Show("Analisis lexico terminado");
                return errores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el analizador lexico " + ex.Message);
                return errores;
            }
            //sen.puerta_analizador(this);
        }
        public void comparar_contadores()
        {
            List<int> x = new List<int>();
            x.Add(reg.cc);
            x.Add(reg.cht);
            x.Add(reg.cj);
            x.Add(reg.cp);
            x.Add(reg.cpl);
            x.Add(reg.ct);

            int z = x.Max();
            if (z != 0) 
            {
                if ((reg.cpl != reg.ct && reg.cpl != reg.cp && reg.cpl != reg.cj && reg.cpl != reg.cht && reg.cpl != reg.cc)
                    || (reg.ct != reg.cpl && reg.ct != reg.cp && reg.ct != reg.cj && reg.ct != reg.cht && reg.ct != reg.cc)
                    || (reg.cp != reg.ct && reg.cp != reg.cpl && reg.cp != reg.cj && reg.cp != reg.cht && reg.cp != reg.cc)
                    || (reg.cj != reg.ct && reg.cj != reg.cp && reg.cj != reg.cpl && reg.cj != reg.cht && reg.cj != reg.cc)
                    || (reg.cht != reg.ct && reg.cht != reg.cp && reg.cht != reg.cj && reg.cht != reg.cpl && reg.cht != reg.cc)
                    || (reg.cc != reg.ct && reg.cc != reg.cp && reg.cc != reg.cj && reg.cc != reg.cht && reg.cc != reg.cpl))
                {
                    if (reg.cc == z) { frm.lblReconocer.Text = "C++"; }
                    if (reg.cht == z) { frm.lblReconocer.Text = "HTML"; }
                    if (reg.cj == z) { frm.lblReconocer.Text = "JavaScript"; }
                    if (reg.cp == z) { frm.lblReconocer.Text = "Pascal"; }
                    if (reg.cpl == z) { frm.lblReconocer.Text = "PL SQL"; }
                    if (reg.ct == z) { frm.lblReconocer.Text = "T-SQL"; }
                }
                else
                {
                    MessageBox.Show("No es posible reconocer el lenguaje");
                   
                }
            }
        }
    }
}
