namespace Agendamento_de_Consultas_Veterinárias {
    partial class mainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mS_Menu = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veterináriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sS_StatusBar = new System.Windows.Forms.StatusStrip();
            this.sS_StatusExecução = new System.Windows.Forms.ToolStripStatusLabel();
            this.mS_Menu.SuspendLayout();
            this.sS_StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mS_Menu
            // 
            this.mS_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.agendaToolStripMenuItem});
            this.mS_Menu.Location = new System.Drawing.Point(0, 0);
            this.mS_Menu.Name = "mS_Menu";
            this.mS_Menu.Size = new System.Drawing.Size(804, 24);
            this.mS_Menu.TabIndex = 1;
            this.mS_Menu.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animaisToolStripMenuItem,
            this.veterináriosToolStripMenuItem,
            this.agendamentosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // animaisToolStripMenuItem
            // 
            this.animaisToolStripMenuItem.Name = "animaisToolStripMenuItem";
            this.animaisToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.animaisToolStripMenuItem.Text = "Animais";
            this.animaisToolStripMenuItem.Click += new System.EventHandler(this.animaisToolStripMenuItem_Click);
            // 
            // veterináriosToolStripMenuItem
            // 
            this.veterináriosToolStripMenuItem.Name = "veterináriosToolStripMenuItem";
            this.veterináriosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.veterináriosToolStripMenuItem.Text = "Veterinários";
            this.veterináriosToolStripMenuItem.Click += new System.EventHandler(this.veterináriosToolStripMenuItem_Click);
            // 
            // agendamentosToolStripMenuItem
            // 
            this.agendamentosToolStripMenuItem.Name = "agendamentosToolStripMenuItem";
            this.agendamentosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.agendamentosToolStripMenuItem.Text = "Agendamentos";
            this.agendamentosToolStripMenuItem.Click += new System.EventHandler(this.agendamentosToolStripMenuItem_Click);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.agendaToolStripMenuItem.Text = "Agenda";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // sS_StatusBar
            // 
            this.sS_StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sS_StatusExecução});
            this.sS_StatusBar.Location = new System.Drawing.Point(0, 383);
            this.sS_StatusBar.Name = "sS_StatusBar";
            this.sS_StatusBar.Size = new System.Drawing.Size(804, 22);
            this.sS_StatusBar.TabIndex = 2;
            this.sS_StatusBar.Text = "statusStrip1";
            // 
            // sS_StatusExecução
            // 
            this.sS_StatusExecução.Name = "sS_StatusExecução";
            this.sS_StatusExecução.Size = new System.Drawing.Size(0, 17);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Agendamento_de_Consultas_Veterinárias.Properties.Resources.logoMainForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(804, 405);
            this.Controls.Add(this.sS_StatusBar);
            this.Controls.Add(this.mS_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mS_Menu;
            this.Name = "mainForm";
            this.Text = "Agendamento de Consultas";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.mS_Menu.ResumeLayout(false);
            this.mS_Menu.PerformLayout();
            this.sS_StatusBar.ResumeLayout(false);
            this.sS_StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mS_Menu;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip sS_StatusBar;
        private System.Windows.Forms.ToolStripMenuItem animaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veterináriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel sS_StatusExecução;
    }
}

