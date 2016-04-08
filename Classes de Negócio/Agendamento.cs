using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Agendamento_de_Consultas_Veterinárias {
    public class Agendamento {

    #region Encapsulamento e Construtores
        public string Codigo { get; private set; }
        public DateTime Horario { get; set; }
        public Animal AnimalAgendado { get; private set; }
        public Veterinario VeterinarioAgendado { get; private set; }
        public static List<Agendamento> listaAgendamentos = new List<Agendamento>();
        public string CodigoAnimal { get; private set; }
        public string CpfVeterinario { get; private set; }

        public Agendamento(DateTime horario, Animal animal, Veterinario veterinario) {
            this.Codigo = GeradorCodigo.gerarCodigoValido();
            this.Horario = horario;
            this.AnimalAgendado = animal;
            this.VeterinarioAgendado = veterinario;
            this.CodigoAnimal = animal.Codigo;
            this.CpfVeterinario = veterinario.getMaskedCPF();
        }

        public Agendamento(DateTime horario, Animal animal, Veterinario veterinario, string codigo) {
            this.Codigo = codigo;
            this.Horario = horario;
            this.AnimalAgendado = animal;
            this.VeterinarioAgendado = veterinario;
            this.CodigoAnimal = animal.Codigo;
            this.CpfVeterinario = veterinario.getMaskedCPF();
        }

        public Agendamento() { }
    #endregion 

    #region CRUD
        public void Create() {
            Conexao.Conectar();
            try {
                Conexao.ExecuteCommand("insert into agendamento (codigo, data_hora, codigoAnimal, cpfVeterinario) values " 
                    + "('" + this.Codigo + "','" + this.Horario.ToString("yyyy-MM-dd HH:mm:ss") 
                    + "','" + this.AnimalAgendado.Codigo + "','" + this.VeterinarioAgendado.CPF + "');");
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Erro ao incluir dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Conexao.Desconectar();
            }
        }

        public void Read(string valor, string coluna) {
            try {
                Conexao.Conectar();
                MySqlCommand cmdSrc = new MySqlCommand("select * from agendamento where '" + coluna + "' = '" + valor + "';", Conexao.Connection);
                MySqlDataReader dataReader = Conexao.dataReader(cmdSrc);
                if (dataReader != null) {
                    while (dataReader.Read()) {
                        this.Codigo = dataReader.GetInt32("codigo").ToString();
                        this.Horario = dataReader.GetDateTime("data_hora");
                        string codigoAnimalTemp = dataReader.GetInt32("codigoAnimal").ToString();
                        string cpfVetTempo = dataReader.GetString("cpfVeterinario");
                        foreach (Animal a in Animal.listaAnimais) {
                            if (a.Codigo == codigoAnimalTemp) {
                                this.AnimalAgendado = a;
                                break;
                            }
                        }
                        foreach (Veterinario v in Veterinario.listaVeterinarios) {
                            if (v.CPF == cpfVetTempo) {
                                this.VeterinarioAgendado = v;
                                break;
                            }
                        }
                    }
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Erro ao buscar dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Conexao.Desconectar();
            }
        }

        public void Update() {
            Conexao.Conectar();
            try {
                Conexao.ExecuteCommand("update agendamento set data_hora = '" + this.Horario.ToString("yyyy-MM-dd HH:mm:ss")
                    + "' where codigo = '" + this.Codigo + "';");
                MessageBox.Show("Agendamento atualizado com sucesso", "Cadastro de Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Erro ao atualizar dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Conexao.Desconectar();
            }
        }

        public void Delete() {
            Conexao.Conectar();
            try {
                Conexao.ExecuteCommand("delete from agendamento where codigo = '" + this.Codigo + "';");
                MessageBox.Show("Agendamento removido com sucesso", "Cadastro de Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Erro ao remover dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Conexao.Desconectar();
            }
        }

    #endregion

        public static List<Agendamento> getAgendamentos(string condicao) {
            List<Agendamento> temp = new List<Agendamento>();
            List<string> codigos = new List<string>();
            List<DateTime> horarios = new List<DateTime>();
            List<string> animaisC = new List<string>();
            List<string> veterinariosC = new List<string>();
            List<Animal> animais = new List<Animal>();
            List<Veterinario> veterinarios = new List<Veterinario>();
            Conexao.Conectar();
            try {
                MySqlCommand cmd = new MySqlCommand("select * from agendamento" + condicao, Conexao.Connection);
                MySqlDataReader dataReader = Conexao.dataReader(cmd);
                if (dataReader != null) {
                    while (dataReader.Read()) {
                        codigos.Add(dataReader.GetString("codigo"));
                        horarios.Add(dataReader.GetDateTime("data_hora"));
                        animaisC.Add(dataReader.GetString("codigoAnimal"));
                        veterinariosC.Add(dataReader.GetString("cpfVeterinario"));
                    }
                    dataReader.Close();
                    for (int x = 0; x < codigos.Count; x++) {
                        foreach (Animal a in Animal.listaAnimais) {
                            if (a.Codigo == animaisC[x]) {
                                animais.Add(a);
                                break;
                            }
                        }
                        foreach (Veterinario v in Veterinario.listaVeterinarios) {
                            if (v.CPF == veterinariosC[x]) {
                                veterinarios.Add(v);
                                break;
                            }
                        }
                        temp.Add(new Agendamento(horarios[x], animais[x], veterinarios[x], codigos[x]));
                    }
                }

            }catch(Exception e){
                MessageBox.Show(e.Message, "Erro ao buscar dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }finally{
                Conexao.Desconectar();
            }
            return temp;

        } 

    }
}
