namespace Agendamento_de_Consultas_Veterinárias {
    partial class cadastrosAnimal {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrosAnimal));
            this.tB_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Race = new System.Windows.Forms.Label();
            this.tB_Raça = new System.Windows.Forms.TextBox();
            this.mTB_DataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lbl_DataNascimento = new System.Windows.Forms.Label();
            this.dGV_Animais = new System.Windows.Forms.DataGridView();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Animais)).BeginInit();
            this.SuspendLayout();
            // 
            // tB_Nome
            // 
            this.tB_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Nome.Location = new System.Drawing.Point(53, 12);
            this.tB_Nome.Name = "tB_Nome";
            this.tB_Nome.Size = new System.Drawing.Size(139, 20);
            this.tB_Nome.TabIndex = 0;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(12, 15);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Nome";
            // 
            // lbl_Race
            // 
            this.lbl_Race.AutoSize = true;
            this.lbl_Race.Location = new System.Drawing.Point(14, 41);
            this.lbl_Race.Name = "lbl_Race";
            this.lbl_Race.Size = new System.Drawing.Size(33, 13);
            this.lbl_Race.TabIndex = 2;
            this.lbl_Race.Text = "Raça";
            // 
            // tB_Raça
            // 
            this.tB_Raça.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Raça.Location = new System.Drawing.Point(53, 38);
            this.tB_Raça.Name = "tB_Raça";
            this.tB_Raça.Size = new System.Drawing.Size(139, 20);
            this.tB_Raça.TabIndex = 3;
            // 
            // mTB_DataNascimento
            // 
            this.mTB_DataNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mTB_DataNascimento.Location = new System.Drawing.Point(124, 64);
            this.mTB_DataNascimento.Mask = "00/00/0000";
            this.mTB_DataNascimento.Name = "mTB_DataNascimento";
            this.mTB_DataNascimento.Size = new System.Drawing.Size(68, 20);
            this.mTB_DataNascimento.TabIndex = 7;
            this.mTB_DataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_DataNascimento
            // 
            this.lbl_DataNascimento.AutoSize = true;
            this.lbl_DataNascimento.Location = new System.Drawing.Point(14, 67);
            this.lbl_DataNascimento.Name = "lbl_DataNascimento";
            this.lbl_DataNascimento.Size = new System.Drawing.Size(104, 13);
            this.lbl_DataNascimento.TabIndex = 8;
            this.lbl_DataNascimento.Text = "Data de Nascimento";
            // 
            // dGV_Animais
            // 
            this.dGV_Animais.AllowUserToAddRows = false;
            this.dGV_Animais.AllowUserToDeleteRows = false;
            this.dGV_Animais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Animais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Animais.Location = new System.Drawing.Point(12, 90);
            this.dGV_Animais.Name = "dGV_Animais";
            this.dGV_Animais.Size = new System.Drawing.Size(260, 131);
            this.dGV_Animais.TabIndex = 9;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cadastrar.Location = new System.Drawing.Point(197, 12);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 10;
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
            this.btn_Remover.TabIndex = 11;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // cadastrosAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 233);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.dGV_Animais);
            this.Controls.Add(this.lbl_DataNascimento);
            this.Controls.Add(this.mTB_DataNascimento);
            this.Controls.Add(this.tB_Raça);
            this.Controls.Add(this.lbl_Race);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tB_Nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 184);
            this.Name = "cadastrosAnimal";
            this.Text = "Cadastro e Lista de Animais";
            this.Activated += new System.EventHandler(this.cadastrosAnimal_Load);
            this.Load += new System.EventHandler(this.cadastrosAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Animais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_Nome;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Race;
        private System.Windows.Forms.TextBox tB_Raça;
        private System.Windows.Forms.MaskedTextBox mTB_DataNascimento;
        private System.Windows.Forms.Label lbl_DataNascimento;
        private System.Windows.Forms.DataGridView dGV_Animais;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_Remover;
    }
}