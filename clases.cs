// Tarea 1 - Realice un Mapa de Clases 
// Estudiante  : Angel Gabriel Moquete 2024-1771

using System;

namespace ComunidadEducativa
{
    // Clase base: MiembroDeLaComunidad
    public class MiembroDeLaComunidad
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public MiembroDeLaComunidad(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }

    // Subclase: Empleado
    public class Empleado : MiembroDeLaComunidad
    {
        public string Puesto { get; set; }

        public Empleado(string nombre, int edad, string puesto) : base(nombre, edad)
        {
            Puesto = puesto;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Puesto: {Puesto}");
        }
    }

    // Subclase: Docente
    public class Docente : Empleado
    {
        public string Departamento { get; set; }

        public Docente(string nombre, int edad, string puesto, string departamento) : base(nombre, edad, puesto)
        {
            Departamento = departamento;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Departamento: {Departamento}");
        }
    }

    // Subclase: Administrador
    public class Administrador : Docente
    {
        public string AreaAdministrativa { get; set; }

        public Administrador(string nombre, int edad, string puesto, string departamento, string areaAdministrativa) : base(nombre, edad, puesto, departamento)
        {
            AreaAdministrativa = areaAdministrativa;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Área Administrativa: {AreaAdministrativa}");
        }
    }

    // Subclase: Maestro
    public class Maestro : Docente
    {
        public string Materia { get; set; }

        public Maestro(string nombre, int edad, string puesto, string departamento, string materia) : base(nombre, edad, puesto, departamento)
        {
            Materia = materia;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Materia: {Materia}");
        }
    }

    // Subclase: Administrativo
    public class Administrativo : Empleado
    {
        public string AreaAdministrativa { get; set; }

        public Administrativo(string nombre, int edad, string puesto, string areaAdministrativa) : base(nombre, edad, puesto)
        {
            AreaAdministrativa = areaAdministrativa;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Área Administrativa: {AreaAdministrativa}");
        }
    }

    // Subclase: Estudiante
    public class Estudiante : MiembroDeLaComunidad
    {
        public string Carrera { get; set; }

        public Estudiante(string nombre, int edad, string carrera) : base(nombre, edad)
        {
            Carrera = carrera;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Carrera: {Carrera}");
        }
    }

    // Subclase: ExAlumno
    public class ExAlumno : MiembroDeLaComunidad
    {
        public int AñoGraduacion { get; set; }

        public ExAlumno(string nombre, int edad, int añoGraduacion) : base(nombre, edad)
        {
            AñoGraduacion = añoGraduacion;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Año de Graduación: {AñoGraduacion}");
        }
    }

    // Ejemplo de uso
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
