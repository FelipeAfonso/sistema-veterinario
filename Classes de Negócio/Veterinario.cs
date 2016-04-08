using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Agendamento_de_Consultas_Veterinárias {
    public class Veterinario {

        #region Encapsulamento e construtores
        private string cpf { get; set; }
        public string Nome { get; private set; }
        public string Registro { get; private set; }
        public DateTime Nascimento { get; private set; }
        public static List<Veterinario> listaVeterinarios = new List<Veterinario>();
        public string CPF {
            get { return this.cpf; }
            set {
                try {
                    if (value.Count() > 11) {
                        string newValue = "";
                        foreach (char c in value) {
                            if (char.IsDigit(c))
                                newValue += c;
                        }
                        value = newValue;
                    }
                    foreach (Veterinario vet in listaVeterinarios) {
                        if (vet.cpf == value)
                            throw new Exception("CPF já cadastrado");
                    }
                    this.cpf = value;
                } catch (Exception e) {
                    MessageBox.Show(e.Message, "Erro ao cadastrar Veterinario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public string nome_cpf { get; private set; }

        public Veterinario(string cpf, string nome, string registro, string data) {
            this.CPF = cpf;
            this.Nome = nome;
            this.Registro = registro;
            this.Nascimento = DateTime.Parse(data);
            this.nome_cpf = this.Nome + "-" + this.CPF;
        }

        public Veterinario(string cpf, string nome, string registro, DateTime data) {
            this.CPF = cpf;
            this.Nome = nome;
            this.Registro = registro;
            this.Nascimento = data;
            this.nome_cpf = this.Nome + "-" + this.CPF;
        }

        public Veterinario(string nome, string registro, DateTime data, string cpfSemValidacao) {
            this.Nome = nome;
            this.Registro = registro;
            this.Nascimento = data;
            this.cpf = cpfSemValidacao;
            this.nome_cpf = this.Nome + "-" + this.CPF;
        }

        public Veterinario() { }

#endregion

        #region CRUD
        public void Create() {
            Conexao.Conectar();
            try {
                Conexao.ExecuteCommand("insert into veterinario (cpf,nome,registro,nascimento) values ('" + this.CPF + "','" + this.Nome + "','" + this.Registro + "','" + this.Nascimento.ToString("yyyy-MM-dd") + "')");
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Erro ao incluir dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Conexao.Desconectar();
            }
        }

        public void Read(string valor, string coluna) {
            try {
                Conexao.Conectar();
                MySqlCommand cmdSrc = new MySqlCommand("select * from veterinario where '" + coluna + "' = '" + valor + "'", Conexao.Connection);
                MySqlDataReader dataReader = Conexao.dataReader(cmdSrc);
                if (dataReader != null) {
                    while (dataReader.Read()) {
                        this.CPF = dataReader.GetString("cpf");
                        this.Nome = dataReader.GetString("nome");
                        this.Registro = dataReader.GetString("registro");
                        this.Nascimento = dataReader.GetDateTime("nascimento");
                    }
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Erro ao buscar dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Conexao.Desconectar();
            }
        }

        public void Update(string novoNome, string novoRegistro, DateTime novoNascimento) {
            Conexao.Conectar();
            try {
                Conexao.ExecuteCommand("update veterinario set nome = '" + novoNome + "', registro = '" + novoRegistro + "', nascimento = '" + novoNascimento + "' where cpf = '" + this.CPF + "'"); 
                MessageBox.Show("Veterinario atualizado com sucesso", "Cadastro de Veterinario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Erro ao atualizar dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Conexao.Desconectar();
            }
        }

        public void Delete() {
            Conexao.Conectar();
            try {
                Conexao.ExecuteCommand("delete from veterinario where cpf = '" + this.CPF + "'");
                MessageBox.Show("Veterinario removido com sucesso", "Cadastro de Veterinario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Erro ao remover dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Conexao.Desconectar();
            }
        }

#endregion

        public static List<Veterinario> getVeterinarios(string condiçao) {
            Conexao.Conectar();
            List<Veterinario> temp = new List<Veterinario>();
            List<string> nomes = new List<string>();
            List<string> registros = new List<string>();
            List<DateTime> nascimentos = new List<DateTime>();
            List<string> cpfs = new List<string>();
            try {
                MySqlCommand cmd = new MySqlCommand("select * from veterinario" + condiçao, Conexao.Connection);
                MySqlDataReader dataReader = Conexao.dataReader(cmd);
                if (dataReader != null) {
                    while (dataReader.Read()) {
                        nomes.Add(dataReader.GetString("nome"));
                        registros.Add(dataReader.GetString("registro"));
                        nascimentos.Add(dataReader.GetDateTime("nascimento"));
                        cpfs.Add(dataReader.GetString("cpf"));
                    }
                    dataReader.Close();
                    for(int x =0; x<nomes.Count;x++) {
                        temp.Add(new Veterinario(nomes[x], registros[x], nascimentos[x], cpfs[x]));
                    }
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Erro ao buscar dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Conexao.Desconectar();
            }
            return temp;
        }

        public string getMaskedCPF() {
            string newCpf = this.CPF.Substring(0, 3) + "." + this.CPF.Substring(3, 3) + "." + this.CPF.Substring(6, 3) + "-" + this.CPF.Substring(9);
            return newCpf;
        }
    }
}
