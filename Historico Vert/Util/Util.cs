using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using Historico_Vert.Data;
using EntityObject = System.Data.Objects.DataClasses.EntityObject;

namespace Historico_Vert.Util
{
    public static class Util
    {
        public static void CarregarAutoComplete<T>(this TextBox textBox, Expression<Func<T, String>> selecao) where T : EntityObject
        {
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox.AutoCompleteCustomSource.Clear();
            textBox.AutoCompleteCustomSource.AddRange(
                DataContext.AutoCompleteLista(selecao));
        }

        public static void CarregarAutoComplete<T>(this TextBox textBox, Expression<Func<T, String>> selecao, Expression<Func<T, bool>> predicate) where T : EntityObject
        {
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox.AutoCompleteCustomSource.Clear();
            textBox.AutoCompleteCustomSource.AddRange(
                DataContext.AutoCompleteLista(predicate, selecao));
        }
    }
}
