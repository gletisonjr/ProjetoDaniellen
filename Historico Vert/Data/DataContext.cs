using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Historico_Vert.Data
{
    public static class DataContext
    {
        /// <summary>
        /// Método responsável por Salvar uma entidade no banco de dados.
        /// </summary>
        /// <typeparam name="T">Um tipo que seja possível persistir no modelo do entity</typeparam>
        /// <param name="persistentObject">Um objeto a ser persistido.</param>
        /// <returns>Mensagem de retorno.</returns>
        public static String Save<T>(T persistentObject)
        {
            if (persistentObject == null)
                return "Não foi possível salvar. Os campos estão vazios";


            using (var context = new clinicaEntities())
            {
                // Obtem o nome em String do tipo da Entidade.
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
