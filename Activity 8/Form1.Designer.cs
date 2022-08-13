namespace Activity_8
{
    partial class form_CalorieCalc
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
            this.lbl_Fats = new System.Windows.Forms.Label();
            this.lbl_Carbs = new System.Windows.Forms.Label();
            this.tbx_Fats = new System.Windows.Forms.TextBox();
            this.tbx_Carbs = new System.Windows.Forms.TextBox();
            this.btn_Fatcals = new System.Windows.Forms.Button();
            this.btn_Carbcals = new System.Windows.Forms.Button();
            this.lbl_Show_Fatcals = new System.Windows.Forms.Label();
            this.lbl_Show_Carbcals = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Fats
            // 
            this.lbl_Fats.AutoSize = true;
            this.lbl_Fats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fats.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Fats.Location = new System.Drawing.Point(70, 97);
            this.lbl_Fats.Name = "lbl_Fats";
            this.lbl_Fats.Size = new System.Drawing.Size(185, 26);
            this.lbl_Fats.TabIndex = 0;
            this.lbl_Fats.Text = "Enter grams of fat";
            // 
            // lbl_Carbs
            // 
            this.lbl_Carbs.AutoSize = true;
            this.lbl_Carbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Carbs.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Carbs.Location = new System.Drawing.Point(435, 97);
            this.lbl_Carbs.Name = "lbl_Carbs";
            this.lbl_Carbs.Size = new System.Drawing.Size(214, 26);
            this.lbl_Carbs.TabIndex = 1;
            this.lbl_Carbs.Text = "Enter grams of carbs";
            // 
            // tbx_Fats
            // 
            this.tbx_Fats.Location = new System.Drawing.Point(106, 143);
            this.tbx_Fats.Name = "tbx_Fats";
            this.tbx_Fats.Size = new System.Drawing.Size(100, 20);
            this.tbx_Fats.TabIndex = 2;
            // 
            // tbx_Carbs
            // 
            this.tbx_Carbs.Location = new System.Drawing.Point(486, 143);
            this.tbx_Carbs.Name = "tbx_Carbs";
            this.tbx_Carbs.Size = new System.Drawing.Size(100, 20);
            this.tbx_Carbs.TabIndex = 3;
            // 
            // btn_Fatcals
            // 
            this.btn_Fatcals.Location = new System.Drawing.Point(106, 188);
            this.btn_Fatcals.Name = "btn_Fatcals";
            this.btn_Fatcals.Size = new System.Drawing.Size(100, 36);
            this.btn_Fatcals.TabIndex = 4;
            this.btn_Fatcals.Text = "Calculate Fat Calories";
            this.btn_Fatcals.UseVisualStyleBackColor = true;
            this.btn_Fatcals.Click += new System.EventHandler(this.btn_Fatcals_Click);
            // 
            // btn_Carbcals
            // 
            this.btn_Carbcals.Location = new System.Drawing.Point(486, 188);
            this.btn_Carbcals.Name = "btn_Carbcals";
            this.btn_Carbcals.Size = new System.Drawing.Size(100, 36);
            this.btn_Carbcals.TabIndex = 5;
            this.btn_Carbcals.Text = "Calculate Carb Calories";
            this.btn_Carbcals.UseVisualStyleBackColor = true;
            this.btn_Carbcals.Click += new System.EventHandler(this.btn_Carbcals_Click);
            // 
            // lbl_Show_Fatcals
            // 
            this.lbl_Show_Fatcals.AutoSize = true;
            this.lbl_Show_Fatcals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Show_Fatcals.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Show_Fatcals.Location = new System.Drawing.Point(85, 259);
            this.lbl_Show_Fatcals.Name = "lbl_Show_Fatcals";
            this.lbl_Show_Fatcals.Size = new System.Drawing.Size(0, 20);
            this.lbl_Show_Fatcals.TabIndex = 6;
            // 
            // lbl_Show_Carbcals
            // 
            this.lbl_Show_Carbcals.AutoSize = true;
            this.lbl_Show_Carbcals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Show_Carbcals.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Show_Carbcals.Location = new System.Drawing.Point(448, 259);
            this.lbl_Show_Carbcals.Name = "lbl_Show_Carbcals";
            this.lbl_Show_Carbcals.Size = new System.Drawing.Size(0, 20);
            this.lbl_Show_Carbcals.TabIndex = 7;
            // 
            // form_CalorieCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Show_Carbcals);
            this.Controls.Add(this.lbl_Show_Fatcals);
            this.Controls.Add(this.btn_Carbcals);
            this.Controls.Add(this.btn_Fatcals);
            this.Controls.Add(this.tbx_Carbs);
            this.Controls.Add(this.tbx_Fats);
            this.Controls.Add(this.lbl_Carbs);
            this.Controls.Add(this.lbl_Fats);
            this.Name = "form_CalorieCalc";
            this.Text = "Calorie Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Fats;
        private System.Windows.Forms.Label lbl_Carbs;
        private System.Windows.Forms.TextBox tbx_Fats;
        private System.Windows.Forms.TextBox tbx_Carbs;
        private System.Windows.Forms.Button btn_Fatcals;
        private System.Windows.Forms.Button btn_Carbcals;
        private System.Windows.Forms.Label lbl_Show_Fatcals;
        private System.Windows.Forms.Label lbl_Show_Carbcals;
    }
}

