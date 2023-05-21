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
    internal class ClientesDAO
    {
        public List<Clientes> getAllClientes()
        {
            List<Clientes> returnThess = new List<Clientes>();

            using (SqlConnection CN = new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p8g4; uid = p8g4; password = TiagoBerto.2021; TrustServerCertificate=true"))
            {
                CN.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT STAND_Cliente.NIF, STAND_Entidade.nome, STAND_Entidade.telefone, STAND_Entidade.endereco, STAND_Entidade.email FROM STAND_Cliente INNER JOIN STAND_Entidade ON STAND_Cliente.NIF = STAND_Entidade.NIF", CN))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Clientes c = new Clientes
                            {
                                NIF = dr.GetInt32(0),
                                Nome_Cliente = dr.IsDBNull(1) ? null : dr.GetString(1),
                                Telefone = dr.IsDBNull(2) ? null : dr.GetString(2),
                                Endereço = dr.IsDBNull(3) ? null : dr.GetString(3),
                                Email = dr.IsDBNull(4) ? null : dr.GetString(4),
                            };
                            returnThess.Add(c);
                        }
                    }
                }
            }

            return returnThess;
        }
    }

}
