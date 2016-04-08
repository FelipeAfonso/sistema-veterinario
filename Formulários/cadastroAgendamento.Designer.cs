namespace Agendamento_de_Consultas_Veterinárias {
    partial class cadastroAgendamento {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroAgendamento));
            this.lB_Data = new System.Windows.Forms.Label();
            this.lB_Veterinario = new System.Windows.Forms.Label();
            this.lb_Animal = new System.Windows.Forms.Label();
            this.cB_Veterinario = new System.Windows.Forms.ComboBox();
            this.cB_Animal = new System.Windows.Forms.ComboBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.dGV_Agendamentos = new System.Windows.Forms.DataGridView();
            this.dTP_Data = new System.Windows.Forms.DateTimePicker();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.mTB_Hora = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Agendamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lB_Data
            // 
            this.lB_Data.AutoSize = true;
            this.lB_Data.Location = new System.Drawing.Point(46, 15);
            this.lB_Data.Name = "lB_Data";
            this.lB_Data.Size = new System.Drawing.Size(30, 13);
            this.lB_Data.TabIndex = 0;
            this.lB_Data.Text = "Data";
            // 
            // lB_Veterinario
            // 
            this.lB_Veterinario.AutoSize = true;
            this.lB_Veterinario.Location = new System.Drawing.Point(19, 67);
            this.lB_Veterinario.Name = "lB_Veterinario";
            this.lB_Veterinario.Size = new System.Drawing.Size(57, 13);
            this.lB_Veterinario.TabIndex = 1;
            this.lB_Veterinario.Text = "Veterinário";
            // 
            // lb_Animal
            // 
            this.lb_Animal.AutoSize = true;
            this.lb_Animal.Location = new System.Drawing.Point(38, 94);
            this.lb_Animal.Name = "lb_Animal";
            this.lb_Animal.Size = new System.Drawing.Size(38, 13);
            this.lb_Animal.TabIndex = 2;
            this.lb_Animal.Text = "Animal";
            // 
            // cB_Veterinario
            // 
            this.cB_Veterinario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cB_Veterinario.FormattingEnabled = true;
            this.cB_Veterinario.Location = new System.Drawing.Point(82, 64);
            this.cB_Veterinario.Name = "cB_Veterinario";
            this.cB_Veterinario.Size = new System.Drawing.Size(227, 21);
            this.cB_Veterinario.TabIndex = 4;
            // 
            // cB_Animal
            // 
            this.cB_Animal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cB_Animal.FormattingEnabled = true;
            this.cB_Animal.Location = new System.Drawing.Point(82, 91);
            this.cB_Animal.Name = "cB_Animal";
            this.cB_Animal.Size = new System.Drawing.Size(227, 21);
            this.cB_Animal.TabIndex = 5;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cadastrar.Location = new System.Drawing.Point(316, 12);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 6;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Remover.Location = new System.Drawing.Point(316, 41);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(75, 23);
            this.btn_Remover.TabIndex = 7;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // dGV_Agendamentos
            // 
            this.dGV_Agendamentos.AllowUserToAddRows = false;
            this.dGV_Agendamentos.AllowUserToDeleteRows = false;
            this.dGV_Agendamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Agendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Agendamentos.Location = new System.Drawing.Point(15, 118);
            this.dGV_Agendamentos.Name = "dGV_Agendamentos";
            this.dGV_Agendamentos.Size = new System.Drawing.Size(375, 103);
            this.dGV_Agendamentos.TabIndex = 8;
            this.dGV_Agendamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Agendamentos_CellClick);
            this.dGV_Agendamentos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Agendamentos_CellEndEdit);
            // 
            // dTP_Data
            // 
            this.dTP_Data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dTP_Data.Location = new System.Drawing.Point(82, 12);
            this.dTP_Data.Name = "dTP_Data";
            this.dTP_Data.Size = new System.Drawing.Size(227, 20);
            this.dTP_Data.TabIndex = 9;
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Location = new System.Drawing.Point(46, 41);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(30, 13);
            this.lbl_Hora.TabIndex = 10;
            this.lbl_Hora.Text = "Hora";
            // 
            // mTB_Hora
            // 
            this.mTB_Hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mTB_Hora.Location = new System.Drawing.Point(275, 38);
            this.mTB_Hora.Mask = "00:00";
            this.mTB_Hora.Name = "mTB_Hora";
            this.mTB_Hora.Size = new System.Drawing.Size(34, 20);
            this.mTB_Hora.TabIndex = 11;
            this.mTB_Hora.ValidatingType = typeof(System.DateTime);
            // 
            // cadastroAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 233);
            this.Controls.Add(this.mTB_Hora);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.dTP_Data);
            this.Controls.Add(this.dGV_Agendamentos);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.cB_Animal);
            this.Controls.Add(this.cB_Veterinario);
            this.Controls.Add(this.lb_Animal);
            this.Controls.Add(this.lB_Veterinario);
            this.Controls.Add(this.lB_Data);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(286, 177);
            this.Name = "cadastroAgendamento";
            this.Text = "Cadastro e Lista de Agendamentos";
            this.Activated += new System.EventHandler(this.cadastroAgendamento_Load);
            this.Load += new System.EventHandler(this.cadastroAgendamento_Load);
            this.Shown += new System.EventHandler(this.cadastroAgendamento_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Agendamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lB_Data;
        private System.Windows.Forms.Label lB_Veterinario;
        private System.Windows.Forms.Label lb_Animal;
        private System.Windows.Forms.ComboBox cB_Veterinario;
        private System.Windows.Forms.ComboBox cB_Animal;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.DataGridView dGV_Agendamentos;
        private System.Windows.Forms.DateTimePicker dTP_Data;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.MaskedTextBox mTB_Hora;
    }
}