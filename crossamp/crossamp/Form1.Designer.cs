namespace crossamp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trkB_Cancion = new System.Windows.Forms.TrackBar();
            this.pan_Botonera = new System.Windows.Forms.Panel();
            this.pan_InfoCancion = new System.Windows.Forms.Panel();
            this.pan_VistaArbol = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menS_Inicio = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.trkB_Cancion)).BeginInit();
            this.pan_InfoCancion.SuspendLayout();
            this.pan_VistaArbol.SuspendLayout();
            this.menS_Inicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // trkB_Cancion
            // 
            this.trkB_Cancion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trkB_Cancion.Location = new System.Drawing.Point(0, 55);
            this.trkB_Cancion.Name = "trkB_Cancion";
            this.trkB_Cancion.Size = new System.Drawing.Size(521, 45);
            this.trkB_Cancion.TabIndex = 0;
            // 
            // pan_Botonera
            // 
            this.pan_Botonera.Location = new System.Drawing.Point(0, 27);
            this.pan_Botonera.Name = "pan_Botonera";
            this.pan_Botonera.Size = new System.Drawing.Size(146, 100);
            this.pan_Botonera.TabIndex = 1;
            // 
            // pan_InfoCancion
            // 
            this.pan_InfoCancion.Controls.Add(this.trkB_Cancion);
            this.pan_InfoCancion.Location = new System.Drawing.Point(152, 27);
            this.pan_InfoCancion.Name = "pan_InfoCancion";
            this.pan_InfoCancion.Size = new System.Drawing.Size(521, 100);
            this.pan_InfoCancion.TabIndex = 2;
            // 
            // pan_VistaArbol
            // 
            this.pan_VistaArbol.Controls.Add(this.treeView1);
            this.pan_VistaArbol.Controls.Add(this.comboBox1);
            this.pan_VistaArbol.Location = new System.Drawing.Point(0, 133);
            this.pan_VistaArbol.Name = "pan_VistaArbol";
            this.pan_VistaArbol.Size = new System.Drawing.Size(335, 265);
            this.pan_VistaArbol.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(335, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 21);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(335, 244);
            this.treeView1.TabIndex = 1;
            // 
            // menS_Inicio
            // 
            this.menS_Inicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menS_Inicio.Location = new System.Drawing.Point(0, 0);
            this.menS_Inicio.Name = "menS_Inicio";
            this.menS_Inicio.Size = new System.Drawing.Size(685, 24);
            this.menS_Inicio.TabIndex = 0;
            this.menS_Inicio.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 401);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(685, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(685, 423);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menS_Inicio);
            this.Controls.Add(this.pan_VistaArbol);
            this.Controls.Add(this.pan_InfoCancion);
            this.Controls.Add(this.pan_Botonera);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "crossamp";
            ((System.ComponentModel.ISupportInitialize)(this.trkB_Cancion)).EndInit();
            this.pan_InfoCancion.ResumeLayout(false);
            this.pan_InfoCancion.PerformLayout();
            this.pan_VistaArbol.ResumeLayout(false);
            this.menS_Inicio.ResumeLayout(false);
            this.menS_Inicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trkB_Cancion;
        private System.Windows.Forms.Panel pan_Botonera;
        private System.Windows.Forms.Panel pan_InfoCancion;
        private System.Windows.Forms.Panel pan_VistaArbol;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menS_Inicio;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

