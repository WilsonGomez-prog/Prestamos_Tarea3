using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Prestamos_Tarea3.DAL;
using Prestamos_Tarea3.Entidades;


namespace Prestamos_Tarea3
{
    public class PrestamoBLL
    {
        /// <summary>
        /// Permite insertar o modificar una entidad(Prestamo) en la base de datos.
        /// </summary>
        /// <param name = "prestamo"> Es la entidad(prestamo) que se desea Guardar.</param>
        public static bool Guardar(Prestamo prestamo)
        {
            if(!Existe(prestamo.PrestamoId))
            {
                return Insertar(prestamo);
            }
            else
            {
                return Modificar(prestamo);
            }
        }

        /// <summary>
        /// Permite buscar una entidad(Prestamo) en la base de datos.
        /// </summary>
        /// <param name = "prestamoId"> Es el ID de la entidad(prestamo) que se desea encontrar.</param>
        public static Prestamo Buscar(int prestamoId)
        {
            Prestamo prestamo;
            Contexto contexto = new Contexto();

            try
            {
                prestamo = contexto.Prestamo.Find(prestamoId);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return prestamo;
        }

        /// <summary>
        /// Permite eliminar una entidad(Prestamo) en la base de datos.
        /// </summary>
        /// <param name = "prestamoId"> Es el ID de la entidad(prestamo) que se desea eliminar de la base de datos.</param>
        public static bool Eliminar(int prestamoId)
        {
            bool eliminado = false;
            Contexto contexto = new Contexto();

            try
            {
                var prestamo = contexto.Prestamo.Find(prestamoId);

                if (prestamo != null)
                {
                    contexto.Prestamo.Remove(prestamo);
                    eliminado = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return eliminado;
        }

        /// <summary>
        /// Permite insertar una entidad(Prestamo) en la base de datos.
        /// </summary>
        /// <param name = "prestamo"> Es la entidad(prestamo) que se desea insertar.</param>
        private static bool Insertar(Prestamo prestamo)
        {
            bool insertado = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Add(prestamo);
                var cliente = contexto.Persona.Find(prestamo.PersonaId).Balance += prestamo.Monto + prestamo.Mora;
                insertado = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return insertado;
        }

        /// <summary>
        /// Permite modificar una entidad(Prestamo) en la base de datos.
        /// </summary>
        /// <param name = "prestamo"> Es la entidad(prestamo) que se desea modificar.</param>
        private static bool Modificar(Prestamo prestamo)
        {
            bool modificado = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(prestamo).State = EntityState.Modified;
                var cliente = contexto.Persona.Find(prestamo.PersonaId);
                cliente.Balance = 0;
                cliente.Balance += prestamo.Monto + prestamo.Mora;
                modificado = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return modificado;
        }

        /// <summary>
        /// Permite verificar la existencia de una entidad(prestamo) en la base de datos.
        /// </summary>
        /// <param name = "prestamoId"> Es el ID de la entidad(prestamo) de la cual se desea verificar la existencia.</param>
        public static bool Existe(int prestamoId)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Prestamo.Any(e => e.PrestamoId == prestamoId);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        /// <summary>
        /// Permite extraer una lista con las entidades(prestamos) que posee la base de datos basados en un criterio.
        /// </summary>
        /// <param name = "criterio"> Es el criterio por el cual va a ser ordenada o extraida la lista.</param>
        public static List<Prestamo> GetList(Expression<Func<Prestamo, bool>> criterio)
        {
            List<Prestamo> lista = new List<Prestamo>();
            Contexto contexto = new Contexto();
            
            try
            {
                lista = contexto.Prestamo.Where(criterio).ToList();
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

        /// <summary>
        /// Permite extraer una lista con las entidades(prestamos) que posee la base de datos.
        /// </summary>
        public static List<Prestamo> GetList()
        {
            List<Prestamo> lista = new List<Prestamo>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Prestamo.ToList();
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