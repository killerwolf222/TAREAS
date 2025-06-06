using System;

namespace ComunidadEducativa
{
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
}