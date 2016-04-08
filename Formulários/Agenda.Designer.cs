namespace Agendamento_de_Consultas_Veterinárias {
    partial class Agenda {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.mC_Agenda = new System.Windows.Forms.MonthCalendar();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dGV_Consultas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Consultas)).BeginInit();
            this.SuspendLayout();
            // 
            // mC_Agenda
            // 
            this.mC_Agenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mC_Agenda.Location = new System.Drawing.Point(18, 18);
            this.mC_Agenda.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.mC_Agenda.Name = "mC_Agenda";
            this.mC_Agenda.TabIndex = 0;
            this.mC_Agenda.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mC_Agenda_DateSelected);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Location = new System.Drawing.Point(18, 192);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(75, 23);
            this.btn_Remover.TabIndex = 1;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(171, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dGV_Consultas
            // 
            this.dGV_Consultas.AllowUserToAddRows = false;
            this.dGV_Consultas.AllowUserToDeleteRows = false;
            this.dGV_Consultas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Consultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Consultas.Location = new System.Drawing.Point(18, 221);
            this.dGV_Consultas.Name = "dGV_Consultas";
            this.dGV_Consultas.Size = new System.Drawing.Size(227, 139);
            this.dGV_Consultas.TabIndex = 3;
            this.dGV_Consultas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Consultas_CellClick);
            this.dGV_Consultas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Consultas_CellEndEdit);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 372);
            this.Controls.Add(this.dGV_Consultas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.mC_Agenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(273, 298);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.Activated += new System.EventHandler(this.Agenda_Activated);
            this.Load += new System.EventHandler(this.Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Consultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mC_Agenda;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dGV_Consultas;
    }
}