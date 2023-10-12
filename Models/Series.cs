using System;
using System.ComponentModel.DataAnnotations;
namespace TP10.Models;

public class Series
{
public int IdSerie {set;get;}
public string Nombre {set;get;}
public int AñoInicio {set;get;}
public string Sinopsis {set;get;}
public string ImagenSerie {set;get;}

}