using Microsoft.Data.SqlClient;
using Mundial.API.Models;
using System.Data;

namespace Mundial.API.Services
{
    public class SeleccionService(IConfiguration Config) : ISeleccionService
    {
        private readonly string? ConnectionString = 
            Config.GetConnectionString("DefaultConnection");

        public async Task ActualizarSeleccion(Seleccion seleccion)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ActualizarSeleccion";

                    cmd.Parameters.AddRange(
                    [
                        new SqlParameter("@Id", seleccion.Id),
                        new SqlParameter("@Nombre", seleccion.Nombre),
                        new SqlParameter("@Confederacion", seleccion.Confederacion),
                        new SqlParameter("@RankingFIFA", seleccion.RankingFIFA),
                        new SqlParameter("@MundialesGanados", seleccion.MundialesGanados)
                    ]);

                    await conn.OpenAsync();

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task BorrarSeleccion(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_EliminaSeleccion";

                    cmd.Parameters.AddWithValue("@Id", id);

                    await conn.OpenAsync();

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task CrearSeleccion(Seleccion seleccion)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.CommandText = "sp_CrearSeleccion";

                    cmd.Parameters.AddRange(
                    [
                        new SqlParameter("@Nombre", seleccion.Nombre),
                        new SqlParameter("@Confederacion", seleccion.Confederacion),
                        new SqlParameter("@RankingFIFA", seleccion.RankingFIFA),
                        new SqlParameter("@MundialesGanados", seleccion.MundialesGanados)
                    ]);

                    await conn.OpenAsync();

                    await cmd.ExecuteNonQueryAsync();

                }
            }
        }

        public async Task<List<Seleccion>> ObtenerTodos()
        {
            List<Seleccion> listaSelecciones = new List<Seleccion>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ObtenerSelecciones";

                    await conn.OpenAsync();

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            listaSelecciones.Add(new Seleccion()
                            {
                                Id = reader.GetInt32("Id"),
                                Nombre = reader.GetString("Nombre"),
                                Confederacion = reader.GetString("Confederacion"),
                                RankingFIFA = reader.GetInt32("RankingFIFA"),
                                MundialesGanados = reader.GetInt32("MundialesGanados")
                            });
                        }
                    }
                }
            }

            return listaSelecciones;
        }
    }
}
