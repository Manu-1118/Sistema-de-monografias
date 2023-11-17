using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.DTO
{
    public class PrestamosDto
    {
        public int Id { get; set; }
        public int IdMonografia { get; set; }
        public int IdLector { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string Nota { get; set; }
    }
}
