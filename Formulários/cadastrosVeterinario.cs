using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agendamento_de_Consultas_Veterinárias {
    public partial class cadastrosVeterinario : Form {
        public cadastrosVeterinario(mainForm mF) {
            InitializeComponent();
            this.MdiParent = mF;
            this.dGV_Veterinarios.AutoGenerateColumns = true;
            this.dGV_Veterinarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.mTB_CPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        protected override void OnClosing(CancelEventArgs e) {
            this.Hide();
            e.Cancel = true;
        }

        private void cadastrosVeterinario_Load(object sender, EventArgs e) {
            try {
                mTB_CPF.Clear(); mTB_DataNascimento.Clear(); tB_Nome.Clear(); tB_Registro.Clear();
                BindingList<Veterinario> tempList = new BindingList<Veterinario>();
                foreach (Veterinario vet in Veterinario.listaVeterinarios) {
                    tempList.Add(new Veterinario(vet.Nome, vet.Registro, vet.Nascimento, vet.getMaskedCPF()));
                }
                dGV_Veterinarios.DataSource = tempList;
                dGV_Veterinarios.Columns["nome_cpf"].Visible = false;
                dGV_Veterinarios.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Erro ao carregar formulário", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Remover_Click(object sender, EventArgs e) {
            try {
                List<Veterinario> vetsRemocao = new List<Veterinario>();
                foreach (DataGridViewRow row in this.dGV_Veterinarios.SelectedRows) {
                    foreach (Veterinario vet in Veterinario.listaVeterinarios) {
                        if (dGV_Veterinarios.Rows[row.Index].Cells["CPF"].Value.ToString().Count() > 11) {
                            string cpfSemMascara = "";
                            foreach (char c in dGV_Veterinarios.Rows[row.Index].Cells["CPF"].Value.ToString()) {
                                if (char.IsDigit(c)) {
                                    cpfSemMascara += c;
                                }
                            }
                            if (vet.CPF == cpfSemMascara) {
                                vetsRemocao.Add(vet);
                            }
                        }
                    }
                }
                foreach (Veterinario vet in vetsRemocao) {
                    Veterinario.listaVeterinarios.Remove(vet);
                    vet.Delete();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Erro ao remover dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                this.cadastrosVeterinario_Load(sender, e);
            }
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e) {
            try {
                Veterinario temp = new Veterinario(mTB_CPF.Text, tB_Nome.Text, tB_Registro.Text, mTB_DataNascimento.Text);
                Veterinario.listaVeterinarios.Add(temp);
                temp.Create();
                MessageBox.Show("Veterinario cadastrado com sucesso", "Cadastro de Veterinarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Erro ao cadastrar dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                cadastrosVeterinario_Load(sender, e);
            }
        }

    }
}
