﻿namespace proyectofinalcruds
{
    partial class Menu
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnRegreso = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(67, 43);
            button1.Name = "button1";
            button1.Size = new Size(129, 55);
            button1.TabIndex = 0;
            button1.Text = "Pacientes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(67, 124);
            button2.Name = "button2";
            button2.Size = new Size(129, 55);
            button2.TabIndex = 1;
            button2.Text = "Medicos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(67, 215);
            button3.Name = "button3";
            button3.Size = new Size(129, 55);
            button3.TabIndex = 2;
            button3.Text = "Personal_Apoyo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(262, 43);
            button4.Name = "button4";
            button4.Size = new Size(129, 55);
            button4.TabIndex = 3;
            button4.Text = "Metodos_de_Pago";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(262, 124);
            button5.Name = "button5";
            button5.Size = new Size(129, 55);
            button5.TabIndex = 4;
            button5.Text = "Tratamientos";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(262, 215);
            button6.Name = "button6";
            button6.Size = new Size(129, 55);
            button6.TabIndex = 5;
            button6.Text = "Medicamentos";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(441, 43);
            button7.Name = "button7";
            button7.Size = new Size(129, 55);
            button7.TabIndex = 6;
            button7.Text = "Diagnósticos";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(441, 124);
            button8.Name = "button8";
            button8.Size = new Size(129, 55);
            button8.TabIndex = 7;
            button8.Text = "Exámenes_Medicos";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(441, 215);
            button9.Name = "button9";
            button9.Size = new Size(129, 55);
            button9.TabIndex = 8;
            button9.Text = "Habitaciones";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // btnRegreso
            // 
            btnRegreso.Location = new Point(67, 401);
            btnRegreso.Name = "btnRegreso";
            btnRegreso.Size = new Size(78, 37);
            btnRegreso.TabIndex = 9;
            btnRegreso.Text = "Regreso";
            btnRegreso.UseVisualStyleBackColor = true;
            btnRegreso.Click += btnRegreso_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegreso);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btnRegreso;
    }
}