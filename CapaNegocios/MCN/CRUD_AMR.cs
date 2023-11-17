using CapaDatos1;
using CapaNegocios.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.MCN
{
    public class CRUD_AMR
    {
        AutorMCN metodosAutor = new AutorMCN();
        AutorMonografiaMCN metodosAM = new AutorMonografiaMCN();
        MonografiaMCN metodosMonografia = new MonografiaMCN();

        //metodos de los autores
        public AutorDto BuscarAutor(int ID)
        {
            return metodosAutor.BuscarAutor(ID);
        }

        public bool InsertarAutor(AutorDto autor)
        {
            return metodosAutor.InsertarAutor(autor);
        }

        public List<AutorDto> ListarAutores()
        {
            return metodosAutor.ListarAutores();
        }

        public List<AutorDto> AutoresDeUnaMonografia(int ID)
        {
            return metodosAutor.AutoresDeUnaMonografia(ID);
        }

        public bool EliminarAutores(int ID)
        {
            return metodosAutor.EliminarAutores(ID);
        }

        //metodos de la monografia
        public MonografiaDto BuscarMonografia(int ID)
        {                                             
            return metodosMonografia.BuscarMonografia(ID);
        }
        public List<MonografiaDto> BuscarMonografiaPorId(int ID)
        {
            return metodosMonografia.BuscarMonografiaPorID(ID);
        }

        public bool InsertarMonografia(MonografiaDto mono)
        {
            return metodosMonografia.InsertarMonografia(mono);
        }

        public List<MonografiaDto> ListarMonografias()
        {
            return metodosMonografia.ListarMonografias();
        }

        public bool EliminarMonografia(int ID)
        {
            return metodosMonografia.EliminarMonografia(ID);
        }

        //metodos de la relacion entre los dos
        public bool InsertarLlaves(int IDAutor, int IDMono)
        {
            return metodosAM.InsertarLlaves(IDAutor, IDMono);
        }

        public bool EliminarLlaves(int IdMono)
        {
            return metodosAM.EliminarLlaves(IdMono);
        }

        /*--------------- Busquedas por categoria -------------------*/

        public List<MonografiaDto> BuscarMonografiaPorID(int ID)
        {
            return metodosMonografia.BuscarMonografiaPorID(ID);
        }

        public List<MonografiaDto> BuscarMonografiaPorTitulo(string titulo)
        {
            return metodosMonografia.BuscarMonografiaPorTitulo(titulo);
        }

        public List<MonografiaDto> BuscarMonografiaPorUniver(string UNI)
        {
            return metodosMonografia.BuscarMonografiaPorUniver(UNI);
        }

        public List<MonografiaDto> BuscarMonografiaPorAutor(string nomAut)
        {
            return metodosMonografia.BuscarMonografiaPorAutor(nomAut);
        }

        //metodo para reiniciar la clase estatica
        public void ReiniciarClase()
        {
            Estaticas.listaIdTemp.Clear();
            Estaticas.listaAutoresTemp.Clear();
            Estaticas.ContadorEstudiante = 0;
            Estaticas.ContadorProfesor = 0;
        }
    }
}
