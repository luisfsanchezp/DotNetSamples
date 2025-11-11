using System;

namespace TiposDeDatosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fing = DateTime.UtcNow;
            DateTime fnac = DateTime.Parse("04/20/2009");
            //Creamos una instancia del objeto Estudiante.
            Estudiante alumno = new Estudiante(98646, "Luis Fernando", "Sanchez Perez","Calle con carera y numero","yosisoy@elmejor.com",31200000,fnac,fing);
            alumno.GetInfoEstudiante();
        }
    }
}
