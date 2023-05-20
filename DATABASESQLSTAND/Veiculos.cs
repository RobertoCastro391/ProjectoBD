using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASESQLSTAND
{
    internal class Veiculos
    {
        public string Matricula { get; set; }
        public int id_Marca { get; set; }
        public int id_stand { get; set; }
        public String Modelo { get; set; }
        public int id_Categoria { get; set; }
        public int Ano { get; set; }
        public int Cilindrada { get; set; }
        public int id_Cor { get; set; }
        public int Quilometros { get; set; }
        public int id_Combustivel{ get; set; }
        public int Preco_Anunciado { get; set; }
        public String Observações { get; set; }
    }
}
