using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DATABASESQLSTAND
{
    internal class VeiculosDAO
    {
        public List<Veiculos> getAllVeiculos()
        {
            List<Veiculos> returnThess = new List<Veiculos>();

            using (SqlConnection CN = new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p8g4; uid = p8g4; password = TiagoBerto.2021; TrustServerCertificate=true"))
            {
                CN.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM STAND_Veiculos", CN))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Veiculos v = new Veiculos
                            {
                                Matricula = dr.GetString(0),
                                id_Marca = dr.IsDBNull(1) ? null : (int?)dr.GetInt32(1),
                                id_Stand = dr.IsDBNull(2) ? null : (int?)dr.GetInt32(2),
                                Modelo = dr.IsDBNull(3) ? null : dr.GetString(3),
                                id_Categoria = dr.IsDBNull(4) ? null : (int?)dr.GetInt32(4),
                                Ano = dr.IsDBNull(5) ? null : (int?)dr.GetInt32(5),
                                Cilindrada = dr.IsDBNull(6) ? null : (int?)dr.GetInt32(6),
                                id_Cor = dr.IsDBNull(7) ? null : (int?)dr.GetInt32(7),
                                Quilometros = dr.IsDBNull(8) ? null : (int?)dr.GetInt32(8),
                                id_Combustivel = dr.IsDBNull(9) ? null : (int?)dr.GetInt32(9),
                                Preco_Anunciado = dr.IsDBNull(10) ? null : (decimal?)dr.GetDecimal(10),
                                Observações = dr.IsDBNull(11) ? null : dr.GetString(11)
                            };
                            returnThess.Add(v);
                        }
                    }
                }
            }

            return returnThess;
        }
    }

}
