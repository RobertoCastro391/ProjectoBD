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
    internal class StandsDAO
    {
        public List<Stands> getAllStands()
        {
            List<Stands> returnThess = new List<Stands>();

            using (SqlConnection CN = new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p8g4; uid = p8g4; password = TiagoBerto.2021; TrustServerCertificate=true"))
            {
                CN.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM STAND", CN))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Stands s = new Stands
                            {
                                id_Stand = dr.IsDBNull(0) ? null : (int?)dr.GetInt32(0),
                                Nome_Stand = dr.IsDBNull(1) ? null : dr.GetString(1),
                                Endereço = dr.IsDBNull(2) ? null : dr.GetString(2),
                                Telefone = dr.IsDBNull(3) ? null : dr.GetString(3),
                                Email = dr.IsDBNull(4) ? null : dr.GetString(4),
                            };
                            returnThess.Add(s);
                        }
                    }
                }
            }

            return returnThess;
        }
    }

}
