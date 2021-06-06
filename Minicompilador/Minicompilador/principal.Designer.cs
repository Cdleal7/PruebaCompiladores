namespace Mini_Compilador
{
    partial class principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReconocer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblErrores = new System.Windows.Forms.Label();
            this.btnerrores = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PanelCodigo = new System.Windows.Forms.Panel();
            this.txtcodigo = new System.Windows.Forms.RichTextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelErrores = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.dataerrores = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panelsimbolos = new System.Windows.Forms.Panel();
            this.tablasimbolos = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.PanelBotones.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PanelCodigo.SuspendLayout();
            this.panelErrores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataerrores)).BeginInit();
            this.panelsimbolos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablasimbolos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBotones
            // 
            this.PanelBotones.Controls.Add(this.flowLayoutPanel1);
            this.PanelBotones.Controls.Add(this.panel5);
            this.PanelBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBotones.Location = new System.Drawing.Point(0, 0);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(695, 94);
            this.PanelBotones.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnRun);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.lblReconocer);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.lblErrores);
            this.flowLayoutPanel1.Controls.Add(this.btnerrores);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(741, 74);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Lime;
            this.btnRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(3, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(107, 59);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Ejecutar";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lenguaje:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReconocer
            // 
            this.lblReconocer.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblReconocer.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReconocer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblReconocer.Location = new System.Drawing.Point(246, 0);
            this.lblReconocer.Name = "lblReconocer";
            this.lblReconocer.Size = new System.Drawing.Size(214, 62);
            this.lblReconocer.TabIndex = 1;
            this.lblReconocer.Text = "Reconociendo...";
            this.lblReconocer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(466, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 62);
            this.label3.TabIndex = 1;
            this.label3.Text = "Errores: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrores
            // 
            this.lblErrores.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblErrores.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrores.ForeColor = System.Drawing.Color.Red;
            this.lblErrores.Location = new System.Drawing.Point(587, 0);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(35, 62);
            this.lblErrores.TabIndex = 1;
            this.lblErrores.Text = "0";
            this.lblErrores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnerrores
            // 
            this.btnerrores.BackColor = System.Drawing.Color.Red;
            this.btnerrores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnerrores.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnerrores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnerrores.Location = new System.Drawing.Point(628, 3);
            this.btnerrores.Name = "btnerrores";
            this.btnerrores.Size = new System.Drawing.Size(69, 65);
            this.btnerrores.TabIndex = 2;
            this.btnerrores.Text = "Ver °_°";
            this.btnerrores.UseVisualStyleBackColor = false;
            this.btnerrores.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(741, 20);
            this.panel5.TabIndex = 4;
            // 
            // PanelCodigo
            // 
            this.PanelCodigo.Controls.Add(this.txtcodigo);
            this.PanelCodigo.Controls.Add(this.panel14);
            this.PanelCodigo.Controls.Add(this.panel4);
            this.PanelCodigo.Controls.Add(this.panel3);
            this.PanelCodigo.Controls.Add(this.panel2);
            this.PanelCodigo.Controls.Add(this.panel1);
            this.PanelCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCodigo.Location = new System.Drawing.Point(0, 94);
            this.PanelCodigo.Name = "PanelCodigo";
            this.PanelCodigo.Size = new System.Drawing.Size(695, 193);
            this.PanelCodigo.TabIndex = 1;
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.White;
            this.txtcodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcodigo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.ForeColor = System.Drawing.Color.Black;
            this.txtcodigo.Location = new System.Drawing.Point(20, 20);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(655, 153);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.Text = "";
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(675, 20);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(20, 153);
            this.panel14.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(20, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(675, 20);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(20, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 20);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1045, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 229);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 193);
            this.panel1.TabIndex = 1;
            // 
            // panelErrores
            // 
            this.panelErrores.Controls.Add(this.panel15);
            this.panelErrores.Controls.Add(this.dataerrores);
            this.panelErrores.Controls.Add(this.panel8);
            this.panelErrores.Controls.Add(this.panel7);
            this.panelErrores.Controls.Add(this.panel6);
            this.panelErrores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelErrores.Location = new System.Drawing.Point(0, 287);
            this.panelErrores.Name = "panelErrores";
            this.panelErrores.Size = new System.Drawing.Size(695, 194);
            this.panelErrores.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(675, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(20, 174);
            this.panel15.TabIndex = 6;
            // 
            // dataerrores
            // 
            this.dataerrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataerrores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataerrores.Location = new System.Drawing.Point(20, 0);
            this.dataerrores.Name = "dataerrores";
            this.dataerrores.RowTemplate.ReadOnly = true;
            this.dataerrores.Size = new System.Drawing.Size(675, 174);
            this.dataerrores.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(20, 174);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(675, 20);
            this.panel8.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(1045, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 194);
            this.panel7.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(20, 194);
            this.panel6.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(513, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(20, 481);
            this.panel9.TabIndex = 2;
            // 
            // panelsimbolos
            // 
            this.panelsimbolos.Controls.Add(this.tablasimbolos);
            this.panelsimbolos.Controls.Add(this.panel12);
            this.panelsimbolos.Controls.Add(this.panel11);
            this.panelsimbolos.Controls.Add(this.panel9);
            this.panelsimbolos.Controls.Add(this.panel13);
            this.panelsimbolos.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelsimbolos.Location = new System.Drawing.Point(695, 0);
            this.panelsimbolos.Name = "panelsimbolos";
            this.panelsimbolos.Size = new System.Drawing.Size(533, 481);
            this.panelsimbolos.TabIndex = 3;
            // 
            // tablasimbolos
            // 
            this.tablasimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablasimbolos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablasimbolos.Location = new System.Drawing.Point(1, 20);
            this.tablasimbolos.Name = "tablasimbolos";
            this.tablasimbolos.ReadOnly = true;
            this.tablasimbolos.Size = new System.Drawing.Size(512, 441);
            this.tablasimbolos.TabIndex = 8;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(1, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(512, 20);
            this.panel12.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(1, 461);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(512, 20);
            this.panel11.TabIndex = 5;
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1, 481);
            this.panel13.TabIndex = 7;
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1228, 481);
            this.Controls.Add(this.PanelCodigo);
            this.Controls.Add(this.panelErrores);
            this.Controls.Add(this.PanelBotones);
            this.Controls.Add(this.panelsimbolos);
            this.Name = "principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minicompilador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.principal_Load);
            this.PanelBotones.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PanelCodigo.ResumeLayout(false);
            this.panelErrores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataerrores)).EndInit();
            this.panelsimbolos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablasimbolos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBotones;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Panel PanelCodigo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelErrores;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.RichTextBox txtcodigo;
        public System.Windows.Forms.DataGridView dataerrores;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panelsimbolos;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        public System.Windows.Forms.DataGridView tablasimbolos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.Button btnerrores;
        public System.Windows.Forms.Label lblReconocer;
    }
}

