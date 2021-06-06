using Mini_Compilador.Clases;
using Mini_Compilador.Clases.An_Lexico;
using Mini_Compilador.Clases.An_Sintactico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Compilador
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
           
        }
        public static principal _puerta = new principal();
        AnalizadorSintactico asin = new AnalizadorSintactico();
        public string archivo, ruta_archivo;
        uniendo sent = new uniendo();

        AnalizadorLexico al = new AnalizadorLexico();
        string[] sentencias;
        public int errores = 0;

        Tabla_Simbolos ts = new Tabla_Simbolos();
        Manejo_errores me = new Manejo_errores();
        private void principal_Load(object sender, EventArgs e)
        {
            panelErrores.Visible = false;
            btnerrores.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelErrores.Visible = true;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            limpiar();
            an_lexico();
            uniendo();
            an_sintactico();
            evaluarerrores();
            resultados();
        }
        public void uniendo()
        {
            asin.puerta(this);
            sentencias = sent.uniendo_lineas(lblReconocer.Text);
        }
        public void an_sintactico()
        {
            asin.puerta(this);
            errores += asin.Analizador_Sintactico(sentencias, lblReconocer.Text);
        }
        public void an_lexico()
        {
            archivo = txtcodigo.Text;
            al.puerta(this);
            errores += al.aplicar_AnalizadorLexico(archivo);
            
        }
        public void evaluarerrores()
        {
            lblErrores.Text = errores.ToString();
            if (errores > 0)
            {
                btnerrores.Visible = true;
            }
            else
            {
                btnerrores.Visible = false;
            }
        }
        public void limpiar()
        {
            me.reinicialista();
            ts.limpiar();
            sentencias = null;
            errores = 0;
            lblReconocer.Text = "";
        }
        public void resultados()
        {
            dataerrores.DataSource = me.llamatablaE();
            tablasimbolos.DataSource = ts.versimbolos();
        }
    }
}
