namespace Notenplana23
{
    partial class ViewLoggin
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
            buttonLoggin = new Button();
            buttonRegestrieren = new Button();
            labelLoggin = new Label();
            labelBenutzername = new Label();
            labelPasswort = new Label();
            textBoxBenutzername = new TextBox();
            textBoxPasswort = new TextBox();
            SuspendLayout();
            // 
            // buttonLoggin
            // 
            buttonLoggin.Location = new Point(314, 307);
            buttonLoggin.Name = "buttonLoggin";
            buttonLoggin.Size = new Size(112, 34);
            buttonLoggin.TabIndex = 0;
            buttonLoggin.Text = "Loggin";
            buttonLoggin.UseVisualStyleBackColor = true;
            // 
            // buttonRegestrieren
            // 
            buttonRegestrieren.Location = new Point(305, 368);
            buttonRegestrieren.Name = "buttonRegestrieren";
            buttonRegestrieren.Size = new Size(130, 34);
            buttonRegestrieren.TabIndex = 1;
            buttonRegestrieren.Text = "Regestrieren";
            buttonRegestrieren.UseVisualStyleBackColor = true;
            // 
            // labelLoggin
            // 
            labelLoggin.AutoSize = true;
            labelLoggin.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelLoggin.Location = new Point(314, 64);
            labelLoggin.Name = "labelLoggin";
            labelLoggin.Size = new Size(110, 41);
            labelLoggin.TabIndex = 2;
            labelLoggin.Text = "Loggin";
            // 
            // labelBenutzername
            // 
            labelBenutzername.AutoSize = true;
            labelBenutzername.Location = new Point(121, 166);
            labelBenutzername.Name = "labelBenutzername";
            labelBenutzername.Size = new Size(133, 25);
            labelBenutzername.TabIndex = 3;
            labelBenutzername.Text = "Benutzername :";
            // 
            // labelPasswort
            // 
            labelPasswort.AutoSize = true;
            labelPasswort.Location = new Point(121, 233);
            labelPasswort.Name = "labelPasswort";
            labelPasswort.Size = new Size(91, 25);
            labelPasswort.TabIndex = 4;
            labelPasswort.Text = "Passwort :";
            // 
            // textBoxBenutzername
            // 
            textBoxBenutzername.Location = new Point(274, 163);
            textBoxBenutzername.Name = "textBoxBenutzername";
            textBoxBenutzername.Size = new Size(234, 31);
            textBoxBenutzername.TabIndex = 5;
            // 
            // textBoxPasswort
            // 
            textBoxPasswort.Location = new Point(274, 233);
            textBoxPasswort.Name = "textBoxPasswort";
            textBoxPasswort.Size = new Size(234, 31);
            textBoxPasswort.TabIndex = 6;
            // 
            // ViewLoggin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPasswort);
            Controls.Add(textBoxBenutzername);
            Controls.Add(labelPasswort);
            Controls.Add(labelBenutzername);
            Controls.Add(labelLoggin);
            Controls.Add(buttonRegestrieren);
            Controls.Add(buttonLoggin);
            Name = "ViewLoggin";
            Text = "ViewLoggin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLoggin;
        private Button buttonRegestrieren;
        private Label labelLoggin;
        private Label labelBenutzername;
        private Label labelPasswort;
        private TextBox textBoxBenutzername;
        private TextBox textBoxPasswort;
    }
}