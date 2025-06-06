using System;

namespace ComunidadEducativa
{
    class Program
    {
        static void Main(string[] args)
        {
            MiembroDeLaComunidad miembro = new MiembroDeLaComunidad("Juan", 30);
            miembro.MostrarInformacion();

            Empleado empleado = new Empleado("Ana", 40, "Secretaria");
            empleado.MostrarInformacion();

            Docente docente = new Docente("Carlos", 35, "Profesor", "Matemáticas");
            docente.MostrarInformacion();

            Administrador administrador = new Administrador("Luis", 50, "Director", "Ciencias", "Administración General");
            administrador.MostrarInformacion();

            Maestro maestro = new Maestro("María", 28, "Profesor", "Literatura", "Español");
            maestro.MostrarInformacion();

            Administrativo administrativo = new Administrativo("Pedro", 45, "Contador", "Finanzas");
            administrativo.MostrarInformacion();

            Estudiante estudiante = new Estudiante("Lucía", 20, "Ingeniería");
            estudiante.MostrarInformacion();

            ExAlumno exAlumno = new ExAlumno("Miguel", 25, 2018);
            exAlumno.MostrarInformacion();
        }
    }
}