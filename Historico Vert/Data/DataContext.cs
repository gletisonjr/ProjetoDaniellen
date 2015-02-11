using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Historico_Vert.Data
{
    public static class DataContext
    {

        public static String Save<T>(T persistentObject)
        {
            if (persistentObject == null)
                return "Não foi possível salvar.Os campos estão vazios";


            using (var context = new clinicaEntities())
            {
                String nomeEntidade = context.GetType().GetProperties().
                    Single(
                        s =>
                            s.PropertyType.IsGenericType &&
                            typeof (IEnumerable<>).MakeGenericType(typeof (T)).IsAssignableFrom(s.PropertyType))
                    .Name;

                context.AddObject(nomeEntidade, persistentObject);
                context.SaveChanges();

            }

            return "Salvo com sucesso";
        }

  
    }
}
