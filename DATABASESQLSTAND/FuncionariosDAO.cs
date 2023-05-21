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
    internal class FuncionariosDAO
    {
        public List<Funcionarios> getAllFuncionarios()
        {
            List<Funcionarios> returnThess = new List<Funcionarios>();

            using (SqlConnection CN = new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p8g4; uid = p8g4; password = TiagoBerto.2021; TrustServerCertificate=true"))
            {
                CN.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT STAND_Funcionario.NIF, STAND_Entidade.nome, STAND.Nome, STAND_FuncaoStand.Funcao, STAND_Entidade.telefone, STAND_Entidade.endereco, STAND_Entidade.email FROM STAND_Funcionario INNER JOIN STAND_Entidade ON STAND_Funcionario.NIF = STAND_Entidade.NIF INNER JOIN STAND ON STAND.id = STAND_Funcionario.id_stand INNER JOIN STAND_FuncaoStand ON STAND_FuncaoStand.id = STAND_Funcionario.id_funcao", CN))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Funcionarios f = new Funcionarios
                            {
                                NIF = dr.IsDBNull(0) ? null : dr.GetInt32(0),
                                Nome_Funcionario = dr.IsDBNull(1) ? null : dr.GetString(1),
                                Nome_Stand = dr.IsDBNull(2) ? null : dr.GetString(2),
                                Função = dr.IsDBNull(3) ? null : dr.GetString(3),
                                Telefone = dr.IsDBNull(4) ? null : dr.GetString(4),
                                Endereço = dr.IsDBNull(5) ? null : dr.GetString(5),
                                Email = dr.IsDBNull(6) ? null : dr.GetString(6),
                            };
                            returnThess.Add(f);
                        }
                    }
                }
            }

            return returnThess;
        }
    }

}
