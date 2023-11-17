using CapaDatos1;
using CapaNegocios.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.MCN
{
    public class PrestamosMCN
    {
        private readonly dbmonografiasEntities db;
        public PrestamosMCN()
        {
            db = new dbmonografiasEntities();
        }
        public bool InsertarDevolucion(PrestamosDto pres, int IdMono)
        {
            try
            {
                var Buscado = db.Prestamo.Where(p => p.IdMonografia == IdMono).FirstOrDefault();
                if (Buscado == null)
                    return false;

                Buscado.Id = Buscado.Id;
                Buscado.IdMonografia = Buscado.IdMonografia;
                Buscado.IdLector = Buscado.IdLector;
                Buscado.FechaPrestamo = Buscado.FechaPrestamo;
                Buscado.FechaDevolucion = Buscado.FechaDevolucion;
                Buscado.FechaEntrega = pres.FechaEntrega;
                Buscado.Nota = pres.Nota;
                db.Entry(Buscado).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertarPrestamo(PrestamosDto pres, int IDmono, int IDlec)
        {
            try
            {
                Prestamo NewPres = new Prestamo()
                {
                    IdMonografia = IDmono,
                    IdLector = IDlec,
                    FechaPrestamo = pres.FechaPrestamo,
                    FechaDevolucion = pres.FechaDevolucion,
                };

                db.Prestamo.Add(NewPres);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<PrestamosDto> BuscarPorIdMono(int Id)
        {
            return (from M in db.Monografia
                    join P in db.Prestamo on M.Id equals P.IdMonografia
                    where M.Id == Id
                    select new PrestamosDto
                    {
                        Id = P.Id,
                        IdMonografia = P.IdMonografia,
                        IdLector = P.IdLector,
                        FechaPrestamo = P.FechaPrestamo,
                        FechaDevolucion = P.FechaDevolucion,
                        FechaEntrega = P.FechaEntrega,
                        Nota = P.Nota
                    }).ToList();
        }
        public List<PrestamosDto> ListarPrestamos()
        {
            return db.Prestamo.Select(P => new PrestamosDto
            {
                Id = P.Id,
                IdLector = P.IdLector,
                IdMonografia = P.IdMonografia,
                FechaPrestamo = P.FechaPrestamo,
                FechaDevolucion = P.FechaDevolucion,
                FechaEntrega = P.FechaEntrega,
                Nota = P.Nota
            }).ToList();
        }

        /*----------------------- Metodos de busqueda por categoria --------------------------------------*/
        public List<PrestamosDto> BuscarPrestamoPorID(int ID)
        {
            return (from P in db.Prestamo
                    where P.Id == ID
                    select new PrestamosDto
                    {
                        Id = P.Id,
                        IdMonografia = P.IdMonografia,
                        IdLector = P.IdLector,
                        FechaPrestamo = P.FechaPrestamo,
                        FechaDevolucion = P.FechaDevolucion,
                        FechaEntrega = P.FechaEntrega,
                        Nota = P.Nota
                    }).ToList();
        }

        public List<PrestamosDto> BuscarPrestamoPorIdMonografia(int IDMono)
        {
            return (from P in db.Prestamo
                    where P.IdMonografia == IDMono
                    select new PrestamosDto
                    {
                        Id = P.Id,
                        IdMonografia = P.IdMonografia,
                        IdLector = P.IdLector,
                        FechaPrestamo = P.FechaPrestamo,
                        FechaDevolucion = P.FechaDevolucion,
                        FechaEntrega = P.FechaEntrega,
                        Nota = P.Nota
                    }).ToList();
        }

        public List<PrestamosDto> BuscarPrestamoPorIdLector(int IDLec)
        {
            return (from P in db.Prestamo
                    where P.IdLector == IDLec
                    select new PrestamosDto
                    {
                        Id = P.Id,
                        IdMonografia = P.IdMonografia,
                        IdLector = P.IdLector,
                        FechaPrestamo = P.FechaPrestamo,
                        FechaDevolucion = P.FechaDevolucion,
                        FechaEntrega = P.FechaEntrega,
                        Nota = P.Nota
                    }).ToList();
        }
    }
}
