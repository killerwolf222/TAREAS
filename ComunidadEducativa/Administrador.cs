using System;

namespace ComunidadEducativa
{
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
}