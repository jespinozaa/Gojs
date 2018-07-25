using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace GojsGraph.Models
{
    public class Broker
    {
        public static List<T> ConsultarNodo<T>() where T : class
        {
            using (IDbConnection conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ToString()))
            {
                try
                {
                    return conexion.Query<T>("SELECT (json_value([$node_id_068A7BAE80654EEAACC4B9DA7215A828],'$.id')) NodeId,Id,nombre FROM [SENGU].[dbo].[PersonaNodo]", commandType: CommandType.Text, commandTimeout: 2000).ToList();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }


        public static List<T> ConsultarVertices<T>() where T : class
        {
            using (IDbConnection conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Conexion"].ToString()))
            {
                try
                {
                    return conexion.Query<T>("SELECT (json_value([$edge_id_0FB5B0E10A924BC193CCB826B4CEBDD1],'$.id')) EdgeId,(select json_value([$from_id_741B86E0702A4CA3BF05B1E825646F2A],'$.id')) [From],(select json_value([$to_id_23E24B9C2A7A4926A42FF730A9FA5CE5],'$.id')) [To] FROM [SENGU].[dbo].[Tiene]", commandType: CommandType.Text, commandTimeout: 2000).ToList();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }
    }
}