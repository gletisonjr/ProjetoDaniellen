using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Historico_Vert
{
      class FormControl
    {
         private Control.ControlCollection Controls;

         public FormControl()
         {
         }

         public FormControl(Control.ControlCollection Controls)
         {
             this.Controls = Controls;
         }

         public void ClearForm()
         {
             foreach (var item in Controls)
             {
                 var userControl = item as UserControl;

                 if (userControl != null)
                 {
                     userControl.Hide();
                     userControl.Dispose();
                 }
             }
         }

         public  void Show(UserControl control)
         {
             control.Location = new Point(15, 25);
             control.Show();
         }


    }
}
