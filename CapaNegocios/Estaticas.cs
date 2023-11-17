using CapaNegocios.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public static class Estaticas
    {
        public static int ContadorProfesor = 0;
        public static int ContadorEstudiante = 0;
        public static List<AutorDto> listaAutoresTemp = new List<AutorDto>();
        public static List<int> listaIdTemp = new List<int>();
        //public static List<AutorDto> autores = new List<AutorDto>();
    }
}
