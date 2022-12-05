using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DylanDeSouzaWk15ExA
{
    public partial class frmTilingCostEstimator : Form
    {
        public frmTilingCostEstimator()
        {
            InitializeComponent();
        }

        const uint LAYING_COST = 2U, LABOUR_COST = 45U;
        double dbl_room_length = 0, dbl_room_width = 0, dbl_cost_per_metre = 0, dbl_room_area = 0, dbl_est_tile_cost = 0, db_est_job_cost = 0; 

        private bool Validate_entries()
        {
            if (!double.TryParse(txt_length.Text, out dbl_room_length))
            {
                MessageBox.Show("Room length is not a number - enter again");
                txt_length.Clear();
                txt_length.Focus();
                return false;
            }
            if (!double.TryParse(txt_width.Text, out dbl_room_width))
            {
                MessageBox.Show("Room length is not a number - enter again");
                txt_width.Clear();
                txt_width.Focus();
                return false;
            }
            if (!double.TryParse(txt_cost_per_metre.Text, out dbl_cost_per_metre))
            {
                MessageBox.Show("Cost per Square metre is not a number - enter again");
                txt_cost_per_metre.Clear();
                txt_cost_per_metre.Focus();
            }
            return true;
        }

        private void Calc_display_room_area()
        {
            dbl_room_area = dbl_room_length * dbl_room_width;
            txt_room_area.Text = dbl_room_area.ToString() + " Square Metres";
        }

        private void Calc_display_est_cost()
        {
            dbl_est_tile_cost = dbl_room_area * dbl_cost_per_metre;
            txt_est_tile_cost.Text = dbl_est_tile_cost.ToString("C");
            db_est_job_cost = dbl_room_area * (LAYING_COST + LABOUR_COST) + dbl_est_tile_cost;
            txt_est_job_cost.Text = db_est_job_cost.ToString("C");
        }
        private void btnEstimateCosts_Click(object sender, EventArgs e)
        {
            if (Validate_entries())
            {
                Calc_display_room_area();
                Calc_display_est_cost();
            }
        }
    }
}
