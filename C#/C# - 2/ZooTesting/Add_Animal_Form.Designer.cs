﻿namespace ZooTesting
{
    partial class Add_Animal_Form
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.add_new_animal_btn = new System.Windows.Forms.Button();
            this.animal_name_input = new System.Windows.Forms.TextBox();
            this.animal_name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(166, 58);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 33;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // add_new_animal_btn
            // 
            this.add_new_animal_btn.Location = new System.Drawing.Point(85, 58);
            this.add_new_animal_btn.Name = "add_new_animal_btn";
            this.add_new_animal_btn.Size = new System.Drawing.Size(75, 23);
            this.add_new_animal_btn.TabIndex = 32;
            this.add_new_animal_btn.Text = "Add";
            this.add_new_animal_btn.UseVisualStyleBackColor = true;
            this.add_new_animal_btn.Click += new System.EventHandler(this.add_new_animal_btn_Click);
            // 
            // animal_name_input
            // 
            this.animal_name_input.Location = new System.Drawing.Point(85, 23);
            this.animal_name_input.Name = "animal_name_input";
            this.animal_name_input.Size = new System.Drawing.Size(222, 20);
            this.animal_name_input.TabIndex = 19;
            this.animal_name_input.TextChanged += new System.EventHandler(this.animal_name_input_TextChanged);
            // 
            // animal_name_label
            // 
            this.animal_name_label.AutoSize = true;
            this.animal_name_label.Location = new System.Drawing.Point(18, 26);
            this.animal_name_label.Name = "animal_name_label";
            this.animal_name_label.Size = new System.Drawing.Size(38, 13);
            this.animal_name_label.TabIndex = 18;
            this.animal_name_label.Text = "Name:";
            // 
            // Add_Animal_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 98);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.add_new_animal_btn);
            this.Controls.Add(this.animal_name_input);
            this.Controls.Add(this.animal_name_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Animal_Form";
            this.Text = "Add New Animal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button add_new_animal_btn;
        private System.Windows.Forms.TextBox animal_name_input;
        private System.Windows.Forms.Label animal_name_label;
    }
}