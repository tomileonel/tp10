using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using Dapper;
namespace TP10.Models;

public static class BD
{
    private static string ConnectionString = @"Server=DELL-MIGUE\SQLEXPRESS; DataBase=BDSeries; Trusted_Connection=True";

    public static List<Series> ObtenerSeries()
    {
        List<Series> listaseries = new List<Series>();
        string sql = "SELECT * FROM Series";
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            listaseries = db.Query<Series>(sql).ToList();
        }
        return listaseries;
    }

        public static Series ObtenerInfoSerie(int idSerie)
    {
        Series Serie = null;
        string sql = "SELECT * FROM Series WHERE IdSerie = @iidSerie";
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            Serie = db.QueryFirstOrDefault<Series>(sql, new {iidSerie = idSerie});
        }
        return Serie;
    }

            public static List<string> ObtenerActoresSerie(int idSerie)
    {
        List<string> listaActores = new List<string>();
        string sql = "SELECT Nombre FROM Actores WHERE IdSeries = @iidSerie";
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            listaActores = db.Query<string>(sql, new {iidSerie = idSerie}).ToList();
        }
        return listaActores;
    }

public static List<Temporadas> ObtenerTemporadasSerie(int idSerie)
{
    List<Temporadas> listaTemporadas = new List<Temporadas>();
    string sql = "SELECT * FROM Temporadas WHERE IdSeries = @iidSerie";

    using (SqlConnection db = new SqlConnection(ConnectionString))
    {
        listaTemporadas = db.Query<Temporadas>(sql, new { iidSerie = idSerie }).ToList();
    }
    return listaTemporadas;
}



}