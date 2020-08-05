using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            string option;
            option = loginCmb.Text;
            switch (option)
            {
                case "Patient ":
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\All-IN-CARE-FORM-APPLICATION\AllInCare.mdf;Integrated Security=True;Connect Timeout=30");
                    string query = "insert into PatientSettings(Username,FirstName,LastName,BirthDate,AdressLine1,AdressLine2,ZipCode,Province,Email,MobileNo1,Password,ConfirmPassword) values('" + unameTxt.Text + "','" + fnameTxt.Text + "','" + lnameTxt.Text + "','" + bdayCal.Value + "','" + ad1Txt.Text + "','" + ad2Txt.Text + "','" + zipTxt.Text + "','" + provCmb.Text + "','" + emailTxt.Text + "','" + mobileTxt.Text + "','" + pwTxt.Text + "','" + conpwTxt + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    try
                    {
                        if (pwTxt.Text == conpwTxt.Text)
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thank you for choosing ALL-IN-CARE");
                            this.Hide();
                            LOGIN log = new LOGIN();
                            log.Show();
                        }
                        else
                        {
                            MessageBox.Show("The password you entered is not matching with the previous one try again");
                            Signup log = new Signup();
                            log.Show();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Form Submission Failed");
                        MessageBox.Show(ex.ToString());      
                    }
                    finally
                    {
                        con.Close();
                    }
                    break;

                case "Doctor":
                    SqlConnection con2= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\EDUCATION\1 Year SEM 3\Object Oriented Programming with C#\Assigments\SEM END Project\All-IN-CARE-FORM-APPLICATION\AllInCare.mdf;Integrated Security=True;Connect Timeout=30");
                    string query2 = "insert into DoctorSettings(Username,FirstName,LastName,BirthDate,AddressLine1,AddressLine2,ZipCode,Province,Email,MobileNo1,Password,ConfirmPassword) values('" + unameTxt.Text + "','" + fnameTxt.Text + "','" + lnameTxt.Text + "','" + bdayCal.Value + "','" + ad1Txt.Text + "','" + ad2Txt.Text + "','" + zipTxt.Text + "','" + provCmb.Text + "','" + emailTxt.Text + "','" + mobileTxt.Text + "','" + pwTxt.Text + "','" + conpwTxt + "')";
                    SqlCommand cmd2 = new SqlCommand(query2,con2);
                    try
                    {
                        if (pwTxt.Text == conpwTxt.Text)
                        {
                            con2.Open();
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Thank you for choosing ALL-IN-CARE");
                            this.Hide();
                            LOGIN log = new LOGIN();
                            log.Show();
                        }
                        else
                        {
                            MessageBox.Show("The password you entered is not matching with the previous one try again");
                            Signup log = new Signup();
                            log.Show();

                        }
                        
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Form Submission Failed");
                        Console.Write(ex.ToString());
                    }
                    finally
                    {
                        con2.Close();
                    }
                    break;
                case "Pharmarcy":
                    MessageBox.Show("Thank you for connecting with us");
                    break;
                case "Rider":
                    MessageBox.Show("Thank you for connecting with us");
                    break;
                default:
                    MessageBox.Show("error");
                    break;

            }
           
        }

        private void loginCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option;
            option = loginCmb.Text;
            switch (option)
            {
                case "Patient ":
                    MessageBox.Show("You have selected Patient do you wanna proceed");
                    break;
                case "Doctor":
                    MessageBox.Show("You have selected Doctor do you wanna proceed");
                    break;
                case "Pharmarcy":
                    MessageBox.Show("You have selected Pharmacy do you wanna proceed");
                    break;
                case "Rider":
                    MessageBox.Show("You have selected Rider do you wanna proceed");
                    break;
                default:
                    MessageBox.Show("error");
                    break;
            }
        }
  
    }
}
