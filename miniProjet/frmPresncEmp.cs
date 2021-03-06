﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace miniProjet
{
    public partial class frmPresncEmp : Form
    {
        ConnexionBD obj = new ConnexionBD();
        public frmPresncEmp()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void frmPresncEmp_Load(object sender, EventArgs e)
        {
            fillgrid();

        }
        public void fillgrid()
        {
            try
            {
                obj.connect();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Tables.Add(dt);
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("select tblDetailPersonnel.EmployeeId,tblDetailPersonnel.EmployeNom,tblDetailTravail.Departement from tblDetailPersonnel,tblDetailTravail where tblDetailTravail.EmployeeId=tblDetailPersonnel.EmployeeId", obj.con);
                da.Fill(dt);
                dataGridView.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView.Rows)
            {
                if (dr.Cells[0].Value != null) //Cells[0] Because in cell 0th cell we have added checkbox
                {
                    if ((bool)dr.Cells[0].Value == true)
                    {

                        try
                        {
                            obj.connect();
                            obj.com.CommandText = "insert into tblPresence values(@date,'" + dr.Cells[1].Value.ToString() + "','Present')";
                            obj.com.Parameters.AddWithValue("@date", dtpDOB.Value);
                            obj.com.ExecuteNonQuery();
                            obj.com.Parameters.Clear();

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
                    else
                    {
                        try
                        {
                            obj.connect();
                            obj.com.CommandText = "insert into tblAttendence values(@date,'" + dr.Cells[1].Value.ToString() + "','Absent')";
                            obj.com.Parameters.AddWithValue("@date", dtpDOB.Value);

                            obj.com.ExecuteNonQuery();
                            obj.com.Parameters.Clear();

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
                else
                {

                }
            }
            MessageBox.Show("Presence a Bien Marqué  !");
        }
    }
}
