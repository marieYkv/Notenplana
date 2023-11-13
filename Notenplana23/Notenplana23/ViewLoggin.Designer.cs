namespace Notenplana23
{
    partial class ViewLoggin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelLoggin = new Label();
            labelBenutzername = new Label();
            labelPasswort = new Label();
            buttonLoggin = new Button();
            buttonRegestrierung = new Button();
            textBoxBenutzername = new TextBox();
            textBoxPasswort = new TextBox();
            SuspendLayout();
            // 
            // labelLoggin
            // 
            labelLoggin.AutoSize = true;
            labelLoggin.Location = new Point(357, 58);
            labelLoggin.Name = "labelLoggin";
            labelLoggin.Size = new Size(67, 25);
            labelLoggin.TabIndex = 0;
            labelLoggin.Text = "Loggin";
            // 
            // labelBenutzername
            // 
            labelBenutzername.AutoSize = true;
            labelBenutzername.Location = new Point(101, 168);
            labelBenutzername.Name = "labelBenutzername";
            labelBenutzername.Size = new Size(133, 25);
            labelBenutzername.TabIndex = 1;
            labelBenutzername.Text = "Benutzername :";
            // 
            // labelPasswort
            // 
            labelPasswort.AutoSize = true;
            labelPasswort.Location = new Point(143, 223);
            labelPasswort.Name = "labelPasswort";
            labelPasswort.Size = new Size(91, 25);
            labelPasswort.TabIndex = 2;
            labelPasswort.Text = "Passwort :";
            // 
            // buttonLoggin
            // 
            buttonLoggin.Location = new Point(334, 291);
            buttonLoggin.Name = "buttonLoggin";
            buttonLoggin.Size = new Size(112, 34);
            buttonLoggin.TabIndex = 3;
            buttonLoggin.Text = "Loggin";
            buttonLoggin.UseVisualStyleBackColor = true;
            // 
            // buttonRegestrierung
            // 
            buttonRegestrierung.Location = new Point(302, 344);
            buttonRegestrierung.Name = "buttonRegestrierung";
            buttonRegestrierung.Size = new Size(167, 34);
            buttonRegestrierung.TabIndex = 4;
            buttonRegestrierung.Text = "Regestrierung";
            buttonRegestrierung.UseVisualStyleBackColor = true;
            // 
            // textBoxBenutzername
            // 
            textBoxBenutzername.Location = new Point(246, 165);
            textBoxBenutzername.Name = "textBoxBenutzername";
            textBoxBenutzername.Size = new Size(303, 31);
            textBoxBenutzername.TabIndex = 5;
            // 
            // textBoxPasswort
            // 
            textBoxPasswort.Location = new Point(246, 223);
            textBoxPasswort.Name = "textBoxPasswort";
            textBoxPasswort.PasswordChar = '*';
            textBoxPasswort.Size = new Size(303, 31);
            textBoxPasswort.TabIndex = 6;
            // 
            // ViewLoggin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPasswort);
            Controls.Add(textBoxBenutzername);
            Controls.Add(buttonRegestrierung);
            Controls.Add(buttonLoggin);
            Controls.Add(labelPasswort);
            Controls.Add(labelBenutzername);
            Controls.Add(labelLoggin);
            Name = "ViewLoggin";
            Text = "ViewLoggin";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLoggin;
        private Label labelBenutzername;
        private Label labelPasswort;
        private Button buttonLoggin;
        private Button buttonRegestrierung;
        private TextBox textBoxBenutzername;
        private TextBox textBoxPasswort;
    }
}