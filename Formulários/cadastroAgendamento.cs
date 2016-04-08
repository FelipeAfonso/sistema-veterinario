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
    public partial class cadastroAgendamento : Form {
        mainForm mF = new mainForm();
        public cadastroAgendamento(mainForm mF) {
            InitializeComponent();
            this.mF = mF;
            this.MdiParent = mF;
            this.dGV_Agendamentos.AutoGenerateColumns = true;
            this.dGV_Agendamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        protected override void OnClosing(CancelEventArgs e) {
            this.Hide();
            e.Cancel = true;
        }


        private void cadastroAgendamento_Shown(object sender, EventArgs e) {
            cadastroAgendamento_Load(sender, e);
        }

        private void cadastroAgendamento_Load(object sender, EventArgs e) {
            mF.updateListas();
            dTP_Data.ResetText(); cB_Animal.ResetText(); cB_Veterinario.ResetText(); mTB_Hora.Clear();
            dGV_Agendamentos.DataSource = new BindingList<Agendamento>(Agendamento.listaAgendamentos);
            dGV_Agendamentos.Columns[2].Visible = false;
            dGV_Agendamentos.Columns[3].Visible = false;
            dGV_Agendamentos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            cB_Animal.DataSource = Animal.listaAnimais;
            cB_Animal.DisplayMember = "nome_codigo";
            cB_Veterinario.DataSource = Veterinario.listaVeterinarios;
            cB_Veterinario.DisplayMember = "nome_cpf";
        }

        private void dGV_Agendamentos_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 4) {
                Animal a = (Animal) dGV_Agendamentos.Rows[e.RowIndex].Cells[2].Value;
                MessageBox.Show("Codigo: " + a.Codigo + "\nNome: " + a.Nome + "\nRaça: " 
                    + a.Raça + "\nNascimento: " + a.Nascimento.ToString("dd/MM/yyyy"), 
                    "Informações do Animal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.ColumnIndex == 5) {
                Veterinario v = (Veterinario)dGV_Agendamentos.Rows[e.RowIndex].Cells[3].Value;
                MessageBox.Show("CPF: " + v.getMaskedCPF() + "\nNome: " + v.Nome + "\nNascimento: "
                    + v.Nascimento.ToString("dd/MM/yyyy") + "\nRegistro: " + v.Registro, 
                    "Informações do Veterinario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e) {
            try {
                DateTime horario = new DateTime(dTP_Data.Value.Year, dTP_Data.Value.Month, dTP_Data.Value.Day, 
                    Convert.ToInt32(mTB_Hora.Text.Substring(0,2)), Convert.ToInt32(mTB_Hora.Text.Substring(3,2)), 0);
                if (confereHorarios(horario)) {
                    Agendamento temp = new Agendamento(horario, (Animal)cB_Animal.SelectedItem, (Veterinario)cB_Veterinario.SelectedItem);
                    Agendamento.listaAgendamentos.Add(temp);
                    temp.Create();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Erro ao cadastrar dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                cadastroAgendamento_Load(sender, e);
            }
        }

        private void btn_Remover_Click(object sender, EventArgs e) {
            try {
                List<Agendamento> removeList = new List<Agendamento>();
                foreach (DataGridViewRow row in dGV_Agendamentos.SelectedRows) {
                    foreach (Agendamento a in Agendamento.listaAgendamentos) {
                        if (a.Codigo == dGV_Agendamentos.Rows[row.Index].Cells[0].Value.ToString()) {
                            removeList.Add(a);
                        }
                    }
                }
                foreach (Agendamento a in removeList) {
                    Agendamento.listaAgendamentos.Remove(a);
                    a.Delete();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Erro ao remover dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                this.cadastroAgendamento_Load(sender, e);
            }

        }

        private void dGV_Agendamentos_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            try {
                Agendamento temp = (Agendamento)dGV_Agendamentos.Rows[e.RowIndex].DataBoundItem;
                if (confereHorarios(temp.Horario)) {
                    temp.Update();
                    foreach (Agendamento a in Agendamento.listaAgendamentos) {
                        if (a.Codigo == temp.Codigo) {
                            Agendamento.listaAgendamentos.Remove(a);
                            Agendamento.listaAgendamentos.Add(temp);
                            break;
                        }
                    }
                } else {
                    throw new Exception("Horario indisponivel");
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Erro ao editar dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                this.cadastroAgendamento_Load(sender, e);
            }
        }

        private bool confereHorarios(DateTime horario) {
            double ajuste = 30; //Valor em minutos para não criar uma consulta enquanto estiver ocorrendo outra
            DateTime horarioFim = horario.AddMinutes(ajuste);
            foreach (Agendamento ag in Agendamento.listaAgendamentos) {
                DateTime consultaFim = ag.Horario.AddMinutes(ajuste);
                DateTime consultaPre = ag.Horario.AddMinutes(-ajuste);
                if (horario.CompareTo(consultaPre) > 0 && horario.CompareTo(consultaFim) < 0)
                    return false;
                }
            return true;
        }
    }
}
