using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_8
{
    public partial class form_CalorieCalc : Form
    {
        public form_CalorieCalc()
        {
            InitializeComponent();
        }

        // Calculate calories from fat
        private int FatCalories(int grams)
        {
            return grams * 9;
        }

        // Calculate calories from carbs
        private int CarbCalories(int grams)
        {
            return grams * 4;
        }

        // Fat calories Click event
        private void btn_Fatcals_Click(object sender, EventArgs e)
        {
            // Input validation, check for integer. Assign to int input
            if (!int.TryParse(tbx_Fats.Text, out int input))
            {
                MessageBox.Show("Please enter a valid number");
            }
            else
            {
                // Display results
                lbl_Show_Fatcals.Text = FatCalories(input).ToString() + " calories from fats";
            }
        }

        // Carb calories Click event
        private void btn_Carbcals_Click(object sender, EventArgs e)
        {
            // Input validation, check for integer. Assign to int input
            if (!int.TryParse(tbx_Carbs.Text, out int input))
            {
                MessageBox.Show("Please enter a valid number");
            }
            else
            {
                // Display results
                lbl_Show_Carbcals.Text = CarbCalories(input).ToString() + " calories from carbs";
            }
        }
    }
}
