using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agendamento_de_Consultas_Veterinárias {
    static class GeradorCodigo {

        private static List<string> codigosGerados = new List<string>();
        private static Random r = new Random();

        private static string criarCodigo() {
            string codigo = "";
            int count = 0;
            for (int x = 0; x < 4; x++) {
                if (count == 0)                          //Questão de compatibilidade com o SQL
                    codigo += r.Next(1, 10).ToString();  
                else
                    codigo += r.Next(0, 10).ToString();
                count++;
            }
            return codigo;
        }

        public static string gerarCodigoValido(){
            string codigo = criarCodigo();
            int i = 0;
            while (i <= codigosGerados.Count) {
                if (codigosGerados.Count == 0) i++;
                foreach (string codigoGerado in codigosGerados) {
                    if (codigo == codigoGerado) {
                        codigo = criarCodigo();
                        i = 0;
                    } else i++; 
                }
            }
            codigosGerados.Add(codigo);
            return codigo;
        }
    }
}
