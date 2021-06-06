using Mini_Compilador.Clases.An_Lexico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Compilador.Clases.An_Sintactico
{
   public class uniendo
    {
        int total_lineas = 0;
        List<md_simbolos> tabla;
        public string[] uniendo_lineas(string l)
        {
            total_lineas = AnalizadorLexico.numero_de_lineas;
            tabla = Tabla_Simbolos.Tabla_simbolos;
            string sentencia = null;
            string[] sentencias = new string[total_lineas];
            int n = 0;
            string tipov = "";
            if(l == "C++")
            {
                #region c++
                for (int i = 0; i < total_lineas; i++) //une los token de cada linea
                {
                    foreach (var token in tabla)
                    {
                        if (token.NumLinea == i + 1 && token != null)
                        {
                            if (n == 0 && Regex.IsMatch(token.valor, @"(public|private|class|else|catch|cin|cout|int|double|const|return|main|#include|new|if)$"))
                            {
                                //token.tipo = token.valor;
                                tipov = token.valor;
                            }


                            if (n != 0)
                            {
                                sentencia = sentencia + " " + token.valor.ToString();
                                //token.tipo = tipov;
                            }
                            else
                            {
                                sentencia += token.valor.ToString();
                                n = 1;
                            }

                        }
                    }
                    
                    sentencias[i] = sentencia;
                    sentencia = null;
                    n = 0;
                    tipov = "";
                }
                #endregion
            }
            else if(l == "HTML")
            {
                #region HTML
                for (int i = 0; i < total_lineas; i++) //une los token de cada linea
                {
                    foreach (var token in tabla)
                    {
                        if (token.NumLinea == i + 1 && token != null)
                        {
                            if (n == 0 && Regex.IsMatch(token.valor, @"(<!DOCTYPE html>|<html>|<head>|<body>|<title>|<p>|<b>|<em>|<strong>|<form>|<form>|<select>)$"))
                            {
                                //token.tipo = token.valor;
                                tipov = token.valor;
                            }


                            if (n != 0)
                            {
                                sentencia = sentencia + " " + token.valor.ToString();
                                //token.tipo = tipov;
                            }
                            else
                            {
                                sentencia += token.valor.ToString();
                                n = 1;
                            }

                        }
                    }

                    sentencias[i] = sentencia;
                    sentencia = null;
                    n = 0;
                    tipov = "";
                }
                #endregion
            }
            else if (l == "JavaScript")
            {
                #region JavaScript
                for (int i = 0; i < total_lineas; i++) //une los token de cada linea
                {
                    foreach (var token in tabla)
                    {
                        if (token.NumLinea == i + 1 && token != null)
                        {
                            if (n == 0 && Regex.IsMatch(token.valor, @"(public|private|log|default|console|class|delete|catch|int|double|const|return|string|var|let|interface|void|final|this|package|<script>|function|if)$"))
                            {
                               // token.tipo = token.valor;
                                tipov = token.valor;
                            }


                            if (n != 0)
                            {
                                sentencia = sentencia + " " + token.valor.ToString();
                               // token.tipo = tipov;
                            }
                            else
                            {
                                sentencia += token.valor.ToString();
                                n = 1;
                            }

                        }
                    }

                    sentencias[i] = sentencia;
                    sentencia = null;
                    n = 0;
                    tipov = "";
                }
                #endregion 
            }
            else if (l == "Pascal")
            {
                #region Pascal
                for (int i = 0; i < total_lineas; i++) //une los token de cada linea
                {
                    foreach (var token in tabla)
                    {
                        if (token.NumLinea == i + 1 && token != null)
                        {
                            if (n == 0 && Regex.IsMatch(token.valor, @"(program|label|external|object|integer|private|begin|else|if|set|const|string|var|interface|with)$"))
                            {
                                // token.tipo = token.valor;
                                tipov = token.valor;
                            }


                            if (n != 0)
                            {
                                sentencia = sentencia + " " + token.valor.ToString();
                                // token.tipo = tipov;
                            }
                            else
                            {
                                sentencia += token.valor.ToString();
                                n = 1;
                            }

                        }
                    }

                    sentencias[i] = sentencia;
                    sentencia = null;
                    n = 0;
                    tipov = "";
                }
                #endregion 
            }
            else if (l == "PL SQL")
            {
                #region PL SQL
                for (int i = 0; i < total_lineas; i++) //une los token de cada linea
                {
                    foreach (var token in tabla)
                    {
                        if (token.NumLinea == i + 1 && token != null)
                        {
                            if (n == 0 && Regex.IsMatch(token.valor, @"(from|alter|into|group|all|delete|begin|declare|on|if|else|select|insert|update|values|with|table|create|as|procedure|set|null|data_base|schedule|int|double|return|end|string)$"))
                            {
                                // token.tipo = token.valor;
                                tipov = token.valor;
                            }


                            if (n != 0)
                            {
                                sentencia = sentencia + " " + token.valor.ToString();
                                // token.tipo = tipov;
                            }
                            else
                            {
                                sentencia += token.valor.ToString();
                                n = 1;
                            }

                        }
                    }

                    sentencias[i] = sentencia;
                    sentencia = null;
                    n = 0;
                    tipov = "";
                }
                #endregion 
            }
            else if (l == "T-SQL")
            {
                #region PL SQL
                for (int i = 0; i < total_lineas; i++) //une los token de cada linea
                {
                    foreach (var token in tabla)
                    {
                        if (token.NumLinea == i + 1 && token != null)
                        {
                            if (n == 0 && Regex.IsMatch(token.valor, @"(alter|into|group|all|delete|begin|declare|on|if|else|select|insert|update|values|with|table|create|as|procedure|set|null|database|inner|int|double|return|end|string|from|restore|proc)$"))
                            {
                                // token.tipo = token.valor;
                                tipov = token.valor;
                            }


                            if (n != 0)
                            {
                                sentencia = sentencia + " " + token.valor.ToString();
                                // token.tipo = tipov;
                            }
                            else
                            {
                                sentencia += token.valor.ToString();
                                n = 1;
                            }

                        }
                    }

                    sentencias[i] = sentencia;
                    sentencia = null;
                    n = 0;
                    tipov = "";
                }
                #endregion 
            }
            else
            {
                MessageBox.Show("Lenguaje no reconocido");
            }
            

            return sentencias;
        }

    }
}
