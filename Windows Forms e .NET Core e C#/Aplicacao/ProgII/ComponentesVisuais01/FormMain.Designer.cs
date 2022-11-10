namespace ComponentesVisuais01
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSalvarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnFechar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnColar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripComboBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(700, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAbrir,
            this.mnSalvar,
            this.mnSalvarComo,
            this.toolStripSeparator1,
            this.mnFechar});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 23);
            this.toolStripMenuItem1.Text = "&Arquivo";
            // 
            // mnAbrir
            // 
            this.mnAbrir.Name = "mnAbrir";
            this.mnAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnAbrir.Size = new System.Drawing.Size(180, 22);
            this.mnAbrir.Text = "&Abrir";
            // 
            // mnSalvar
            // 
            this.mnSalvar.Name = "mnSalvar";
            this.mnSalvar.Size = new System.Drawing.Size(180, 22);
            this.mnSalvar.Text = "&Salvar";
            this.mnSalvar.Click += new System.EventHandler(this.mnSalvar_Click);
            // 
            // mnSalvarComo
            // 
            this.mnSalvarComo.Name = "mnSalvarComo";
            this.mnSalvarComo.Size = new System.Drawing.Size(180, 22);
            this.mnSalvarComo.Text = "Salvar &Como";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnFechar
            // 
            this.mnFechar.Name = "mnFechar";
            this.mnFechar.Size = new System.Drawing.Size(180, 22);
            this.mnFechar.Text = "&Fechar";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCopiar,
            this.mnColar});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(49, 23);
            this.toolStripMenuItem2.Text = "&Editar";
            // 
            // mnCopiar
            // 
            this.mnCopiar.Name = "mnCopiar";
            this.mnCopiar.Size = new System.Drawing.Size(109, 22);
            this.mnCopiar.Text = "&Copiar";
            // 
            // mnColar
            // 
            this.mnColar.Name = "mnColar";
            this.mnColar.Size = new System.Drawing.Size(109, 22);
            this.mnColar.Text = "Co&lar";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAjuda,
            this.toolStripSeparator2,
            this.mnSobre});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(50, 23);
            this.toolStripMenuItem3.Text = "Aj&uda";
            // 
            // mnAjuda
            // 
            this.mnAjuda.Name = "mnAjuda";
            this.mnAjuda.Size = new System.Drawing.Size(177, 22);
            this.mnAjuda.Text = "Conteúdo da Aj&uda";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(174, 6);
            // 
            // mnSobre
            // 
            this.mnSobre.Name = "mnSobre";
            this.mnSobre.Size = new System.Drawing.Size(177, 22);
            this.mnSobre.Text = "&Sobre";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Opção 1",
            "Opção 2",
            "Opção 3"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Componentes Visuais";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem mnAbrir;
        private ToolStripMenuItem mnSalvar;
        private ToolStripMenuItem mnSalvarComo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnFechar;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem mnCopiar;
        private ToolStripMenuItem mnColar;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem mnAjuda;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnSobre;
        private ToolStripComboBox toolStripComboBox1;
    }
}