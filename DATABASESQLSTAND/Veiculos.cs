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
        public int? id_Marca { get; set; }
        public int? id_Stand { get; set; }
        public string Modelo { get; set; }
        public int? id_Categoria { get; set; }
        public int? Ano { get; set; }
        public int? Cilindrada { get; set; }
        public int? id_Cor { get; set; }
        public int? Quilometros { get; set; }
        public int? id_Combustivel { get; set; }
        public decimal? Preco_Anunciado { get; set; }
        public string Observações { get; set; }
    }

}
