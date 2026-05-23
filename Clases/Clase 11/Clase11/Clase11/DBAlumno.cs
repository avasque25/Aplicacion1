using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Clase11;

public class BDAlumno
{
    private SqliteConnection _connection;

    public BDAlumno(string archivoBD)
    {
        _connection = new SqliteConnection(archivoBD);
    }
    public List<Alumnos> Get()
    {
        List<Alumnos> alumnos = new List<Alumnos>();
        try
        {
            //Abrimos la conexion
            _connection.Open();
            string sql = "SELECT Carnet,Nombres,Apellidos,Telefono,DPI FROM Alumno";
            alumnos = _connection.Query<Alumnos>(sql).ToList();
        }
        catch (SqliteException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            _connection.Close();
        }
        return alumnos;
    }

    public Alumnos Get(string carnet)
    {
        Alumnos alumno = null;
        try
        {
            //Abrimos la conexion
            _connection.Open();
            string sql = "SELECT Carnet,Nombres,Apellidos,Telefono,DPI FROM Alumno WHERE Carnet = @Carnet";
            alumno = _connection.QuerySingle<Alumnos>(sql, new { Carnet = carnet });
        }
        catch (SqliteException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            _connection.Close();
        }
        return alumno;
    }

    public void Crear(Alumnos alumno)
    {
        try
        {
            _connection.Open();
            string sql =
                "INSERT INTO Alumno(Carnet,Nombres,Apellidos,Telefono,DPI) VALUES (@Carnet, @Nombres,@Apellidos,@Telefono,@DPI)";
            _connection.Execute(sql, alumno);
            Console.WriteLine("El alumno ha sido creado");
        }
        catch (SqliteException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            _connection.Close();
        }
    }

    public void Eliminar(string carnet)
    {
        try
        {
            _connection.Open();
            string sql = "DELETE FROM ALUMNO WHERE Carnet = @Carnet";
            _connection.Execute(sql, new { Carnet = carnet });
            Console.WriteLine("El alumno ha sido eliminado");
        }
        catch (SqliteException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            _connection.Close();
        }
    }

    public void Update(Alumnos alumno)
    {
        try
        {
            _connection.Open();
            string sql =
                "UPDATE Alumno SET Nombres=@Nombres, Apellidos=@Apellidos, Telefono=@Telefono,DPI = @DPI WHERE Carnet=@Carnet";
            _connection.Execute(sql, alumno);
            Console.WriteLine("El alumno ha sido modificado");
        }
        catch (SqliteException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            _connection.Close();
        }
    }
}
