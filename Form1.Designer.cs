namespace BMICalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_weight = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_calculations = new System.Windows.Forms.Button();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_weight.Location = new System.Drawing.Point(70, 71);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(229, 31);
            this.lbl_weight.TabIndex = 0;
            this.lbl_weight.Text = "Your weight in kg:";
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_height.Location = new System.Drawing.Point(310, 71);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(278, 31);
            this.lbl_height.TabIndex = 1;
            this.lbl_height.Text = "Your height in meters:";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(211, 183);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(62, 31);
            this.lbl_result.TabIndex = 2;
            this.lbl_result.Text = "BMI";
            this.lbl_result.Click += new System.EventHandler(this.lbl_result_Click);
            // 
            // btn_calculations
            // 
            this.btn_calculations.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_calculations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculations.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_calculations.Location = new System.Drawing.Point(228, 270);
            this.btn_calculations.Name = "btn_calculations";
            this.btn_calculations.Size = new System.Drawing.Size(177, 71);
            this.btn_calculations.TabIndex = 3;
            this.btn_calculations.Text = "Calculate";
            this.btn_calculations.UseVisualStyleBackColor = false;
            this.btn_calculations.Click += new System.EventHandler(this.btn_calculations_Click);
            // 
            // txt_weight
            // 
            this.txt_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_weight.Location = new System.Drawing.Point(121, 128);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(157, 26);
            this.txt_weight.TabIndex = 4;
            this.txt_weight.Text = "Enter text here...";
            this.txt_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_weight.Click += new System.EventHandler(this.txt_weight_Click);
            // 
            // txt_height
            // 
            this.txt_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_height.Location = new System.Drawing.Point(363, 128);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(157, 26);
            this.txt_height.TabIndex = 5;
            this.txt_height.Text = "Enter text here...";
            this.txt_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_height.Click += new System.EventHandler(this.txt_height_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(618, 368);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.btn_calculations);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_height);
            this.Controls.Add(this.lbl_weight);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_calculations;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.TextBox txt_height;
    }
}

