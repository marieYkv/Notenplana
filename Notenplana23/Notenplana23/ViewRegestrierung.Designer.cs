namespace Notenplana23
{
    partial class ViewRegestrierung
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
            labelRegestrierung = new Label();
            labelBenutzername = new Label();
            labelPasswort = new Label();
            textBox1 = new TextBox();
            textBoxPasswort = new TextBox();
            buttonSpeichern = new Button();
            SuspendLayout();
            // 
            // labelRegestrierung
            // 
            labelRegestrierung.AutoSize = true;
            labelRegestrierung.Location = new Point(303, 57);
            labelRegestrierung.Name = "labelRegestrierung";
            labelRegestrierung.Size = new Size(121, 25);
            labelRegestrierung.TabIndex = 0;
            labelRegestrierung.Text = "Regestrierung";
            // 
            // labelBenutzername
            // 
            labelBenutzername.AutoSize = true;
            labelBenutzername.Location = new Point(99, 131);
            labelBenutzername.Name = "labelBenutzername";
            labelBenutzername.Size = new Size(133, 25);
            labelBenutzername.TabIndex = 1;
            labelBenutzername.Text = "Benutzername :";
            // 
            // labelPasswort
            // 
            labelPasswort.AutoSize = true;
            labelPasswort.Location = new Point(99, 210);
            labelPasswort.Name = "labelPasswort";
            labelPasswort.Size = new Size(91, 25);
            labelPasswort.TabIndex = 2;
            labelPasswort.Text = "Passwort :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 31);
            textBox1.TabIndex = 3;
            // 
            // textBoxPasswort
            // 
            textBoxPasswort.Location = new Point(265, 207);
            textBoxPasswort.Name = "textBoxPasswort";
            textBoxPasswort.Size = new Size(203, 31);
            textBoxPasswort.TabIndex = 4;
            // 
            // buttonSpeichern
            // 
            buttonSpeichern.Location = new Point(337, 320);
            buttonSpeichern.Name = "buttonSpeichern";
            buttonSpeichern.Size = new Size(112, 34);
            buttonSpeichern.TabIndex = 5;
            buttonSpeichern.Text = "Speichern";
            buttonSpeichern.UseVisualStyleBackColor = true;
            // 
            // ViewRegestrierung
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSpeichern);
            Controls.Add(textBoxPasswort);
            Controls.Add(textBox1);
            Controls.Add(labelPasswort);
            Controls.Add(labelBenutzername);
            Controls.Add(labelRegestrierung);
            Name = "ViewRegestrierung";
            Text = "ViewRegestrierung";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRegestrierung;
        private Label labelBenutzername;
        private Label labelPasswort;
        private TextBox textBox1;
        private TextBox textBoxPasswort;
        private Button buttonSpeichern;
    }
}