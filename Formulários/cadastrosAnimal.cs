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
    public partial class cadastrosAnimal : Form {
        public cadastrosAnimal(mainForm mF) {
            InitializeComponent();
            this.MdiParent = mF;
            this.dGV_Animais.AutoGenerateColumns = true;
            this.dGV_Animais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        protected override void OnClosing(CancelEventArgs e) {
            this.Hide();
            e.Cancel = true;
        }

        private void cadastrosAnimal_Load(object sender, EventArgs e) {
            mTB_DataNascimento.Clear(); tB_Nome.Clear(); tB_Raça.Clear();
            dGV_Animais.DataSource = new BindingList<Animal>(Animal.listaAnimais);
            dGV_Animais.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dGV_Animais.Columns["nome_codigo"].Visible = false;
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e) {
            try {
                Animal temp = new Animal(tB_Nome.Text, tB_Raça.Text, mTB_DataNascimento.Text);
                Animal.listaAnimais.Add(temp);
                temp.Create();
                MessageBox.Show("Animal cadastrado com sucesso", "Cadastro de Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Erro ao cadastrar dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                cadastrosAnimal_Load(sender, e);
            }
        }

        private void btn_Remover_Click(object sender, EventArgs e) {
            try {
                List<Animal> animaisRemocao = new List<Animal>();
                foreach (DataGridViewRow row in this.dGV_Animais.SelectedRows) {
                    foreach (Animal animal in Animal.listaAnimais) {
                        if (animal.Codigo == dGV_Animais.Rows[row.Index].Cells[0].Value.ToString()) {
                            animaisRemocao.Add(animal);
                        }
                    }
                }
                foreach (Animal animal in animaisRemocao) {
                    Animal.listaAnimais.Remove(animal);
                    animal.Delete(animal.Codigo);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Erro ao remover dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                this.cadastrosAnimal_Load(sender, e);
            }
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e) {
            this.cadastrosAnimal_Load(sender, e);
        }
    }
}
