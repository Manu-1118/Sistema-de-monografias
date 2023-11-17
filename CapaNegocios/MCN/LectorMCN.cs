using CapaDatos1;
using CapaNegocios.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.MCN
{
    public class LectorMCN
    {
        private readonly dbmonografiasEntities db;
        public LectorMCN()
        {
            db = new dbmonografiasEntities();
        }
        public LectorDto BuscarLector(int Id)
        {
            return (from l in db.Lector where l.Id == Id
                    select new LectorDto
                    {
                        Id = l.Id,
                        Nombres = l.Nombres,
                        Apellidos = l.Apellidos
                    }).FirstOrDefault();
        }
        public bool InsertarLector(LectorDto lector)
        {
            try
            {
                Lector NewLector = new Lector()
                {
                    Id = lector.Id,
                    Nombres = lector.Nombres,
                    Apellidos = lector.Apellidos
                };

                db.Lector.Add(NewLector);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ActualizarLector(LectorDto lectorActual)
        {
            try
            {
                Lector lec = db.Lector.Find(lectorActual.Id);

                if(lec is null)
                    return false;

                lec.Id = lectorActual.Id;
                lec.Nombres = lectorActual.Nombres;
                lec.Apellidos = lectorActual.Apellidos;
                //lec.CargoAtraso = lectorActual.CargoAtraso;

                db.Entry(lec).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EliminarLector(int Id)
        {
            try
            {
                Lector lec = db.Lector.Find(Id);

                if(lec is null)
                    return false;
                db.Lector.Remove(lec);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<LectorDto> ListaLectores()
        {
            return db.Lector.Select(L => new LectorDto
            {
                Id = L.Id,
                Nombres = L.Nombres,
                Apellidos = L.Apellidos,
                CargoAtraso = L.CargoAtraso
            }).ToList();
        }
    }
}
