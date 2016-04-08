using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Agendamento_de_Consultas_Veterinárias {
    static class Conexao {

        private static MySqlConnection con = new MySqlConnection("server=localhost;Port=3306;database=agendamento_consultas;user id=root;");
        public static MySqlConnection Connection { get { return con; } set { con = value; } }
        
        public static bool Conectar() {
            try {
                if (Connection.State == System.Data.ConnectionState.Closed) {
                    Connection.Open();
                }
                return true;
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Erro ao conectar com Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool Desconectar() {
            try {
                if (Connection.State == System.Data.ConnectionState.Open) {
                    Connection.Close();
                } return true;
            } catch {
                return false;
            }
        }

        public static bool ExecuteCommand(string command) {
            MySqlCommand cmdExecute = new MySqlCommand(command);
            MySqlTransaction Transaction = Connection.BeginTransaction();
            cmdExecute.Connection = Connection;
            cmdExecute.Transaction = Transaction;
            try {
                cmdExecute.ExecuteNonQuery();
                Transaction.Commit();
                Desconectar();
                return true;
            } catch(Exception e) {
                Transaction.Rollback();
                Desconectar();
                MessageBox.Show(e.Message + "\n\nRollback executado, nenhum dado foi alterado", "Erro de interação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static MySqlDataReader dataReader(MySqlCommand cmd) {
            try {
                cmd.Connection = Connection;
                MySqlDataReader dr = cmd.ExecuteReader();
                return dr;
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Erro ao ler Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
