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

namespace Login_Form
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        private int maxLength = 4;
        private string connectionString = (@"Data Source=CHERNAYADIRA\SQLEXPRESS;Initial Catalog=""Time Register"";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            txt_box_PinCode.MaxLength = maxLength;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txt_box_PinCode.PasswordChar = '*';
            txt_box_PinCode.MaxLength = 4;

        }
        private void btn_Click(object sender, EventArgs e)
        {
            string pinCode = txt_box_PinCode.Text;

            // Query the database to check if the PIN exists
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT UserName FROM Users WHERE PinCode = @PinCode";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PinCode", pinCode);

                    object result = command.ExecuteScalar(); // Gets the first column of the first row

                    if (result != null)
                    {
                        // If the PIN is correct, open the DisplayForm
                        string userName = result.ToString();
                        Form2 displayForm = new Form2(Name);
                        displayForm.Show();

                        // Optionally hide or close the login form
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid PIN code. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

                // Prevent further input if max length is reached and no operation was performed
                if (txt_box_PinCode.Text.Length >= maxLength && !isOperationPerformed)
                {
                    MessageBox.Show($"Maximum length of {maxLength} reached.");
                    return;
                }

                // Clear the TextBox if it contains "0" or a previous operation was performed
                if (txt_box_PinCode.Text == "0" || isOperationPerformed)
                {
                    txt_box_PinCode.Clear();
                }

                isOperationPerformed = false; // Reset the operation flag for the next input

                Button button = (Button)sender; // Get the button that was clicked


                if (txt_box_PinCode.Text.Length < maxLength)
                {
                    // Allow any input including '0'
                    txt_box_PinCode.Text += button.Text;
                }

                // Additional check after modification (optional)
                if (txt_box_PinCode.Text.Length > maxLength)
                {
                    MessageBox.Show($"The maximum limit is {maxLength}");
                    txt_box_PinCode.Text = txt_box_PinCode.Text.Substring(0, maxLength); // Truncate to maxLength
                }
            }
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            txt_box_PinCode.Text = "0";
            resultValue = 0;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (txt_box_PinCode.Text.Length > 0)
                txt_box_PinCode.Text = txt_box_PinCode.Text.Remove(txt_box_PinCode.Text.Length - 1, 1);

            if (txt_box_PinCode.Text == "")
                txt_box_PinCode.Text = "0";
        }

        private void txt_box_PinCode_TextChanged(object sender, EventArgs e)
        {

            if (txt_box_PinCode.Text.Length > 4)
            {
                MessageBox.Show("The maximum limit is 4");
            }
        }
    }
}