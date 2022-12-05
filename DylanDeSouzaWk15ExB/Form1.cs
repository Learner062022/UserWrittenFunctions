using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DylanDeSouzaWk15ExB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Validate_inputs(ref TextBox txt_principal_amount, ref double dbl_principle_amount, string str_amount_error, ref TextBox txt_interest_rate, ref float flt_interest_rate, string str_rate_error, ref TextBox txt_years, ref int int_num_years, string str_years_error, ref TextBox txt_compounded, ref int int_compounded, string str_compound_error)
        {
            if (!double.TryParse(txt_principal_amount.Text, out dbl_principle_amount))
            {
                MessageBox.Show(str_amount_error + " is not a number - Please enter it again", "Entry Error");
                txt_principal_amount.Clear();
                txt_principal_amount.Focus();
                return false;
            }
            else if (!float.TryParse(txt_interest_rate.Text, out flt_interest_rate))
            {
                MessageBox.Show(str_rate_error + " is not a number - Please enter it again", "Entry Error");
                txt_interest_rate.Clear();
                txt_interest_rate.Focus();
                return false;
            }
            else if (!int.TryParse(txt_years.Text, out int_num_years))
            {
                MessageBox.Show(str_years_error + " is not a number - Please enter it again", "Entry Error");
                txt_years.Clear();
                txt_years.Focus();
                return false;
            }
            else
            {
                if (!int.TryParse(txt_compounded.Text, out int_compounded))
                {
                    MessageBox.Show(str_compound_error + " is not a number - Please enter it again", "Entry Error");
                    txt_compounded.Clear();
                    txt_compounded.Focus();
                    return false;
                }
            }
            return true;
        }


        double dbl_principle = 0, dbl_investment_amount = 0, dbl_interest = 0;
        int int_compounded = 0, int_time = 0, int_exponent = 0;
        float flt_rate = 0;
        
        private void btnClick_Click(object sender, EventArgs e)
        {
            if (Validate_inputs(ref txt_principal_amount, ref dbl_principle, txt_principal_amount.Text, ref txt_interest_rate, ref flt_rate, txt_interest_rate.Text, ref txt_years, ref int_time, txt_years.Text, ref txt_compounded, ref int_compounded, txt_compounded.Text))
            {
                int_exponent = int_time * int_compounded;
                flt_rate /= 100;
                dbl_investment_amount = dbl_principle * Math.Pow((1 + flt_rate / int_compounded), int_exponent);
                dbl_interest = dbl_investment_amount - dbl_principle;
                txt_interest.Text = dbl_interest.ToString("C");
                lbl_interest.Visible = true;
                txt_interest.Visible = true;
            }
        }
    }
}
