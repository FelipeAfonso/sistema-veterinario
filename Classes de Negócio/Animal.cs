using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Agendamento_de_Consultas_Veterinárias {
    public class Animal {

        #region Encapsulamento e construtores
        public string Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Raça { get; private set; }
        public DateTime Nascimento { get; private set; }
        public static List<Animal> listaAnimais = new List<Animal>();
        public string nome_codigo { get; private set; }

        public Animal(string nome, string raça, string data) {
            this.Nome = nome;
            this.Raça = raça;
            this.Nascimento = DateTime.Parse(data);
            this.Codigo = GeradorCodigo.gerarCodigoValido();
            this.nome_codigo = this.Nome + "-" + this.Codigo;
        }

        public Animal(string nome, string raça, DateTime data) {
            this.Nome = nome;
            this.Raça = raça;
            this.Nascimento = data;
            this.Codigo = GeradorCodigo.gerarCodigoValido();
            this.nome_codigo = this.Nome + "-" + this.Codigo;
        }

        public Animal() { }

        public void setAnimal(string nome, string raça, DateTime data, string codigo){
            this.Codigo = codigo;
            this.Nome = nome;
            this.Raça = raça;
            this.Nascimento = data;
            this.nome_codigo = this.Nome + "-" + this.Codigo;
        }
#endregion

        #region CRUD
        public void Create() {
            Conexao.Conectar();
            try {
                Conexao.ExecuteCommand("insert into animal (codigo,nome,raca,nascimento) values ('" + this.Codigo + "','" + this.Nome + "','" + this.Raça + "','" + this.Nascimento.ToString("yyyy-MM-dd") + "')");
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Erro ao incluir dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Conexao.Desconectar();
            }
        }

        public void Read(string valor, string coluna) {
            try {
                Conexao.Conectar();
                MySqlCommand cmdSrc = new MySqlCommand("select * from animal where '" + coluna + "' = '" + valor + "'", Conexao.Connection);
                MySqlDataReader dataReader = Conexao.dataReader(cmdSrc);
                if (dataReader != null) {
                    while (dataReader.Read()) {
                        this.Codigo = dataReader.GetUInt32("codigo").ToString();
                        this.Nome = dataReader.GetString("nome");
                        this.Raça = dataReader.GetString("raca");
                        this.Nascimento = dataReader.GetDateTime("nascimento");
                    }
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Erro ao buscar dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Conexao.Desconectar();
            }
        }

        public void Update(string novoNome, string novaRaça, DateTime novoNascimento) {
            Conexao.Conectar();
            try {
                Conexao.ExecuteCommand("update animal set nome = '" + novoNome + "', raca = '" + novaRaça + "', nascimento = '" + novoNascimento + "' where codigo = '" + this.Codigo + "'"); 
                MessageBox.Show("Animal atualizado com sucesso", "Cadastro de Animal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Erro ao atualizar dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Conexao.Desconectar();
            }
        }

        public void Delete(string valor) {
            Conexao.Conectar();
            try {
                Conexao.ExecuteCommand("delete from animal where codigo = '" + valor + "'");
                MessageBox.Show("Animal removido com sucesso", "Cadastro de Animal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Erro ao remover dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Conexao.Desconectar();
            }
        }

#endregion

        public static List<Animal> getAnimais(string condiçao) {
            Conexao.Conectar();
            List<Animal> temp = new List<Animal>();
            List<string> nomes = new List<string>();
            List<string> raças = new List<string>();
            List<DateTime> nascimentos = new List<DateTime>();
            List<string> codigos = new List<string>();
            try {
                MySqlCommand cmd = new MySqlCommand("select * from animal" + condiçao, Conexao.Connection);
                MySqlDataReader dataReader = Conexao.dataReader(cmd);
                if (dataReader != null) {
                    while (dataReader.Read()) {
                        nomes.Add(dataReader.GetString("nome"));
                        raças.Add(dataReader.GetString("raca"));
                        nascimentos.Add(dataReader.GetDateTime("nascimento"));
                        codigos.Add(dataReader.GetInt32("codigo").ToString());
                    }
                    dataReader.Close();
                    for(int x =0; x<nomes.Count;x++) {
                        Animal animalTemp = new Animal();
                        animalTemp.setAnimal(nomes[x],raças[x],nascimentos[x],codigos[x]);
                        temp.Add(animalTemp);
                    }
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Erro ao buscar dados no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Conexao.Desconectar();
            }

            return temp;
        }
        
    }
}
