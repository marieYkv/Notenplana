﻿namespace Notenplana23
{
    partial class ViewHauptprogramm
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
            labelErstesHalbjahr = new Label();
            labelZweitesHalbjahr = new Label();
            labelFachEingeben = new Label();
            labelNotenplana = new Label();
            buttonFach1 = new Button();
            buttonFach2 = new Button();
            buttonProfil = new Button();
            buttonNote1 = new Button();
            buttonNote2 = new Button();
            SuspendLayout();
            // 
            // labelErstesHalbjahr
            // 
            labelErstesHalbjahr.AutoSize = true;
            labelErstesHalbjahr.Location = new Point(136, 256);
            labelErstesHalbjahr.Name = "labelErstesHalbjahr";
            labelErstesHalbjahr.Size = new Size(129, 25);
            labelErstesHalbjahr.TabIndex = 7;
            labelErstesHalbjahr.Text = "Erstes Halbjahr";
            // 
            // labelZweitesHalbjahr
            // 
            labelZweitesHalbjahr.AutoSize = true;
            labelZweitesHalbjahr.Location = new Point(136, 408);
            labelZweitesHalbjahr.Name = "labelZweitesHalbjahr";
            labelZweitesHalbjahr.Size = new Size(142, 25);
            labelZweitesHalbjahr.TabIndex = 8;
            labelZweitesHalbjahr.Text = "Zweites Halbjahr";
            // 
            // labelFachEingeben
            // 
            labelFachEingeben.AutoSize = true;
            labelFachEingeben.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelFachEingeben.Location = new Point(295, 153);
            labelFachEingeben.Name = "labelFachEingeben";
            labelFachEingeben.Size = new Size(182, 36);
            labelFachEingeben.TabIndex = 12;
            labelFachEingeben.Text = "Fach eingeben";
            // 
            // labelNotenplana
            // 
            labelNotenplana.AutoSize = true;
            labelNotenplana.Font = new Font("Segoe UI", 17.5F, FontStyle.Regular, GraphicsUnit.Point);
            labelNotenplana.Location = new Point(308, 40);
            labelNotenplana.Name = "labelNotenplana";
            labelNotenplana.Size = new Size(202, 47);
            labelNotenplana.TabIndex = 13;
            labelNotenplana.Text = "Notenplana";
            // 
            // buttonFach1
            // 
            buttonFach1.Location = new Point(246, 308);
            buttonFach1.Name = "buttonFach1";
            buttonFach1.Size = new Size(112, 34);
            buttonFach1.TabIndex = 14;
            buttonFach1.Text = "Fach";
            buttonFach1.UseVisualStyleBackColor = true;
            buttonFach1.Click += buttonFach1_Click;
            // 
            // buttonFach2
            // 
            buttonFach2.Location = new Point(246, 461);
            buttonFach2.Name = "buttonFach2";
            buttonFach2.Size = new Size(112, 34);
            buttonFach2.TabIndex = 15;
            buttonFach2.Text = "Fach";
            buttonFach2.UseVisualStyleBackColor = true;
            buttonFach2.Click += buttonFach2_Click;
            // 
            // buttonProfil
            // 
            buttonProfil.Location = new Point(710, 40);
            buttonProfil.Name = "buttonProfil";
            buttonProfil.Size = new Size(112, 34);
            buttonProfil.TabIndex = 16;
            buttonProfil.Text = "Profil";
            buttonProfil.UseVisualStyleBackColor = true;
            buttonProfil.Click += buttonProfil_Click;
            // 
            // buttonNote1
            // 
            buttonNote1.Location = new Point(462, 308);
            buttonNote1.Name = "buttonNote1";
            buttonNote1.Size = new Size(112, 34);
            buttonNote1.TabIndex = 17;
            buttonNote1.Text = "Note";
            buttonNote1.UseVisualStyleBackColor = true;
            buttonNote1.Click += buttonNote1_Click;
            // 
            // buttonNote2
            // 
            buttonNote2.Location = new Point(462, 461);
            buttonNote2.Name = "buttonNote2";
            buttonNote2.Size = new Size(112, 34);
            buttonNote2.TabIndex = 18;
            buttonNote2.Text = "Note";
            buttonNote2.UseVisualStyleBackColor = true;
            buttonNote2.Click += buttonNote2_Click;
            // 
            // ViewHauptprogramm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 622);
            Controls.Add(buttonNote2);
            Controls.Add(buttonNote1);
            Controls.Add(buttonProfil);
            Controls.Add(buttonFach2);
            Controls.Add(buttonFach1);
            Controls.Add(labelNotenplana);
            Controls.Add(labelFachEingeben);
            Controls.Add(labelZweitesHalbjahr);
            Controls.Add(labelErstesHalbjahr);
            Name = "ViewHauptprogramm";
            Text = "ViewHauptprogramm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelErstesHalbjahr;
        private Label labelZweitesHalbjahr;
        private Label labelFachEingeben;
        private Label labelNotenplana;
        private Button buttonFach1;
        private Button buttonFach2;
        private Button buttonProfil;
        private Button buttonNote1;
        private Button buttonNote2;
    }
}