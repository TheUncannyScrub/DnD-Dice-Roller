namespace DnD_Dice_GUI
{
    partial class dnd
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
            this.txt_sides = new System.Windows.Forms.TextBox();
            this.txt_rolls = new System.Windows.Forms.TextBox();
            this.lbl_sides = new System.Windows.Forms.Label();
            this.lbl_rolls = new System.Windows.Forms.Label();
            this.rtf_output = new System.Windows.Forms.RichTextBox();
            this.btn_roll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_sides
            // 
            this.txt_sides.Location = new System.Drawing.Point(73, 23);
            this.txt_sides.Name = "txt_sides";
            this.txt_sides.Size = new System.Drawing.Size(100, 20);
            this.txt_sides.TabIndex = 0;
            // 
            // txt_rolls
            // 
            this.txt_rolls.Location = new System.Drawing.Point(73, 49);
            this.txt_rolls.Name = "txt_rolls";
            this.txt_rolls.Size = new System.Drawing.Size(100, 20);
            this.txt_rolls.TabIndex = 1;
            // 
            // lbl_sides
            // 
            this.lbl_sides.AutoSize = true;
            this.lbl_sides.Location = new System.Drawing.Point(9, 26);
            this.lbl_sides.Name = "lbl_sides";
            this.lbl_sides.Size = new System.Drawing.Size(58, 13);
            this.lbl_sides.TabIndex = 2;
            this.lbl_sides.Text = "Dice Sides";
            // 
            // lbl_rolls
            // 
            this.lbl_rolls.AutoSize = true;
            this.lbl_rolls.Location = new System.Drawing.Point(12, 52);
            this.lbl_rolls.Name = "lbl_rolls";
            this.lbl_rolls.Size = new System.Drawing.Size(55, 13);
            this.lbl_rolls.TabIndex = 3;
            this.lbl_rolls.Text = "Dice Rolls";
            // 
            // rtf_output
            // 
            this.rtf_output.Location = new System.Drawing.Point(179, 23);
            this.rtf_output.Name = "rtf_output";
            this.rtf_output.ReadOnly = true;
            this.rtf_output.Size = new System.Drawing.Size(456, 76);
            this.rtf_output.TabIndex = 4;
            this.rtf_output.Text = "";
            // 
            // btn_roll
            // 
            this.btn_roll.Location = new System.Drawing.Point(73, 76);
            this.btn_roll.Name = "btn_roll";
            this.btn_roll.Size = new System.Drawing.Size(100, 23);
            this.btn_roll.TabIndex = 5;
            this.btn_roll.Text = "Roll";
            this.btn_roll.UseVisualStyleBackColor = true;
            this.btn_roll.Click += new System.EventHandler(this.btn_roll_Click);
            // 
            // dnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 133);
            this.Controls.Add(this.btn_roll);
            this.Controls.Add(this.rtf_output);
            this.Controls.Add(this.lbl_rolls);
            this.Controls.Add(this.lbl_sides);
            this.Controls.Add(this.txt_rolls);
            this.Controls.Add(this.txt_sides);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "dnd";
            this.ShowIcon = false;
            this.Text = "Dungeons and Dragons Dice Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sides;
        private System.Windows.Forms.TextBox txt_rolls;
        private System.Windows.Forms.Label lbl_sides;
        private System.Windows.Forms.Label lbl_rolls;
        private System.Windows.Forms.RichTextBox rtf_output;
        private System.Windows.Forms.Button btn_roll;
    }
}

