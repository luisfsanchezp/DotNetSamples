using System;

namespace TiposDeDatosApp
{
    //La clase estudiante hereda de la clase Persona.
    public class Estudiante : Persona
    {
        //no necesito agregar ninguna propiedad porque 
        //la clase base tiene todos los campos que requiere.
        //Creo un Constructor para la clase que permit ainicializar las propiedades.       

       public Estudiante(int idest, string nom, string apel, string dir, string ema, int tel, DateTime fen, DateTime fin)
        {
            this.Id = idest;
            this.Nombres = nom;
            this.Apellidos = apel;
            this.Direccion = dir;
            this.Email = ema;
            this.Telefono = tel;
            this.FeNacimiento = fen;
            this.FeIngreso = fin;
        }
        public void GetInfoEstudiante()
        {
            Console.WriteLine(this.Nombres + " " + this.Apellidos);
        }
    }
}