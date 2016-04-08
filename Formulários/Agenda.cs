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
    public partial class Agenda : Form {
        mainForm mF = new mainForm();
        public Agenda(mainForm mF) {
            InitializeComponent();
            this.mF = mF;
            this.MdiParent = mF;
            this.dGV_Consultas.AutoGenerateColumns = true;
            this.dGV_Consultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        protected override void OnClosing(CancelEventArgs e) {
            this.Hide();
            e.Cancel = true;
        }

        private void Agenda_Load(object sender, EventArgs e) {
            this.dGV_Consultas.DataSource = new BindingList<Agendamento>(Agendamento.listaAgendamentos);
            this.dGV_Consultas.Columns[2].Visible = false;
            this.dGV_Consultas.Columns[3].Visible = false;
            this.dGV_Consultas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dGV_Consultas_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 4) {
                Animal a = (Animal)dGV_Consultas.Rows[e.RowIndex].Cells[2].Value;
                MessageBox.Show("Codigo: " + a.Codigo + "\nNome: " + a.Nome + "\nRaça: "
                    + a.Raça + "\nNascimento: " + a.Nascimento.ToString("dd/MM/yyyy"),
                    "Informações do Animal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.ColumnIndex == 5) {
                Veterinario v = (Veterinario)dGV_Consultas.Rows[e.RowIndex].Cells[3].Value;
                MessageBox.Show("CPF: " + v.getMaskedCPF() + "\nNome: " + v.Nome + "\nNascimento: "
                    + v.Nascimento.ToString("dd/MM/yyyy") + "\nRegistro: " + v.Registro,
                    "Informações do Veterinario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mC_Agenda_DateSelected(object sender, DateRangeEventArgs e) {
            BindingList<Agendamento> temp = new BindingList<Agendamento>();
            foreach (Agendamento a in Agendamento.listaAgendamentos) {
                if (a.Horario.Date.CompareTo(e.Start) >= 0 && a.Horario.Date.CompareTo(e.End) <= 0)
                    temp.Add(a);
            }
            dGV_Consultas.DataSource = temp;
        }

        private void btn_Remover_Click(object sender, EventArgs e) {
            try {
                List<Agendamento> removeList = new List<Agendamento>();
                foreach (DataGridViewRow row in dGV_Consultas.SelectedRows) {
                    foreach (Agendamento a in Agendamento.listaAgendamentos) {
                        if (a.Codigo == dGV_Consultas.Rows[row.Index].Cells[0].Value.ToString()) {
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
                this.Agenda_Load(sender, e);
            }
        }

        private void dGV_Consultas_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            try {
                Agendamento temp = (Agendamento)dGV_Consultas.Rows[e.RowIndex].DataBoundItem;
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
                this.Agenda_Load(sender, e);
            }
        }

        private void Agenda_Activated(object sender, EventArgs e) {
            this.Agenda_Load(sender, e);
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
