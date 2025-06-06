using System;

namespace ComunidadEducativa
{
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
}