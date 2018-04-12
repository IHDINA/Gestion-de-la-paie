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
    public partial class frmLogin : Form
    {
        ConnexionBD obj = new ConnexionBD();

        public frmLogin()
        {
            InitializeComponent();
        }

     
       
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click_1(sender, e);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtUname.Text == "")
            {
                MessageBox.Show(" ENTREZ LE NOM D'UTILISATEUR !!");
                txtUname.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("ENTREZ LE MOT DE PASSE !!");
                txtPassword.Focus();
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "select * from tblLogin where Username='" + txtUname.Text + "' and Password='" + txtPassword.Text + "'";

                    obj.dr = obj.com.ExecuteReader();
                    if (obj.dr.Read())
                    {

                        string role = obj.dr[2].ToString();
                        if (role == "admin")
                        {
                            MessageBox.Show("Bienvenu,Monsieur Admin !!!", "Gestion de la Paie");
                            this.Hide();
                            frmAdmin fam = new frmAdmin();
                            fam.Show();
                        }
                        else
                        {
                            MessageBox.Show("Bienvenue votre session !!", "Gestion de la Paie");
                            this.Hide();
                            // frmUserMdi fum = new frmUserMdi();
                            //  fum.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erreur de Connexion !!");
                        txtUname.Clear();
                        txtPassword.Clear();
                        txtUname.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    obj.con.Close();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
