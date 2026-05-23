using Microsoft.Data.SqlClient;
using Dapper;

namespace CRUDAlumnos;

public class BDAlumno
{
    private SqlConnection _connection;

    public BDAlumno(string connectionString)
    {
        _connection = new SqlConnection(connectionString);
    }

    // LISTAR
    public List<Alumno> Get()
    {
        List<Alumno> alumnos = new List<Alumno>();

        try
        {
            _connection.Open();

            string sql = "SELECT Carnet, Nombres, Apellidos, Telefono, DPI FROM Alumno";

            alumnos = _connection.Query<Alumno>(sql).ToList();
        }
        catch (SqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            _connection.Close();
        }

        return alumnos;
    }

    // BUSCAR POR CARNET
    public Alumno Get(string carnet)
    {
        Alumno alumno = null;

        try
        {
            _connection.Open();

            string sql = @"SELECT Carnet, Nombres, Apellidos, Telefono, DPI 
                           FROM Alumno 
                           WHERE Carnet = @Carnet";

            alumno = _connection.QuerySingleOrDefault<Alumno>(
                sql,
                new { Carnet = carnet }
            );
        }
        catch (SqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            _connection.Close();
        }

        return alumno;
    }

    // CREAR
    public void Crear(Alumno alumno)
    {
        try
        {
            _connection.Open();

            string sql = @"INSERT INTO Alumno
                          (Carnet, Nombres, Apellidos, Telefono, DPI)
                          VALUES
                          (@Carnet, @Nombres, @Apellidos, @Telefono, @DPI)";

            _connection.Execute(sql, alumno);

            Console.WriteLine("Alumno creado correctamente");
        }
        catch (SqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            _connection.Close();
        }
    }

    // ACTUALIZAR
    public void Update(Alumno alumno)
    {
        try
        {
            _connection.Open();

            string sql = @"UPDATE Alumno
                          SET
                          Nombres = @Nombres,
                          Apellidos = @Apellidos,
                          Telefono = @Telefono,
                          DPI = @DPI
                          WHERE Carnet = @Carnet";

            _connection.Execute(sql, alumno);

            Console.WriteLine("Alumno actualizado");
        }
        catch (SqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            _connection.Close();
        }
    }

    // ELIMINAR
    public void Eliminar(string carnet)
    {
        try
        {
            _connection.Open();

            string sql = "DELETE FROM Alumno WHERE Carnet = @Carnet";

            _connection.Execute(sql, new { Carnet = carnet });

            Console.WriteLine("Alumno eliminado");
        }
        catch (SqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            _connection.Close();
        }
    }
}