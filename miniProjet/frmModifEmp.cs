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
    public partial class frmModifEmp : Form
    {
        ConnexionBD obj = new ConnexionBD();
        public frmModifEmp()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void frmModifEmp_Load(object sender, EventArgs e)
        {
            fillCboId();
        }

        public void fillCboId()
        {
            try
            {
                obj.connect();
                obj.com.CommandText = "select * from tblDetailPersonnel";
                obj.dr = obj.com.ExecuteReader();
                while (obj.dr.Read())
                {
                    cboId.Items.Add(obj.dr[0].ToString());
                }
            }
            catch
            {
            }
            finally
            {
                obj.con.Close();
            }
        }

        private void btnPersonalView_Click1(object sender, EventArgs e)
        {
            if (cboId.Text == "")
            {
                MessageBox.Show("Selectionner Employee Id !!");
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "select * from tblDetailPersonnel where EmployeeId='" + cboId.Text + "'";
                    obj.dr = obj.com.ExecuteReader();
                    while (obj.dr.Read())
                    {
                        txtEmpid.Text = obj.dr[0].ToString();
                        txtEmpname.Text = obj.dr[1].ToString();
                        cboGender.Text = obj.dr[2].ToString();
                        txtPanno.Text = obj.dr[3].ToString();
                        dtpDOB.Text = obj.dr[4].ToString();
                        txtNatioanlity.Text = obj.dr[5].ToString();
                        txtReligion.Text = obj.dr[6].ToString();
                        cboBloodGroup.Text = obj.dr[7].ToString();
                    }
                    grpPersonal.Visible = true;
                    grpJobDetails.Visible = false;
                    grpContact.Visible = false;
                    grpQualification.Visible = false;
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

        private void btnPersonalSave_Click1(object sender, EventArgs e)
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
                    obj.com.CommandText = "update tblDetailPersonnel set EmployeNom='" + txtEmpname.Text + "',Genre='" + cboGender.Text + "',Telephone='" + txtPanno.Text + "',DateNaiss=@date,Nationalite='" + txtNatioanlity.Text + "',Religion='" + txtReligion.Text + "',GroupSanguin='" + cboBloodGroup.Text + "' where EmployeeId='" + txtEmpid.Text + "'";
                    obj.com.Parameters.AddWithValue("@date", dtpDOB.Value);
                    obj.com.ExecuteNonQuery();
                    obj.com.Parameters.Clear();
                    MessageBox.Show("Details Personnels a Bien Modifie !!");
                    grpPersonal.Visible = false;
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

        private void button1_Click1(object sender, EventArgs e)
        {
            if (cboId.Text == "")
            {
                MessageBox.Show("Selectionner Employee Id !!");
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "select * from tblContactDetail where EmployeeId='" + cboId.Text + "'";
                    obj.dr = obj.com.ExecuteReader();
                    while (obj.dr.Read())
                    {
                        txtEmpIdContct.Text = obj.dr[0].ToString();
                        txtAddress.Text = obj.dr[1].ToString();
                        txtCity.Text = obj.dr[2].ToString();
                        txtState.Text = obj.dr[3].ToString();
                        txtZipCode.Text = obj.dr[4].ToString();
                        txtContactNo.Text = obj.dr[5].ToString();
                        txtEmail.Text = obj.dr[6].ToString();
                    }
                    grpContact.Visible = true;
                    grpPersonal.Visible = false;
                    grpJobDetails.Visible = false;
                    grpQualification.Visible = false;
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

        private void btnContactSubmit_Click1(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Entrer Adresse  !!");
                txtAddress.Focus();
            }
            else if (txtCity.Text == "")
            {
                MessageBox.Show("Entrer Ville !!");
                txtCity.Focus();
            }
            else if (txtContactNo.Text == "")
            {
                MessageBox.Show("Entrer Contact Num!!");
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
                MessageBox.Show("Entrer Rgion !!");
                txtState.Focus();
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "update tblContactDetail set Adresse='" + txtAddress.Text + "',Ville='" + txtCity.Text + "',Region='" + txtCity.Text + "',CodePostal='" + txtZipCode.Text + "',ContactNo='" + txtContactNo.Text + "',Email='" + txtEmail.Text + "' where EmployeeId='" + txtEmpIdContct.Text + "'";
                    obj.com.ExecuteNonQuery();
                    MessageBox.Show("Details Contact a Bien Modifiee !!");
                    grpContact.Visible = false;
                }
                catch
                {
                }
                finally
                {
                    obj.con.Close();
                }
            }

        }

        private void button2_Click1(object sender, EventArgs e)
        {

            if (cboId.Text == "")
            {
                MessageBox.Show("Selectionner Employee Id !!");
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "select * from tblDetailQualification where EmployeeId='" + cboId.Text + "'";
                    obj.dr = obj.com.ExecuteReader();
                    while (obj.dr.Read())
                    {
                        txtIdQualication.Text = obj.dr[0].ToString();
                        txtDegree.Text = obj.dr[1].ToString();
                        txtUniversity.Text = obj.dr[2].ToString();
                        txtPassingYear.Text = obj.dr[3].ToString();
                        txtPercentage.Text = obj.dr[4].ToString();
                    }
                    grpQualification.Visible = true;
                    grpPersonal.Visible = false;
                    grpJobDetails.Visible = false;
                    grpContact.Visible = false;

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

        private void btnQualificationSubmit_Click1(object sender, EventArgs e)
        {
            if (txtDegree.Text == "")
            {
                MessageBox.Show("Entrer nom Diplome!!");
                txtDegree.Focus();
            }
            else if (txtUniversity.Text == "")
            {
                MessageBox.Show("Enter Universite !!");
                txtUniversity.Focus();
            }
            else if (txtPercentage.Text == "")
            {
                MessageBox.Show("Entrer Marque Diplome  !!");
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
                    obj.com.CommandText = "update tblDetailQualification set Diplome='" + txtDegree.Text + "',Universite='" + txtUniversity.Text + "',AnneePassage='" + txtUniversity.Text + "',MarqueDip='" + txtPassingYear.Text + "' where EmployeeId='" + txtIdQualication.Text + "'";
                    obj.com.ExecuteNonQuery();
                    MessageBox.Show("Details Qualification a Bien Modifiee !!");
                    grpQualification.Visible = false;

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

        private void button3_Click1(object sender, EventArgs e)
        {

            if (cboId.Text == "")
            {
                MessageBox.Show("Selectionner Employee Id !!");
            }
            else
            {
                try
                {
                    obj.connect();
                    obj.com.CommandText = "select * from tblDetailTravail where EmployeeId='" + cboId.Text + "'";
                    obj.dr = obj.com.ExecuteReader();
                    while (obj.dr.Read())
                    {
                        txtEmpIdJob.Text = obj.dr[0].ToString();
                        dtpDOB.Text = obj.dr[1].ToString();
                        txtDepartment.Text = obj.dr[2].ToString();
                        txtDesignation.Text = obj.dr[3].ToString();
                        txtLeaves.Text = obj.dr[4].ToString();
                        txtBasicSalary.Text = obj.dr[5].ToString();
                    }
                    grpJobDetails.Visible = true;
                    grpPersonal.Visible = false;

                    grpContact.Visible = false;
                    grpQualification.Visible = false;
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

        private void btnJobSubmit_Click1(object sender, EventArgs e)
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
                    obj.com.CommandText = "update tblDetailTravail set DateEntree=@date,Departement='" + txtDepartment.Text + "',Designation='" + txtDesignation.Text + "',JrConge='" + txtLeaves.Text + "',SalaireBase='" + txtBasicSalary.Text + "' where EmployeeId='" + txtEmpIdJob.Text + "'";
                    obj.com.Parameters.AddWithValue("@date", dtpJoiningDate.Value);
                    obj.com.ExecuteNonQuery();
                    obj.com.Parameters.Clear();
                    MessageBox.Show("Details Travail a Bien Modifiee!!");
                    grpJobDetails.Visible = false;
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
