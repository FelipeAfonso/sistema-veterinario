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
    public partial class mainForm : Form {

        cadastrosAnimal cA;
        cadastrosVeterinario cV;
        cadastroAgendamento cAg;
        Agenda ag;
        public mainForm() {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void animaisToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cA.Visible)
                cA.Hide();
            cA.Show();
        }

        private void veterináriosToolStripMenuItem_Click(object sender, EventArgs e) {
           if (cV.Visible)
                cV.Hide();
            cV.Show();
        }

        private void mainForm_Load(object sender, EventArgs e) {
            this.cV = new cadastrosVeterinario(this);
            this.cA = new cadastrosAnimal(this);
            this.cAg = new cadastroAgendamento(this);
            this.ag = new Agenda(this);
            this.updateListas();
        }

        private void agendamentosToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cAg.Visible)
                cAg.Hide();
            cAg.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ag.Visible)
                ag.Hide();
            ag.Show();
        }

        public void updateListas() {
            Animal.listaAnimais = Animal.getAnimais("");
            Veterinario.listaVeterinarios = Veterinario.getVeterinarios("");
            Agendamento.listaAgendamentos = Agendamento.getAgendamentos("");
        }

    }
}
