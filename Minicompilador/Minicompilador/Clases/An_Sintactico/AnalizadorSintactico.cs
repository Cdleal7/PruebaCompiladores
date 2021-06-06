using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Compilador.Clases.An_Sintactico
{
    public class AnalizadorSintactico
    {
        private principal frm;
        Manejo_errores me = new Manejo_errores();
        public int Analizador_Sintactico(string[] sentencias, string l)
        {
            int c = 0;
            int errores = 0;
            if(l == "C++")
            {
                #region c++
                for (int i = 0; i < sentencias.Length; i++)
                {
                    c += sentencias.Length;
                    if (sentencias[i] != null)
                    {
                        string x = sentencias[i];

                        switch (true)
                        {
                            case bool _ when new Regex(@"^public").IsMatch(x):
                                #region public
                                if (Regex.IsMatch(sentencias[i], @"^public\s((int\s([a-zA-Z_](\w+)?)\s\;)|(int\s([a-zA-Z_](\w+)?)\s\=\s\w+\s\;)|(void\s([a-zA-Z_](\w+)?)\s\(\s\)))"))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("public");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    System.Windows.Forms.MessageBox.Show("Sintaxis de public correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("public");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("public");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    System.Windows.Forms.MessageBox.Show("La sintaxis de public es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de public es correcta", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^private").IsMatch(x):
                                #region private
                                if (Regex.IsMatch(sentencias[i], @"^private\s((int\s([a-zA-Z_](\w+)?)\s\;)|(int\s([a-zA-Z_](\w+)?)\s\=\s\w+\s\;)|(void\s([a-zA-Z_](\w+)?)\s\(\s\)))"))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("private");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    System.Windows.Forms.MessageBox.Show("Asignacion private correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("private");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("private");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    System.Windows.Forms.MessageBox.Show("La sintaxis de private es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de private es correcta", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^#include").IsMatch(x):
                                #region #include
                                if (Regex.IsMatch(sentencias[i], @"^#include\s\<.+\>$", RegexOptions.IgnoreCase))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("include");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    MessageBox.Show("Sintaxis de #include correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("#include");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("#include");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    MessageBox.Show("La sintaxi de #include es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de #include es correcta", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^cin").IsMatch(x):
                                #region cin
                                if (Regex.IsMatch(sentencias[i], @"^cin\s(>>)\s(\w+)\s\;$", RegexOptions.IgnoreCase))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("cin");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    MessageBox.Show("Sintaxis correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("cin");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("cin");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    MessageBox.Show("La sintaxis de cin es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de cin es correcta", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^cout").IsMatch(x):
                                #region cout
                                if (Regex.IsMatch(sentencias[i], @"^cout\s<<\s((" + "\"" + ".+" + "\"" + @")(\s\+\s\w+)?)\s\;$", RegexOptions.IgnoreCase))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("cout");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    MessageBox.Show("Sintaxis de cout correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("cout");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("cin");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    MessageBox.Show("La sintaxis de cout es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de cout es correcta", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^int").IsMatch(x):
                                #region int
                                if (Regex.IsMatch(sentencias[i], @"^int\s((main\s\(\s\))|(([a-zA-Z_])(\w+)?\s(=)\s(\w+)\s\;))$", RegexOptions.IgnoreCase))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("int");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    MessageBox.Show("Sintaxis de int correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("int");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("int");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    MessageBox.Show("La sintaxis de int es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de int es correcta", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^double").IsMatch(x):
                                #region double
                                if (Regex.IsMatch(sentencias[i], @"^double\s(([a-zA-Z_])(\w+)?\s(=)\s(\w+)\s\;)$", RegexOptions.IgnoreCase))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("double");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    MessageBox.Show("Sintaxis de double correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("double");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("double");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    MessageBox.Show("La sintaxis de double es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de double es correcta", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^if").IsMatch(x):
                                #region if
                                if (Regex.IsMatch(sentencias[i], @"^if\s\(\s(([a-zA-Z_]+)\s(==|<|<=|>|>=|!=)\s([a-zA-Z_" + "\""+ @"]+)\s\))$", RegexOptions.IgnoreCase))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("if");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    MessageBox.Show("Sintaxis de if correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("if");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("if");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    MessageBox.Show("La sintaxis de if es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de if es correcta", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^else").IsMatch(x):
                                #region else
                                if (Regex.IsMatch(sentencias[i], @"^else$", RegexOptions.IgnoreCase))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("else");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    MessageBox.Show("Sintaxis de else correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("else");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("else");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    MessageBox.Show("La sintaxis de else es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de else es correcta", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^({|})").IsMatch(x):
                                
                                break;
                            default:
                                frm.txtcodigo.SelectionStart = frm.txtcodigo.Find(sentencias[i]);
                                frm.txtcodigo.SelectionColor = Color.Red;
                                System.Windows.Forms.MessageBox.Show("No se reconoce la sintaxis");
                                md_errores md = new md_errores(c, i + 1, "Sintaxis desconocida", "Verifique la linea, no se reconoce la sintaxis ingresada", "Sucede cuando la sintaxis no es reconocida por el analizador o no existe en el lenguaje");
                                me.nuevoerror(md);
                                errores++;
                                break;
                        }

                    }

                }
                #endregion
            }
            else if(l == "HTML")
            {
                #region HTML
                for (int i = 0; i < sentencias.Length; i++)
                {
                    c += sentencias.Length;
                    if (sentencias[i] != null)
                    {
                        string x = sentencias[i];

                        switch (true)
                        {
                            case bool _ when new Regex(@"^<!DOCTYPE").IsMatch(x):
                                #region <!DOCTYPE
                                if (Regex.IsMatch(sentencias[i], @"^<!DOCTYPE html>$"))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<!DOCTYPE html>");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    System.Windows.Forms.MessageBox.Show("Sintaxis de <!DOCTYPE html> correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<!DOCTYPE");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<!DOCTYPE html>");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    System.Windows.Forms.MessageBox.Show("La sintaxis de <!DOCTYPE html> es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de <!DOCTYPE html> ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^<html>").IsMatch(x):
                                #region <html>
                                if (Regex.IsMatch(sentencias[i], @"^<html>$"))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<html>");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    System.Windows.Forms.MessageBox.Show("Sintaxis de <html> correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<html>");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<html>");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    System.Windows.Forms.MessageBox.Show("La sintaxis de <html> es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de <html> ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^</").IsMatch(x):
                                #region </
                                if (Regex.IsMatch(sentencias[i], @"^</"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"(^</head>$)|(^</body>$)|(^</form>$)|(^</select>$)|(^</html>$)"))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find(sentencias[i]);
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        System.Windows.Forms.MessageBox.Show("Sintaxis de "+ sentencias[i] + " html> correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find(sentencias[i]);
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find(sentencias[i]);
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de "+sentencias[i]+" es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de "+sentencias[i], "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }

                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^<head>").IsMatch(x):
                                #region <head>
                                if (Regex.IsMatch(sentencias[i], @"^<head>$"))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<head>");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    System.Windows.Forms.MessageBox.Show("Sintaxis de <head> correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<head>");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<head>");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    System.Windows.Forms.MessageBox.Show("La sintaxis de <head> es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de <head> ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^<body>").IsMatch(x):
                                #region <body>
                                if (Regex.IsMatch(sentencias[i], @"^<body>$"))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<body>");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    System.Windows.Forms.MessageBox.Show("Sintaxis de <body> correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<body>");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<body>");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    System.Windows.Forms.MessageBox.Show("La sintaxis de <body> es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de <body> ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^<form>").IsMatch(x):
                                #region <form>
                                if (Regex.IsMatch(sentencias[i], @"^<form>$"))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<form>");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    System.Windows.Forms.MessageBox.Show("Sintaxis de <form> correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<form>");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<form>");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    System.Windows.Forms.MessageBox.Show("La sintaxis de <form> es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de <form> ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^<title>").IsMatch(x):
                                #region <title>
                                if (Regex.IsMatch(sentencias[i], @"^<title>\s([a-zA-Z\s*]+)\s</title>$"))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<title>");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("</title>");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    MessageBox.Show("La sintaxis de <title> es correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<title>");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("</title>");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<title>");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    System.Windows.Forms.MessageBox.Show("La sintaxis de <title> es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de <title> ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^<strong>").IsMatch(x):
                                #region <strong>
                                if (Regex.IsMatch(sentencias[i], @"^<strong>\s(.+)\s</strong>$"))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<strong>");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("</strong>");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    MessageBox.Show("La sintaxis de <strong> es correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<strong>");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("</strong>");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<strong>");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    System.Windows.Forms.MessageBox.Show("La sintaxis de <strong> es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de <strong> ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^<em>").IsMatch(x):
                                #region <em>
                                if (Regex.IsMatch(sentencias[i], @"^<em>\s(.+)\s</em>$"))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<em>");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("</em>");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    MessageBox.Show("La sintaxis de <em> es correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<em>");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("</em>");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<em>");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    System.Windows.Forms.MessageBox.Show("La sintaxis de <em> es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de <em> ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion

                            default:
                                frm.txtcodigo.SelectionStart = frm.txtcodigo.Find(sentencias[i]);
                                frm.txtcodigo.SelectionColor = Color.Red;
                                System.Windows.Forms.MessageBox.Show("No se reconoce la sintaxis");
                                md_errores md = new md_errores(c, i + 1, "Sintaxis desconocida", "Verifique la linea, no se reconoce la sintaxis ingresada", "Sucede cuando la sintaxis no es reconocida por el analizador o no existe en el lenguaje");
                                me.nuevoerror(md);
                                errores++;
                                break;
                        }

                    }

                }
                #endregion
            }
            else if (l == "JavaScript")
            {
                #region JavaScript
                for (int i = 0; i < sentencias.Length; i++)
                {
                    c += sentencias.Length;
                    if (sentencias[i] != null)
                    {
                        string x = sentencias[i];

                        switch (true)
                        {
                            case bool _ when new Regex(@"^public").IsMatch(x):
                                #region public
                                if (Regex.IsMatch(sentencias[i], @"^public\s(((int)|(string)\s([a-zA-Z_](\w+)?)\s\;)|(int\s([a-zA-Z_](\w+)?)\s\=\s\w+\s\;)|(void\s([a-zA-Z_](\w+)?)\s\(\s\)))"))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("public");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    System.Windows.Forms.MessageBox.Show("Sintaxis de public correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("public");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("public");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    System.Windows.Forms.MessageBox.Show("La sintaxis de public es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de public es correcta", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^console").IsMatch(x):
                                #region console
                                if (Regex.IsMatch(sentencias[i], @"^console\s\.\slog\s\(.+\)$"))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("console");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    System.Windows.Forms.MessageBox.Show("Sintaxis de console correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("console");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("console");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    System.Windows.Forms.MessageBox.Show("La sintaxis de console es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de console ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^int").IsMatch(x):
                                #region int
                                if (Regex.IsMatch(sentencias[i], @"^int"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^int\s((main\s\(\s\))|(([a-zA-Z_])(\w+)?\s(=)\s(\w+)\s\;))$", RegexOptions.IgnoreCase))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("int");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("Sintaxis de int correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("int");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find(sentencias[i]);
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de " + sentencias[i] + " es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de " + sentencias[i], "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }

                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^string").IsMatch(x):
                                #region string
                                if (Regex.IsMatch(sentencias[i], @"^string\s((([a-zA-Z_])(\w+)?\s(=)\s(\w+"+"\""+@")\s\;))$", RegexOptions.IgnoreCase))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("string");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    MessageBox.Show("Sintaxis de string correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("string");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("string");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    System.Windows.Forms.MessageBox.Show("La sintaxis de string es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de string ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^<").IsMatch(x):
                                #region <script>
                                if (Regex.IsMatch(sentencias[i], @"^<script>$", RegexOptions.IgnoreCase))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find(sentencias[i]);
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    MessageBox.Show("La sintaxis de script es correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find(sentencias[i]);
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("<script>");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    System.Windows.Forms.MessageBox.Show("La sintaxis de <script> es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de <script> ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^function").IsMatch(x):
                                #region function
                                if (Regex.IsMatch(sentencias[i], @"^function\s(\w+)\s\(\s\)\s\{.+\}$", RegexOptions.IgnoreCase))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("function");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    MessageBox.Show("La sintaxis de function es correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("function");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("function");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    System.Windows.Forms.MessageBox.Show("La sintaxis de function es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de function ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^if").IsMatch(x):
                                #region if
                                if (Regex.IsMatch(sentencias[i], @"^if\s\(\s(([a-zA-Z\.\s]+)\s(==|!=|<=|>=)\s([a-zA-Z0-9\.\s" + "\"" + @"]+)\s(\))(\s(.+)\s(\;)))$", RegexOptions.IgnoreCase))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("if");
                                    frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                    MessageBox.Show("La sintaxis de if es correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("if");
                                    frm.txtcodigo.SelectionColor = Color.Black;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("if");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    System.Windows.Forms.MessageBox.Show("La sintaxis de if es incorrecta");
                                    md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de if> ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                    me.nuevoerror(md2);
                                    errores++;
                                }
                                break;
                            #endregion

                            default:
                                frm.txtcodigo.SelectionStart = frm.txtcodigo.Find(sentencias[i]);
                                frm.txtcodigo.SelectionColor = Color.Red;
                                System.Windows.Forms.MessageBox.Show("No se reconoce la sintaxis");
                                md_errores md = new md_errores(c, i + 1, "Sintaxis desconocida", "Verifique la linea, no se reconoce la sintaxis ingresada", "Sucede cuando la sintaxis no es reconocida por el analizador o no existe en el lenguaje");
                                me.nuevoerror(md);
                                errores++;
                                break;
                        }

                    }

                }
                #endregion
            }
            else if (l == "Pascal")
            {
                #region Pascal
                for (int i = 0; i < sentencias.Length; i++)
                {
                    c += sentencias.Length;
                    if (sentencias[i] != null)
                    {
                        string x = sentencias[i];

                        switch (true)
                        {
                            case bool _ when new Regex(@"^if").IsMatch(x):
                                #region if
                                if (Regex.IsMatch(sentencias[i], @"(^if)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^if\s\w+\s(=|<|>|<=|>=|<>)\s\w+\sthen$", RegexOptions.IgnoreCase))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("if");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("La sintaxis de if es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("if");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("if");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de if es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de if ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^readln").IsMatch(x):
                                #region readln
                                if (Regex.IsMatch(sentencias[i], @"(^readln)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^readln\s\(\s.+\s\)\s\;$", RegexOptions.IgnoreCase))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("readln");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("La sintaxis de readln es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("readln");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("readln");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de readln es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de readln ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^program").IsMatch(x):
                                #region program
                                if (Regex.IsMatch(sentencias[i], @"(^program)"))
                                {

                                    if (Regex.IsMatch(sentencias[i], @"^program\s(\w)+\s\;$", RegexOptions.IgnoreCase))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("program");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("La sintaxis de program es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("program");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("program");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de program es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de program ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^writeln").IsMatch(x):
                                #region writeln
                                if (Regex.IsMatch(sentencias[i], @"(^writeln)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^((writeln))\s\(\s'.+'\s\)\s\;$", RegexOptions.IgnoreCase))
                                    {

                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("writeln");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("La sintaxis de writeln es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("writeln");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("writeln");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de writeln es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de writeln ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^write").IsMatch(x):
                                #region write
                                if (Regex.IsMatch(sentencias[i], @"(^write)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^((write))\s\(\s'.+'\s\)\s\;$", RegexOptions.IgnoreCase))
                                    {

                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("write");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("La sintaxis de write es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("write");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("write");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de write es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de write ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^else").IsMatch(x):
                                #region else
                                if (Regex.IsMatch(sentencias[i], @"(^else)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^else((\sif\s)?((\(\s)+)?((\w+\s)+)?(=|<|>|<=|>=|<>)\s?((\w+\s)+)?((\)\s)+)?(then))?$", RegexOptions.IgnoreCase))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("else");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("La sintaxis de else es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("else");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("else");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de else es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de else ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^begin").IsMatch(x):
                                #region begin
                                if (Regex.IsMatch(sentencias[i], @"(^begin)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^begin$", RegexOptions.IgnoreCase))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find(sentencias[i]);
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("Sintaxis de begin es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find(sentencias[i]);
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("begin");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de begin es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de begin ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^end").IsMatch(x):
                                #region end
                                if (Regex.IsMatch(sentencias[i], @"(^end)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^end$", RegexOptions.IgnoreCase))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find(sentencias[i]);
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("Se finalizo");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find(sentencias[i]);
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("end");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de end es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de end ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^var").IsMatch(x):
                                #region var
                                if (Regex.IsMatch(sentencias[i], @"(^var)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^var\s(\w+)\s(\:)\s(integer|string)\s(\;)$", RegexOptions.IgnoreCase))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("var");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("La sintaxis de var es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("var");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("var");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de var es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de var ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion

                            default:
                                frm.txtcodigo.SelectionStart = frm.txtcodigo.Find(sentencias[i]);
                                frm.txtcodigo.SelectionColor = Color.Red;
                                System.Windows.Forms.MessageBox.Show("No se reconoce la sintaxis");
                                md_errores md = new md_errores(c, i + 1, "Sintaxis desconocida", "Verifique la linea, no se reconoce la sintaxis ingresada", "Sucede cuando la sintaxis no es reconocida por el analizador o no existe en el lenguaje");
                                me.nuevoerror(md);
                                errores++;
                                break;
                        }

                    }

                }
                #endregion
            }
            else if (l == "PL SQL")
            {
                #region PL SQL
                for (int i = 0; i < sentencias.Length; i++)
                {
                    c += sentencias.Length;
                    if (sentencias[i] != null)
                    {
                        string x = sentencias[i];

                        switch (true)
                        {
                            case bool _ when new Regex(@"^select").IsMatch(x):
                                #region select
                                if (Regex.IsMatch(sentencias[i], @"(^select)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^select\s((\*)|(((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+)))\s((from)\s(((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+))\s+((where)\s(((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+))\s(=|<>|<|>|<=|>=)\s(((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+)))?)$"))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("select");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("La sintaxis de select es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("select");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("select");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de select es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de select ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^alter").IsMatch(x):
                                #region alter
                                if (Regex.IsMatch(sentencias[i], @"(^alter)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^alter\s(table|data_base|procedure|schedule)\s([a-zA-Z]+\.[a-zA-Z]+\.[a-zA-Z]+)|([a-zA-Z]+\.[a-zA-Z]+)|([a-zA-Z]+)$"))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("alter");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("La sintaxis de alter es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("alter");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("alter");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de alter es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de alter ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^create").IsMatch(x):
                                #region create
                                if (Regex.IsMatch(sentencias[i], @"(^create)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^create\s(table|data_base|procedure|schedule)\s([a-zA-Z]+\.[a-zA-Z]+\.[a-zA-Z]+)|([a-zA-Z]+\.[a-zA-Z]+)|([a-zA-Z]+)$"))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("create");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("La sintaxis de create es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("create");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("create");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de create es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de create ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^insert").IsMatch(x):
                                #region insert
                                if (Regex.IsMatch(sentencias[i], @"(^insert)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^insert\sinto\s\w+(\s((\(\s((\w+)|(\w+\s\,\s\w+)*)\s\))\svalues\s((\(\s((\w+)|(\w+\s\,\s\w+)*)\s\)))))?$"))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("insert");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("la sintaxis de insert es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("insert");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("insert");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de insert es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de insert ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^update").IsMatch(x):
                                #region update
                                if (Regex.IsMatch(sentencias[i], @"(^update)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^update\s((((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+))\s(set)\s((((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+)))\s(=)\s((((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+)))\s(where)\s((((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+)))\s(=|<>|<|>|<=|>0)\s((((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+))))$"))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("update");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("La sintaxis de update es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("update");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("update");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de update es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de update ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^delete").IsMatch(x):
                                #region delete
                                if (Regex.IsMatch(sentencias[i], @"(^delete)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^delete\s((from)\s(((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+))\s+((where)\s(((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+))\s(=|<>|<|>|<=|>=)\s(((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+)))?)$"))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("delete");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("La sintaxis de delete es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("delete");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("delete");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de delete es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de delete ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^declare").IsMatch(x):
                                #region declare
                                if (Regex.IsMatch(sentencias[i], @"(^declare)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^declare\s(\@(\w)+)\s(as)\s(int|double|string)$"))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("declare");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("La sintaxis de declare es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("declare");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("declare");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de declare es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de declare ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            default:
                                frm.txtcodigo.SelectionStart = frm.txtcodigo.Find(sentencias[i]);
                                frm.txtcodigo.SelectionColor = Color.Red;
                                System.Windows.Forms.MessageBox.Show("No se reconoce la sintaxis");
                                md_errores md = new md_errores(c, i + 1, "Sintaxis desconocida", "Verifique la linea, no se reconoce la sintaxis ingresada", "Sucede cuando la sintaxis no es reconocida por el analizador o no existe en el lenguaje");
                                me.nuevoerror(md);
                                errores++;
                                break;
                        }

                    }

                }
                #endregion
            }
            else if (l == "T-SQL")
            {
                #region T-SQL
                for (int i = 0; i < sentencias.Length; i++)
                {
                    c += sentencias.Length;
                    if (sentencias[i] != null)
                    {
                        string x = sentencias[i];

                        switch (true)
                        {
                            case bool _ when new Regex(@"^select").IsMatch(x):
                                #region select
                                if (Regex.IsMatch(sentencias[i], @"(^select)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^select\s((\*)|(((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+)))\s((from)\s(((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+))\s+((where)\s(((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+))\s(=|<>|<|>|<=|>=)\s(((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+)))?)$"))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("select");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("La sintaxis de select es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("select");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("select");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de select es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de select ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^alter").IsMatch(x):
                                #region alter
                                if (Regex.IsMatch(sentencias[i], @"(^alter)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^alter\s(table|database|proc|procedure|schedule)\s([a-zA-Z]+\.[a-zA-Z]+\.[a-zA-Z]+)|([a-zA-Z]+\.[a-zA-Z]+)|([a-zA-Z]+)$"))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("alter");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("La sintaxis de alter es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("alter");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("alter");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de alter es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de alter ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^create").IsMatch(x):
                                #region create
                                if (Regex.IsMatch(sentencias[i], @"(^create)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^create\s(table|database|proc|procedure|schedule)\s([a-zA-Z]+\.[a-zA-Z]+\.[a-zA-Z]+)|([a-zA-Z]+\.[a-zA-Z]+)|([a-zA-Z]+)$"))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("create");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("La sintaxis de create es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("create");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("create");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de create es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de create ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^insert").IsMatch(x):
                                #region insert
                                if (Regex.IsMatch(sentencias[i], @"(^insert)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^insert\sinto\s\w+(\s((\(\s((\w+)|(\w+\s\,\s\w+)*)\s\))\svalues\s((\(\s((\w+)|(\w+\s\,\s\w+)*)\s\)))))?$"))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("insert");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("la sintaxis de insert es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("insert");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("insert");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de insert es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de insert ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^update").IsMatch(x):
                                #region update
                                if (Regex.IsMatch(sentencias[i], @"(^update)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^update\s((((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+))\s(set)\s((((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+)))\s(=)\s((((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+)))\s(where)\s((((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+)))\s(=|<>|<|>|<=|>0)\s((((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+))))$"))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("update");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("La sintaxis de update es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("update");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("update");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de update es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de update ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^delete").IsMatch(x):
                                #region delete
                                if (Regex.IsMatch(sentencias[i], @"(^delete)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^delete\s((from)\s(((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+))\s+((where)\s(((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+))\s(=|<>|<|>|<=|>=)\s(((\w+)\.(\w+)\.(\w+))|((\w+)\.(\w+))|(\w+)))?)$"))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("delete");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("La sintaxis de delete es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("delete");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("delete");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de delete es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de delete ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            case bool _ when new Regex(@"^declare").IsMatch(x):
                                #region declare
                                if (Regex.IsMatch(sentencias[i], @"(^declare)"))
                                {
                                    if (Regex.IsMatch(sentencias[i], @"^declare\s(\@(\w)+)\s(as)\s(int|double|nvarchar|varchar)$"))
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("declare");
                                        frm.txtcodigo.SelectionColor = Color.DodgerBlue;
                                        MessageBox.Show("La sintaxis de declare es correcta");
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("declare");
                                        frm.txtcodigo.SelectionColor = Color.Black;
                                    }
                                    else
                                    {
                                        frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("declare");
                                        frm.txtcodigo.SelectionColor = Color.Red;
                                        System.Windows.Forms.MessageBox.Show("La sintaxis de declare es incorrecta");
                                        md_errores md2 = new md_errores(c, i + 1, "Sintactico", "Verifique si la sintaxis de declare ", "Sucede cuando la sintaxis es incorrecta o desconocida");
                                        me.nuevoerror(md2);
                                        errores++;
                                    }
                                }
                                break;
                            #endregion
                            default:
                                frm.txtcodigo.SelectionStart = frm.txtcodigo.Find(sentencias[i]);
                                frm.txtcodigo.SelectionColor = Color.Red;
                                System.Windows.Forms.MessageBox.Show("No se reconoce la sintaxis");
                                md_errores md = new md_errores(c, i + 1, "Sintaxis desconocida", "Verifique la linea, no se reconoce la sintaxis ingresada", "Sucede cuando la sintaxis no es reconocida por el analizador o no existe en el lenguaje");
                                me.nuevoerror(md);
                                errores++;
                                break;
                        }

                    }

                }
                #endregion
            }

            return errores;
        }
        public void puerta(principal form)
        {
            this.frm = form;
        }
        
    }
}
