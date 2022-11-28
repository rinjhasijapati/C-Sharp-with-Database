using System.Data.SqlClient;

namespace calculator
{
    public partial class Form1 : Form
    {
        string operate = "";
        decimal calculation = 0;

        SqlConnection con = new SqlConnection(
                @"Data Source= .\SQLEXPRESS;    
                Initial Catalog=bit3rdsem;
                user id=sa;
                password=kist@123;");
        public void GetResultValue()
        {
            if (textBox1.Text != "" && textBox1.Text != "+" && textBox1.Text != "-" && textBox1.Text != "*" && textBox1.Text != "/")
            {
                calculation = Convert.ToDecimal(textBox1.Text);
            }
        }

        public void checkOperator()
        {
      
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "Insert into Student values('rinjha','lalitpur','9822222222','ku')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
                //textBox1.Text = String.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.InnerException);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text = "7";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "7";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text = "8";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "8";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text = "9";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "9";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text = "4";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "4";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text = "5";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "5";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text = "6";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "6";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text = "1";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "1";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text = "2";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "2";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text = "3";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "3";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text = "0";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "0";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = data + ".";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = data.Remove(data.Length - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = data + "%";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "*";
            textBox1.Text = "*";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "/";
            textBox1.Text = "/";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "-";
            textBox1.Text =  "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "+";
            textBox1.Text = "+";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            if (data.Contains("(")){
                textBox1.Text = data + ")";
            }
            else
            {
                textBox1.Text = "(" + data;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            decimal firstNum = calculation;
            decimal secondNum = Convert.ToDecimal(textBox1.Text);   
            switch(operate)
            {
                case "+":
                    calculation = (firstNum + secondNum);
                    textBox1.Text = calculation.ToString();
                    break;
                case "-":
                    calculation = (firstNum - secondNum);
                    textBox1.Text = calculation.ToString();
                    break;
                case "*":
                    calculation = (firstNum * secondNum);
                    textBox1.Text = calculation.ToString();
                    break;
                case "/":
                    calculation = (firstNum / secondNum);
                    textBox1.Text = calculation.ToString();
                    break;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //this.Close(); closes the first form and shows the second form
            this.Hide(); //hides the first form 
            Form2 EmployeeForm = new Form2();
            EmployeeForm.ShowDialog(); //doesn't let the first form to be accessed unless the second form is closed
            //EmployeeForm.Show(); shows the second form and lets the first form to be accessed as well
        }
    }
}