using System;
namespace HospiEnCasa.App.Dominio
{
    public class Sujeto
    {
        public int Id  {get; set;}
        public string Nombre {get; set;}
        public string Apellidos {get; set;}
        public string NumeroTelefono {get; set;}
        public Genero Genero {set; get;}
    }
}

