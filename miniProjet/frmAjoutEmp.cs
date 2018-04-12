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
    public partial class frmAjoutEmp : Form
    {
        ConnexionBD obj = new ConnexionBD();
        public frmAjoutEmp()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void btnPersonalSave_Click(object sender, EventArgs e)
        {
            if (txtEmpname.Text == "")
            {
                MessageBox.Show("Entrer le nom Employee  !");
                txtEmpname.Focus();
            }
            else if (txtNatioanlity.Text == "")
            {
                MessageBox.Show("Entrer Nationalite Employee !");
                txtNatioanlity.Focus();
            }
            else if (cboGender.Text == "")
            {
                MessageBox.Show("Selectionner Genre !");
                cboGender.Focus();
            }
            else if (txtPanno.Text == "")
            {
                MessageBox.Show("Enter Telephone Employee  !");
                txtPanno.Focus();
            }
            else if (txtReligion.Text == "")
            {
                MessageBox.Show("Enter Religion Employee  !");
                txtReligion.Focus();
            }
            else if (cboBloodGroup.Text == "")
            {
                MessageBox.Show("Enter Group Sanguin Employee!");
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "insert into tblDetailPersonnel values('" + txtEmpid.Text + "','" + txtEmpname.Text + "','" + cboGender.Text + "','" + txtPanno.Text + "',@date,'" + txtNatioanlity.Text + "','" + txtReligion.Text + "','" + cboBloodGroup.Text + "')";
                    obj.com.Parameters.AddWithValue("@date", dtpDOB.Value);
                    obj.com.ExecuteNonQuery();
                    obj.com.Parameters.Clear();
                    MessageBox.Show("Detail Personnel a Bien Ajouté !");
                    grpPersonal.Visible = false;
                    grpContact.Visible = true;
                    txtAddress.Focus();
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
        private void fillId()
        {

            ConnexionBD obj = new ConnexionBD();
            obj.connect();
            obj.com.CommandText = "select COUNT (EmployeeId) from tblDetailPersonnel";
            int maxrow = (int)obj.com.ExecuteScalar();
            maxrow = maxrow + 1;
            txtEmpid.Text = maxrow.ToString();
            txtEmpIdContct.Text = maxrow.ToString();
            txtIdQualication.Text = maxrow.ToString();
            txtEmpIdJob.Text = maxrow.ToString();
            obj.con.Close();
        }

        private void frmAjoutEmp_Load(object sender, EventArgs e)
        {
            fillId();
        }
        public void clearAll()
        {
            txtAddress.Clear();
            txtBasicSalary.Clear();
            txtCity.Clear();
            txtContactNo.Clear();
            txtDegree.Clear();
            txtDepartment.Clear();
            txtDesignation.Clear();
            txtEmail.Clear();
            txtEmpid.Clear();
            txtEmpIdContct.Clear();
            txtEmpIdJob.Clear();
            txtEmpname.Clear();
            txtIdQualication.Clear();
            txtLeaves.Clear();
            txtNatioanlity.Clear();
            txtPanno.Clear();
            txtPassingYear.Clear();
            txtPercentage.Clear();
            txtReligion.Clear();
            txtState.Clear();
            txtUniversity.Clear();
            txtZipCode.Clear();

        }
        private void btnContactSubmit_Click_1(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Entrer Adresse !!");
                txtAddress.Focus();
            }
            else if (txtCity.Text == "")
            {
                MessageBox.Show("Entrer Ville !!");
                txtCity.Focus();
            }
            else if (txtContactNo.Text == "")
            {
                MessageBox.Show("Entrer Contact Num !!");
                txtContactNo.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Entrer Email Address !!");
                txtEmail.Focus();
            }
            else if (txtZipCode.Text == "")
            {
                MessageBox.Show("Entrer code postale !!");
                txtZipCode.Focus();
            }
            else if (txtState.Text == "")
            {
                MessageBox.Show("Entrer Region !!");
                txtState.Focus();
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "insert into tblContactDetail values('" + txtEmpIdContct.Text + "','" + txtAddress.Text + "','" + txtCity.Text + "','" + txtState.Text + "','" + txtZipCode.Text + "','" + txtContactNo.Text + "','" + txtEmail.Text + "')";
                    obj.com.ExecuteNonQuery();
                    MessageBox.Show("Details Contact a Bien Ajoute !!");
                    grpContact.Visible = false;
                    grpQualification.Visible = true;
                    txtDegree.Focus();
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

        private void btnQualificationSubmit_Click(object sender, EventArgs e)
        {
            if (txtDegree.Text == "")
            {
                MessageBox.Show("Entrer nom Diplome !!");
                txtDegree.Focus();
            }
            else if (txtUniversity.Text == "")
            {
                MessageBox.Show("Enter Universite  !!");
                txtUniversity.Focus();
            }
            else if (txtPercentage.Text == "")
            {
                MessageBox.Show("Entrer Marque Diplome !!");
                txtPercentage.Focus();
            }
            else if (txtPassingYear.Text == "")
            {
                MessageBox.Show("");
                txtPassingYear.Focus();
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "insert into tblDetailQualification values('" + txtIdQualication.Text + "','" + txtDegree.Text + "','" + txtUniversity.Text + "','" + txtPassingYear.Text + "','" + txtPercentage.Text + "')";
                    obj.com.ExecuteNonQuery();
                    MessageBox.Show("Details Qualification a Bien Ajoute!!");
                    grpQualification.Visible = false;
                    grpJobDetails.Visible = true;
                    txtDesignation.Focus();
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

        private void btnJobSubmit_Click(object sender, EventArgs e)
        {
            if (txtDesignation.Text == "")
            {
                MessageBox.Show("Entrer Designation Employee");
                txtDesignation.Focus();
            }
            else if (txtLeaves.Text == "")
            {
                MessageBox.Show("Entrer le nombre conge par mois");
                txtLeaves.Focus();
            }
            else if (txtDepartment.Text == "")
            {
                MessageBox.Show("Enter Deparetment !!");
                txtDepartment.Focus();
            }
            else if (txtBasicSalary.Text == "")
            {
                MessageBox.Show("Entrer salaire base !!");
                txtBasicSalary.Focus();
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "insert into tblDetailTravail values('" + txtEmpIdJob.Text + "',@date,'" + txtDepartment.Text + "','" + txtDesignation.Text + "','" + txtLeaves.Text + "','" + txtBasicSalary.Text + "')";
                    obj.com.Parameters.AddWithValue("@date", dtpJoiningDate.Value);
                    obj.com.ExecuteNonQuery();
                    obj.com.Parameters.Clear();
                    MessageBox.Show("Details Travail a Bien Ajoute");
                    grpJobDetails.Visible = false;
                    grpPersonal.Visible = true;

                    clearAll();
                    txtEmpname.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    obj.con.Close();
                    fillId();
                    MessageBox.Show("les information de ce nouveau employe a bien a ajoute");
                    this.Close();
                }
            }
        }
    }

}
