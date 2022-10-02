using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMICalculator
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

        private void btn_calculations_Click(object sender, EventArgs e)
        {
            float weight; 
            float height;
            weight = float.Parse(txt_weight.Text);
            height = float.Parse(txt_height.Text);
            Console.WriteLine(weight);
            Console.WriteLine(height);
            float calculations = weight / (float)(height * height);
            Console.WriteLine(calculations);
            if(calculations < 18.5)
            {
                lbl_result.Text = $"YOUR BMI: {calculations.ToString()} \n\tUnder Weight";
            }else if (calculations >= 18.5 && calculations <= 24.9)
            {
                lbl_result.Text = $"YOUR BMI: {calculations.ToString()} \n\tNormal Weight";
            }
            else if (calculations >= 25 && calculations <= 29.9)
            {
                lbl_result.Text = $"YOUR BMI: {calculations.ToString()} \n\tOver Weight";
            }else if (calculations >= 30 && calculations <= 34.9)
            {
                lbl_result.Text = $"YOUR BMI: {calculations.ToString()} \n\tObesity Class I";
            }else if (calculations >= 35 && calculations <= 39.9)
            {
                lbl_result.Text = $"YOUR BMI: {calculations.ToString()} \n\tObesity Class II";
            }else if (calculations > 40)
            {
                lbl_result.Text = $"YOUR BMI: {calculations.ToString()} \n\tExtreme Obesity";
            }
        }

        // Remove and Add text - Weight
        public void RemoveText(object sender, EventArgs e)
        {
            if (txt_height.Text == "Enter text here...")
            {
                txt_height.Text = "";
            }
            if (txt_weight.Text == "Enter text here...")
            {
                txt_weight.Text = "";
            }
        }

        private void txt_weight_Click(object sender, EventArgs e)
        {
            RemoveText(sender, e);
        }

        private void txt_height_Click(object sender, EventArgs e)
        {
            RemoveText(sender, e);
        }

        private void lbl_result_Click(object sender, EventArgs e)
        {

        }
    }
}
