//Programmed by Daniel Robin Cherrin.
//Email: daniel.r.cherrin@gmail.com
//Latest revision: 15-Sep-2017.
/*Purpose of the programm: Creates a form application that converts units of measurements into two txt boxes. one input, one output.
  Have application when 'esc' key is pressed or a button control is pressed*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace danielCherrinAssignment01
{
    public partial class frm_distanceConverter : Form
    {
        public frm_distanceConverter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_inchesToCms_Click(object sender, EventArgs e)
        {
            const double dbl_CM_PER_INCH = 2.54;
            double dbl_input;
            double dbl_output;

            //Input validation.
            if (!double.TryParse(txt_input.Text, out dbl_input))
            {
                MessageBox.Show("Your entry is not a number or is empty - Please enter a positive number");
                txt_input.Clear();
                txt_input.Focus();
            }
            else if (dbl_input < 0)
            {
                MessageBox.Show("Your entry is a negative - Please enter a positive number");
                txt_input.Clear();
                txt_input.Focus();
            }
            //Validation successful. - Calculate inches to CMs
            else
            {
                lbl_inputLabel.Text = "inches";
                lbl_outputLabel.Text = "centimetres";
                dbl_output = dbl_input * dbl_CM_PER_INCH;
                txt_output.Text = dbl_output.ToString();
                //Make outputs visible
                lbl_LABEL_EQUALS.Visible = true;
                txt_output.Visible = true;
                lbl_outputLabel.Visible = true;
                lbl_inputLabel.Visible = true;
            }
        }

        private void btn_FeetToMetres_Click(object sender, EventArgs e)
        {
            const double dbl_FEET_PER_METRES = 0.3048;
            double dbl_input;
            double dbl_output;

            //Input validation.
            if (!double.TryParse(txt_input.Text, out dbl_input))
            {
                MessageBox.Show("Your entry is not a number or is empty - Please enter a positive number");
                txt_input.Clear();
                txt_input.Focus();
            }
            else if (dbl_input < 0)
            {
                MessageBox.Show("Your entry is a negative - Please enter a positive number");
                txt_input.Clear();
                txt_input.Focus();
            }
            //Validation successful. - Calculate inches to CMs
            else
            {
                lbl_inputLabel.Text = "feet";
                lbl_outputLabel.Text = "metres";
                dbl_output = dbl_input * dbl_FEET_PER_METRES;
                txt_output.Text = dbl_output.ToString();
                //Make outputs visible
                lbl_LABEL_EQUALS.Visible = true;
                txt_output.Visible = true;
                lbl_outputLabel.Visible = true;
                lbl_inputLabel.Visible = true;
            }
        }

        private void btn_YardsToMetres_Click(object sender, EventArgs e)
        {
            const double dbl_YARD_PER_METRES = 0.9144;
            double dbl_input;
            double dbl_output;

            //Input validation.
            if (!double.TryParse(txt_input.Text, out dbl_input))
            {
                MessageBox.Show("Your entry is not a number or is empty - Please enter a positive number");
                txt_input.Clear();
                txt_input.Focus();
            }
            else if (dbl_input < 0)
            {
                MessageBox.Show("Your entry is a negative - Please enter a positive number");
                txt_input.Clear();
                txt_input.Focus();
            }
            //Validation successful. - Calculate inches to CMs
            else
            {
                lbl_inputLabel.Text = "yards";
                lbl_outputLabel.Text = "metres";
                dbl_output = dbl_input * dbl_YARD_PER_METRES;
                txt_output.Text = dbl_output.ToString();
                //Make outputs visible
                lbl_LABEL_EQUALS.Visible = true;
                txt_output.Visible = true;
                lbl_outputLabel.Visible = true;
                lbl_inputLabel.Visible = true;
            }
        }

        private void btn_MilesToKms_Click(object sender, EventArgs e)
        {
            const double dbl_MILES_PER_KILOMETRES = 1.609;
            double dbl_input;
            double dbl_output;

            //Input validation.
            if (!double.TryParse(txt_input.Text, out dbl_input))
            {
                MessageBox.Show("Your entry is not a number or is empty - Please enter a positive number");
                txt_input.Clear();
                txt_input.Focus();
            }
            else if (dbl_input < 0)
            {
                MessageBox.Show("Your entry is a negative - Please enter a positive number");
                txt_input.Clear();
                txt_input.Focus();
            }
            //Validation successful. - Calculate inches to CMs
            else
            {
                lbl_inputLabel.Text = "miles";
                lbl_outputLabel.Text = "kilometres";
                dbl_output = dbl_input * dbl_MILES_PER_KILOMETRES;
                txt_output.Text = dbl_output.ToString();
                //Make outputs visible
                lbl_LABEL_EQUALS.Visible = true;
                txt_output.Visible = true;
                lbl_outputLabel.Visible = true;
                lbl_inputLabel.Visible = true;
            }
        }

        private void frm_distanceConverter_Load(object sender, EventArgs e)
        {

        }
        //button to exit app
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Event when input is clicked - clears relevant labels and outputs
        private void txt_input_Click(object sender, EventArgs e)
        {
            txt_input.Clear();
            lbl_LABEL_EQUALS.Visible = false;
            txt_output.Visible = false;
            lbl_outputLabel.Visible = false;
            lbl_inputLabel.Visible = false;
        }
        //Event when user enters input - clears relevant labels and outputs
        private void txt_input_Enter(object sender, EventArgs e)
        {
            txt_input.Clear();
            lbl_LABEL_EQUALS.Visible = false;
            txt_output.Visible = false;
            lbl_outputLabel.Visible = false;
            lbl_inputLabel.Visible = false;
        }

        private void frm_distanceConverter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void frm_distanceConverter_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }
    }
}
