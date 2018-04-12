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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            CenterToScreen();
        }


        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Employee1 obj = new Employee1();
            //obj.selectReport("rptEmployee");
          //  obj.Show();
        }

        private void Ajouter_Employe(object sender, EventArgs e)
        {
          frmAjoutEmp fae = new frmAjoutEmp();
            fae.ShowDialog();
         }

        private void Modifier_Employe(object sender, EventArgs e)
        {
         frmModifEmp fue = new frmModifEmp();
         fue.ShowDialog();
        }

        private void Presence_Employe(object sender, EventArgs e)
        {
         frmPresncEmp obj = new frmPresncEmp();
           obj.ShowDialog();
        }

        private void Fiche_de_Paie(object sender, EventArgs e)
        {
            frmFichePaie obj = new frmFichePaie();
             obj.ShowDialog();
        }

        private void Ajouter_user(object sender, EventArgs e)
        {
           frmAjoutUser obj = new frmAjoutUser();
            obj.ShowDialog();
        }

        private void Modifier_user(object sender, EventArgs e)
        {
           frmModifUser obj = new frmModifUser();
           obj.ShowDialog();
        }

        private void Chercher_Employe(object sender, EventArgs e)
        {
            frmRechrchEmp obj = new frmRechrchEmp();
           obj.ShowDialog();
        }

        private void Logout(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Vous etes sur Monsieur?", "Gestion de paie", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                frmLogin fl = new frmLogin();
                fl.Show();
            }
        }

    }
}
