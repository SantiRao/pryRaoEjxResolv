using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryRaoEjxResolv
{
    internal class ClaseEspecialidad
    {
        public string Especialidad { get; set; }    

        public int CodigoEsp { get; set; }

        public string DevolverDatosEsp()
        {
            return Especialidad + CodigoEsp;
        }
    }
}
