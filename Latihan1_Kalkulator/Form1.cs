namespace Latihan1_Kalkulator
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

        private void btnPlus_Click(object sender, EventArgs e)
        {
            tbHasil.Text = "";
            try{
                float firstVal = float.Parse(tbPertama.Text);
                float secondVal = float.Parse(tbKedua.Text);
                float result = firstVal + secondVal;
                tbHasil.Text = result.ToString();
            }

            catch{
                tbHasil.Text = "Invalid Input";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            tbHasil.Text = "";
            try{
                float firstVal = float.Parse(tbPertama.Text);
                float secondVal = float.Parse(tbKedua.Text);
                float result = firstVal * secondVal;

                tbHasil.Text = result.ToString();
            }
            catch {
                tbHasil.Text = "Invalid Input";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            tbHasil.Text = "";
            try
            {
                float firstVal = float.Parse(tbPertama.Text);
                float secondVal = float.Parse(tbKedua.Text);
                float result = firstVal - secondVal;

                tbHasil.Text = result.ToString();
            }

            catch
            {
                tbHasil.Text = "Invalid Input";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            tbHasil.Text = "";
            try
            {
                float firstVal = float.Parse(tbPertama.Text);
                float secondVal = float.Parse(tbKedua.Text);
                float result = firstVal / secondVal;

                tbHasil.Text = result.ToString();
            }
            
            catch
            {
                tbHasil.Text = "Invalid Input";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbPertama.Text = "";
            tbKedua.Text = "";
            tbHasil.Text = "";
        }
    }
}