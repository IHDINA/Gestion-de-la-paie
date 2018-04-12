using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniProjet
{
    public partial class frmModifUser : Form
    {
        ConnexionBD obj = new ConnexionBD();
        public frmModifUser()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUname.Text == "")
            {
                MessageBox.Show("Entrez le Nom d'Utilisateur !");
                txtUname.Focus();
            }
            else if (txtOpass.Text == "")
            {
                MessageBox.Show("Entrez Ancien Mot de Passe !");
                txtOpass.Focus();
            }
            else if (txtNpass.Text == "")
            {
                MessageBox.Show("Enter Nouveau Mot de Passe !");
                txtNpass.Focus();
            }
            else
            {

                obj.connect();
                obj.com.CommandText = "select * from tblLogin where Username='" + txtUname.Text + "' and Password='" + txtOpass.Text + "'";
                obj.dr = obj.com.ExecuteReader();
                if (obj.dr.Read())
                {
                    obj.dr.Close();
                    //obj.com.CommandText = "update tblLogin set Password='" + txtNpass.Text + "' where Username='" + txtUname.Text + "'";
                    obj.com.CommandText = "exec ModifierUtilisateur " + txtUname.Text + "," + txtNpass.Text;
                    obj.com.ExecuteNonQuery();
                    MessageBox.Show("Mot de Passe a Bien Change!!");
                    txtUname.Clear();
                    txtNpass.Clear();
                    txtOpass.Clear();
                    txtUname.Focus();
                }
                else
                {
                    MessageBox.Show("Nom d'Utilisateur/Mot de Passe non Correcte!!");
                    txtUname.Clear();
                    txtNpass.Clear();
                    txtOpass.Clear();
                    txtUname.Focus();
                }
                obj.con.Close();


            }
        }

        private void txtNpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
