using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Prestamos_Tarea3.DAL;
using Prestamos_Tarea3.Entidades;

namespace Prestamos_Tarea3.BLL
{
    class MorasBLL
    {
        public static bool Guardar(Moras mora)
        {
            bool guardado = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Moras.Add(mora) != null)
                {
                    guardado = contexto.SaveChanges() > 0;
                }

                List<MorasDetalle> DetallesModif = mora.DetalleMora;
                foreach (MorasDetalle mr in DetallesModif)
                {
                    Prestamo prestamo = PrestamoBLL.Buscar(mr.PrestamoId);
                    prestamo.Mora += mr.Valor;
                    PrestamoBLL.Guardar(prestamo);
                }
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return guardado;
        }

        public static bool Modificar(Moras mora)
        {
            bool modificado = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete from MorasDetalle where MoraId = {mora.MoraId}");

                foreach(var anterior in mora.DetalleMora)
                {
                    contexto.Entry(anterior).State = EntityState.Added;
                }

                List<MorasDetalle> Detalles = Buscar(mora.MoraId).DetalleMora;
                foreach(MorasDetalle mr in Detalles)
                {
                    Prestamo prestamo = PrestamoBLL.Buscar(mr.PrestamoId);
                    prestamo.Mora -= mr.Valor;
                    PrestamoBLL.Guardar(prestamo);
                }

                List<MorasDetalle> DetallesModif = mora.DetalleMora;
                foreach (MorasDetalle mr in DetallesModif)
                {
                    Prestamo prestamo = PrestamoBLL.Buscar(mr.PrestamoId);
                    prestamo.Mora += mr.Valor;
                    PrestamoBLL.Guardar(prestamo);
                }

                contexto.Entry(mora).State = EntityState.Modified;
                modificado = contexto.SaveChanges() > 0;
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return modificado;
        }

        public static bool Eliminar(int moraId)
        {
            bool eliminado = false;
            Contexto contexto = new Contexto();

            try
            {
                var eliminar = contexto.Moras.Find(moraId);
                contexto.Entry(eliminar).State = EntityState.Deleted;

                eliminado = contexto.SaveChanges() > 0;
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return eliminado;
        }

        public static Moras Buscar(int moraId)
        {
            Contexto contexto = new Contexto();
            Moras moras = new Moras();

            try
            {
                moras = contexto.Moras.Include(x => x.DetalleMora).Where(p => p.MoraId == moraId).SingleOrDefault();
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return moras;
        }

        public static List<Moras> GetList(Expression<Func<Moras, bool>> moras)
        {
            List<Moras> lista = new List<Moras>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Moras.Where(moras).AsNoTracking().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}
