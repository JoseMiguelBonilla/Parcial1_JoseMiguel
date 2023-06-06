using Parcial1_JoseMiguel.Models;
using Microsoft.EntityFrameworkCore;
using Parcial1_JoseMiguel.DAL;

namespace Parcial1_JoseMiguel.BLL
{
    public class IngresosBLL 
    {
        private readonly Contexto _contexto;
        Ingresos Ingresos = new Ingresos ();

        public  IngresosBLL (Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Guardar (Ingresos Ingresos)
        {
            if(!Existe(Ingresos.IngresoId))
                return Insertar(Ingresos);
                else 
                return Modificar(Ingresos);
        }
        
        public bool Existe (int IngresoId)
        {
            return _contexto.Ingresos.Any(s => s.IngresoId == IngresoId);
        }

        public bool Insertar (Ingresos Ingresos)
        {
            _contexto.Ingresos.Add(Ingresos);
            int cantidad = _contexto.SaveChanges();

            return cantidad > 0;
        }
       
       public bool Modificar (Ingresos Ingresos)
       {
        _contexto.Update(Ingresos);
        int cantidad = _contexto.SaveChanges();

        return cantidad > 0;
       }

       public bool Eliminar (Ingresos Ingresos)
       {
        _contexto.Remove(Ingresos);
        int cantidad = _contexto.SaveChanges();

        return cantidad > 0;
       }

       public Ingresos Buscar (int IngresoId)
       {
            return _contexto.Ingresos
            .AsNoTracking()
            .FirstOrDefault(s => s.IngresoId == IngresoId);

       }

       

    }
}