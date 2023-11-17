using CapaDatos1;
using CapaNegocios.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.MCN
{
    public class AutorMCN
    {
        private readonly dbmonografiasEntities db;

        public AutorMCN()
        {
            db = new dbmonografiasEntities();
        }

        public AutorDto BuscarAutor(int ID)
        {
            return (from a in db.Autor where a.Id == ID
                    select new AutorDto
                    {
                        Id = a.Id,
                        Nombres = a.Nombre,
                        Apellidos = a.Apellido,
                        Rol = a.rol
                    }).FirstOrDefault();
        }

        public bool InsertarAutor(AutorDto autor)
        {
            try
            {
                Autor NewAutor = new Autor()
                {
                    Id= autor.Id,
                    Nombre = autor.Nombres,
                    Apellido = autor.Apellidos,
                    rol = autor.Rol
                };

                db.Autor.Add(NewAutor);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<AutorDto> ListarAutores()
        {
            return db.Autor.Select(A => new AutorDto
            {
                Id = A.Id,
                Nombres = A.Nombre,
                Apellidos = A.Apellido,
                Rol = A.rol
            }).ToList();
        }
        public List<AutorDto> AutoresDeUnaMonografia(int ID)
        {
            return (from M in db.Monografia
                    join AM in db.AutorMonografia on M.Id equals AM.IdMonografia
                    join A in db.Autor on AM.IdAutor equals A.Id
                    where M.Id == ID
                    select new AutorDto()
                    {
                        Id = A.Id,
                        Nombres = A.Nombre,
                        Apellidos = A.Apellido,
                        Rol = A.rol
                    }).ToList();
        }

        public bool EliminarAutores(int ID)
        {
            try
            {
                Autor aut = db.Autor.Find(ID);
                db.Autor.Remove(aut);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //public bool AgregarRetraso(int Id)
        //{
        //    try
        //    {

        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
    }
}
