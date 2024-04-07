namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Execute_Click(object sender, EventArgs e)
        {
            double sideA, sideB, sideC;

            if (!double.TryParse(textBox_A.Text, out sideA))
            {
                textBox_A.Text = "5";
                textBox_A.ForeColor = Color.Red;
            }

            if (!double.TryParse(textBox_B.Text, out sideB))
            {
                textBox_B.Text = "5";
                textBox_B.ForeColor = Color.Red;
            }

            if (!double.TryParse(textBox_C.Text, out sideC))
            {
                textBox_C.Text = "5";
                textBox_C.ForeColor = Color.Red;
            }

            if (sideA == sideB && sideA != sideC)
            {
                textBox_result.Text = "The triangle is isosceles.";
                textBox_info_about_sides.Text = "a = b";
                textBox_info_about_sides_numb.Text = "" + sideA + "";


            }
            else if (sideA == sideC && sideA != sideB)
            {
                textBox_result.Text = "The triangle is isosceles.";
                textBox_info_about_sides.Text = "a = c";
                textBox_info_about_sides_numb.Text = "" + sideC + "";
            }
            else if (sideB == sideC && sideB != sideA)
            {
                textBox_result.Text = "The triangle is isosceles.";
                textBox_info_about_sides.Text = "b = c";
                textBox_info_about_sides_numb.Text = "" + sideB + "";
            }
            else
            {
                textBox_result.Text = "The triangle is not isosceles.";
            }
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Determine if the triangles are equilateral\nCreated by Radchenko Dmytro", "About");
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}