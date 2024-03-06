namespace modul3_1302223071
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            label_output.Text += "1";
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            label_output.Text += "2";
            

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            label_output.Text += "3";
            

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            label_output.Text += "4";
           

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            label_output.Text += "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            label_output.Text += "6";
            

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            label_output.Text += "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            label_output.Text += "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            label_output.Text += "9";

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            label_output.Text += "0";

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
           
            clickcounter++;
            if(clickcounter == 1)
            {
                num1 = int.Parse(label_output.Text);
               

            }
            else if (clickcounter == 2)
            {
                num3 = int.Parse(label_output.Text);

            }
            label_output.Text = null;
           

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
           num2 = int.Parse(label_output.Text);
           int result = num1 + num2 + num3;
           label_output.Text = result.ToString();
        }
        int num1,num2,num3;
        int clickcounter = 0;

    }
}
