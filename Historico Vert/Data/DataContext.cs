using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
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
                var nomeEntidade = NomeEntidade<T>(context);

                context.AddObject(nomeEntidade, persistentObject);
                context.SaveChanges();
            }

            return "Salvo com sucesso";
        }

        /// <summary>
        /// Método responsável por obter o nome de uma Entidade.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="context"></param>
        /// <returns></returns>
        private static string NomeEntidade<T>(clinicaEntities context)
        {
            // Obtem o nome em String do tipo da Entidade.
            String nomeEntidade = context.GetType().GetProperties().
                Single(
                    s =>
                        s.PropertyType.IsGenericType &&
                        typeof(IEnumerable<>).MakeGenericType(typeof(T)).IsAssignableFrom(s.PropertyType))
                .Name;

            return nomeEntidade;
        }


        public static String Delete<T>(T persistentObject)
        {
            if (persistentObject == null)
                return "Não foi possível realizar a exclusão deste registro";

            using (var context = new clinicaEntities())
            {
                context.DeleteObject(persistentObject);
                context.SaveChanges();
            }

            return "Deletado com sucesso";
        }

        public static String Delete<T>(Expression<Func<T, bool>> predicate)
        {
            using (var context = new clinicaEntities())
            {
                var deleteList = context.CreateQuery<T>(NomeEntidade<T>(context)).Where(predicate).ToList();

                if (!deleteList.Any())
                    return "Não há registros para deletar";

                context.DeleteObject(deleteList);
                context.SaveChanges();
            }

            return "Registro(s) deletados com sucesso";
        }


        public static List<String> AutoCompleteLista<T>(Expression<Func<T, bool>> predicate, Expression<Func<T, String>> selecao)
        {
            using (var context = new clinicaEntities())
                return context.CreateQuery<T>(NomeEntidade<T>(context)).Where(predicate).Take(5).Select(selecao).ToList();
        }


        public static T Obter<T>(Expression<Func<T, bool>> predicate)
        {
            using (var context = new clinicaEntities())
                return context.CreateQuery<T>(NomeEntidade<T>(context)).FirstOrDefault(predicate);
            
        }


    }
}
