using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace pryRaoEjxResolv
{
    internal class ClaseMedico
    {
        public string Nombre { get; set; }  

        public string Especialidad { get; set; }

        public int Matricula { get; set; }

        public string DevolverDatosMedico()
        {
            return "Nombre: " + Nombre + " Especialidad: " + Especialidad + " Matricula: " +Matricula;
        }
    }
}
