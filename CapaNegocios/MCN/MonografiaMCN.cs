using CapaDatos1;
using CapaNegocios.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.MCN
{
    public class MonografiaMCN
    {
        private readonly dbmonografiasEntities db;

        public MonografiaMCN()
        {
            db = new dbmonografiasEntities();
        }

        public MonografiaDto BuscarMonografia(int ID)
        {
            return (from m in db.Monografia where m.Id == ID
                    select new MonografiaDto
                    {
                        Id = m.Id,
                        Titulo = m.Titulo,
                        Univesidad = m.Universidad
                    }).FirstOrDefault();
        }

        public bool InsertarMonografia(MonografiaDto mono)
        {
            try
            {
                Monografia NewMono = new Monografia()
                {
                    Id = mono.Id,
                    Titulo = mono.Titulo,
                    Universidad = mono.Univesidad
                };

                db.Monografia.Add(NewMono);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<MonografiaDto> ListarMonografias()
        {
            return db.Monografia.Select(M => new MonografiaDto
            {
                Id = M.Id,
                Titulo = M.Titulo,
                Univesidad = M.Universidad
            }).ToList();
        }



        public bool EliminarMonografia(int ID)
        {
            try
            {
                Monografia mono = db.Monografia.Find(ID);
                db.Monografia.Remove(mono);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        /*------------------------------  Busquedas por categoria ---------------------------------*/
        
        public List<MonografiaDto> BuscarMonografiaPorID(int ID)
        {
            return (from m in db.Monografia
                    where m.Id == ID
                    select new MonografiaDto
                    {
                        Id = m.Id,
                        Titulo = m.Titulo,
                        Univesidad = m.Universidad
                    }).ToList();
        }
        public List<MonografiaDto> BuscarMonografiaPorTitulo(string titulo)
        {
            return (from m in db.Monografia
                    where m.Titulo == titulo
                    select new MonografiaDto
                    {
                        Id = m.Id,
                        Titulo = m.Titulo,
                        Univesidad = m.Universidad
                    }).ToList();
        }
        public List<MonografiaDto> BuscarMonografiaPorUniver(string UNI)
        {
            return (from m in db.Monografia
                    where m.Universidad == UNI
                    select new MonografiaDto
                    {
                        Id = m.Id,
                        Titulo = m.Titulo,
                        Univesidad = m.Universidad
                    }).ToList();
        }

        public List<MonografiaDto> BuscarMonografiaPorAutor(string nomAut)
        {
            return (from M in db.Monografia
                    join AM in db.AutorMonografia on M.Id equals AM.IdMonografia
                    join A in db.Autor on AM.IdAutor equals A.Id
                    where A.Nombre == nomAut
                    select new MonografiaDto()
                    {
                        Id = M.Id,
                        Titulo = M.Titulo,
                        Univesidad = M.Universidad
                    }).ToList();
        }
    }
}