namespace Agendamento_de_Consultas_Veterinárias {
    partial class cadastrosVeterinario {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrosVeterinario));
            this.tB_Nome = new System.Windows.Forms.TextBox();
            this.mTB_CPF = new System.Windows.Forms.MaskedTextBox();
            this.mTB_DataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.tB_Registro = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.lbl_DataNascimento = new System.Windows.Forms.Label();
            this.lbl_Registro = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.dGV_Veterinarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Veterinarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tB_Nome
            // 
            this.tB_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Nome.Location = new System.Drawing.Point(55, 12);
            this.tB_Nome.Name = "tB_Nome";
            this.tB_Nome.Size = new System.Drawing.Size(136, 20);
            this.tB_Nome.TabIndex = 0;
            // 
            // mTB_CPF
            // 
            this.mTB_CPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mTB_CPF.Location = new System.Drawing.Point(109, 38);
            this.mTB_CPF.Mask = "000.000.000-00";
            this.mTB_CPF.Name = "mTB_CPF";
            this.mTB_CPF.Size = new System.Drawing.Size(82, 20);
            this.mTB_CPF.TabIndex = 1;
            // 
            // mTB_DataNascimento
            // 
            this.mTB_DataNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mTB_DataNascimento.Location = new System.Drawing.Point(124, 64);
            this.mTB_DataNascimento.Mask = "00/00/0000";
            this.mTB_DataNascimento.Name = "mTB_DataNascimento";
            this.mTB_DataNascimento.Size = new System.Drawing.Size(67, 20);
            this.mTB_DataNascimento.TabIndex = 2;
            this.mTB_DataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // tB_Registro
            // 
            this.tB_Registro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Registro.Location = new System.Drawing.Point(66, 90);
            this.tB_Registro.Name = "tB_Registro";
            this.tB_Registro.Size = new System.Drawing.Size(125, 20);
            this.tB_Registro.TabIndex = 3;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(14, 15);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_Nome.TabIndex = 4;
            this.lbl_Nome.Text = "Nome";
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.Location = new System.Drawing.Point(14, 41);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(27, 13);
            this.lbl_CPF.TabIndex = 5;
            this.lbl_CPF.Text = "CPF";
            // 
            // lbl_DataNascimento
            // 
            this.lbl_DataNascimento.AutoSize = true;
            this.lbl_DataNascimento.Location = new System.Drawing.Point(14, 67);
            this.lbl_DataNascimento.Name = "lbl_DataNascimento";
            this.lbl_DataNascimento.Size = new System.Drawing.Size(104, 13);
            this.lbl_DataNascimento.TabIndex = 6;
            this.lbl_DataNascimento.Text = "Data de Nascimento";
            // 
            // lbl_Registro
            // 
            this.lbl_Registro.AutoSize = true;
            this.lbl_Registro.Location = new System.Drawing.Point(14, 93);
            this.lbl_Registro.Name = "lbl_Registro";
            this.lbl_Registro.Size = new System.Drawing.Size(46, 13);
            this.lbl_Registro.TabIndex = 7;
            this.lbl_Registro.Text = "Registro";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cadastrar.Location = new System.Drawing.Point(197, 12);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 8;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Remover.Location = new System.Drawing.Point(197, 41);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(75, 23);
            this.btn_Remover.TabIndex = 9;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // dGV_Veterinarios
            // 
            this.dGV_Veterinarios.AllowUserToAddRows = false;
            this.dGV_Veterinarios.AllowUserToDeleteRows = false;
            this.dGV_Veterinarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Veterinarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Veterinarios.Location = new System.Drawing.Point(12, 116);
            this.dGV_Veterinarios.Name = "dGV_Veterinarios";
            this.dGV_Veterinarios.Size = new System.Drawing.Size(260, 134);
            this.dGV_Veterinarios.TabIndex = 10;
            // 
            // cadastrosVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dGV_Veterinarios);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.lbl_Registro);
            this.Controls.Add(this.lbl_DataNascimento);
            this.Controls.Add(this.lbl_CPF);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.tB_Registro);
            this.Controls.Add(this.mTB_DataNascimento);
            this.Controls.Add(this.mTB_CPF);
            this.Controls.Add(this.tB_Nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastrosVeterinario";
            this.Text = "Cadastro e Lista de Veterinários";
            this.Activated += new System.EventHandler(this.cadastrosVeterinario_Load);
            this.Load += new System.EventHandler(this.cadastrosVeterinario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Veterinarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_Nome;
        private System.Windows.Forms.MaskedTextBox mTB_CPF;
        private System.Windows.Forms.MaskedTextBox mTB_DataNascimento;
        private System.Windows.Forms.TextBox tB_Registro;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.Label lbl_DataNascimento;
        private System.Windows.Forms.Label lbl_Registro;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.DataGridView dGV_Veterinarios;
    }
}