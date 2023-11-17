using CapaDatos1;
using CapaNegocios.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.MCN
{
    public class AutorMonografiaMCN
    {
        private readonly dbmonografiasEntities db;

        public AutorMonografiaMCN()
        {
            db = new dbmonografiasEntities();
        }
        public bool InsertarLlaves(int IdAutor, int IdMono)
        {
            try
            {
                AutorMonografia autorMono = new AutorMonografia()
                {
                    IdAutor = IdAutor,
                    IdMonografia = IdMono
                };

                db.AutorMonografia.Add(autorMono);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarLlaves(int IdMono)
        {
            try
            { 
                var Eliminar = (from M in db.Monografia
                                join AM in db.AutorMonografia on M.Id equals AM.IdMonografia
                                where M.Id == IdMono
                                select new AutorMonografia
                                {
                                    Id = AM.Id,
                                    IdAutor = AM.IdAutor,
                                    IdMonografia = AM.IdMonografia
                                }).ToList();
                //var Eliminar = (from M in db.Monografia
                //                join AM in db.AutorMonografia on M.Id equals AM.IdMonografia
                //                join A in db.Autor on AM.IdAutor equals A.Id
                //                where AM.IdMonografia == IdMono
                //                select new AutorMonografia
                //                {
                //                    Id = AM.Id,
                //                    IdAutor = A.Id,
                //                    IdMonografia = M.Id
                //                }).ToList();

                foreach(var value in Eliminar)
                {
                    db.AutorMonografia.Remove(value);
                }
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
