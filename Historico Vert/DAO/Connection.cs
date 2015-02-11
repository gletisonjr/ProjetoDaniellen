using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Historico_Vert.DAO
{
    class Connection
    {
        public Connection() { }

       /* public SQLConnection conn { get; private set; }
        public SQCommand cmd { get; set; }
        public String statement { get; set; }

        public Connection()
        {
            this.conn = null;
            this.cmd = null;
            this.statement = null;
        }

        public bool ConnectReadOnly()
        {
            String basePath = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath));
            String connStatement = "Data Source = "+basePath+"\\BD\\Clinica.db;Version = 3;Read Only = True;";
            
            try
            {
                conn = new SQLiteConnection(connStatement);
                conn.Open();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados!\n"+err.ToString()+"\n"+connStatement,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }

        public bool Connect()
        {
            String basePath = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath));
            String connStatement = "Data Source = "+basePath+"\\BD\\Clinica.db;Version = 3;";

            try
            {
                conn = new SQLiteConnection(connStatement);
                conn.Open();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados!\n" + err.ToString() + "\n" + connStatement, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }*/



    }
}
