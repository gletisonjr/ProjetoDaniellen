using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using EntityObject = System.Data.Objects.DataClasses.EntityObject;

namespace Historico_Vert.Data
{
    public static class DataContext
    {
        /// <summary>
        /// Método responsável por Salvar uma entidade no banco de dados.
        /// </summary>
        /// <typeparam name="T">Um tipo que seja possível persistir no modelo do entity (herança de EntityObject)</typeparam>
        /// <param name="persistentObject">Um objeto a ser persistido.</param>
        /// <returns>Mensagem de retorno.</returns>
        public static String Save<T>(T persistentObject) where T : EntityObject
        {
            if (persistentObject == null)
                return "Não foi possível salvar. Os campos estão vazios";

            using (var context = new clinicaEntities())
            {
                var nomeEntidade = NomeEntidade<T>(context);

                if (persistentObject.EntityKey == null)
                    context.AddObject(nomeEntidade, persistentObject);
                else
                {
                    context.AttachTo(nomeEntidade, persistentObject);
                    context.ObjectStateManager.ChangeObjectState(persistentObject, EntityState.Modified);
                }

                context.SaveChanges();
            }

            return "Salvo com sucesso";
        }

        /// <summary>
        /// Método responsável por obter o nome de uma Entidade.
        /// </summary>
        /// <typeparam name="T">Um tipo que seja possível persistir no modelo do entity (herança de EntityObject)</typeparam>
        /// <param name="context">Contexto da base de dados Entity</param>
        /// <returns>O nome da entidade em String</returns>
        private static string NomeEntidade<T>(clinicaEntities context) where T : EntityObject
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

        /// <summary>
        /// Método responsável por deletar uma Entidade.
        /// </summary>
        /// <typeparam name="T">Um tipo que seja possível persistir no modelo do entity (herança de EntityObject)</typeparam>
        /// <param name="persistentObject">Um objeto a ser deletado</param>
        /// <returns>Mensagem de retorno ao excluir</returns>
        public static String Delete<T>(T persistentObject) where T : EntityObject
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

        public static String Delete<T>(Expression<Func<T, bool>> predicate) where T : EntityObject
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

        /// <summary>
        /// Método responsável por criar o AutoComplete das Entidades
        /// </summary>
        /// <typeparam name="T">Um tipo que seja possível persistir no modelo do entity (herança de EntityObject)</typeparam>
        /// <param name="predicate">Expressão lambda do tipo predicate. Lógica</param>
        /// <param name="selecao">Expressão lambda que retorne uma string</param>
        /// <returns>Lista de String com a propriedade/coluna do banco escolhida</returns>
        public static List<String> AutoCompleteLista<T>(Expression<Func<T, bool>> predicate, Expression<Func<T, String>> selecao) where T : EntityObject
        {
            using (var context = new clinicaEntities())
                return context.CreateQuery<T>(NomeEntidade<T>(context)).Where(predicate).Take(5).Select(selecao).ToList();
        }

        /// <summary>
        /// Método responsável por obter um registro de uma tabela.
        /// </summary>
        /// <typeparam name="T">Um tipo que seja possível persistir no modelo do entity (herança de EntityObject)</typeparam>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static T Obter<T>(Expression<Func<T, bool>> predicate) where T : EntityObject
        {
            using (var context = new clinicaEntities())
                return context.CreateQuery<T>(NomeEntidade<T>(context)).FirstOrDefault(predicate);

        }


    }
}
