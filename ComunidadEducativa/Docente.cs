using System;

namespace ComunidadEducativa
{
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
}