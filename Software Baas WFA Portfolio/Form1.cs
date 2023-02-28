using System.Security.Cryptography.X509Certificates;

namespace Software_Baas_WFA_Portfolio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // On click, convert cm to feet from the input.

            //CentimeterInput is a decimal variable.
            //Converts the string to a decimal (from the textchange txtBoxInput upon the button click)
            string CentimeterInput = (txtBoxInput.Text);
            double CentimeterOutput;
            double.TryParse(CentimeterInput, out CentimeterOutput);

            //Now we apply the centimeter to inches ratio which is 1 cm for 0,393701 inch
            double inchvalue = 0.393701;
            double InchOutput = (CentimeterOutput * inchvalue);

            txtBoxOutput.Text = InchOutput.ToString();

            /*
            //I tried creating a new form with show or showdialog but both are inappropriate.
            var inchForm = new Form();
            inchForm.Show(this); // if you need non-modal window
            */

            MessageBox.Show("You are " + InchOutput + " tall!");
            

        }
    }
}