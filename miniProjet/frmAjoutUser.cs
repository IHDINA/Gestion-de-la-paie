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
    public partial class frmAjoutUser : Form
    {
        ConnexionBD obj = new ConnexionBD();
        public frmAjoutUser()
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
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Entrer le nom d'utilisateur!");
                txtUsername.Focus();
            }
            else if (txtPass1.Text == "")
            {
                MessageBox.Show("Entrez le mot de passe !");
                txtPass1.Focus();
            }
            else if (txtPass2.Text == "")
            {
                MessageBox.Show("Confirme mot de passe !");
                txtPass2.Focus();
            }
            else if (txtPass1.Text != txtPass2.Text)
            {
                MessageBox.Show("Retapez le mot de passe!!");
                txtPass2.Focus();
            }
            else
            {
                try
                {
                    obj.connect();
                    //obj.com.CommandText = "insert into tblLogin values('" + txtUsername.Text + "','" + txtPass1.Text + "','" + comboBox1.Text + "')";
                    obj.com.CommandText = " exec ajouterUtilisateur '" + txtUsername.Text + "','" + txtPass1.Text + "','" + comboBox1.Text + "'";
                    obj.com.ExecuteNonQuery();
                    MessageBox.Show("User a Bien Ajoute !!");
                    txtUsername.Clear();
                    txtPass1.Clear();
                    txtPass2.Clear();
                    txtUsername.Focus();
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
    }
}
