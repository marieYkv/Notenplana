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
            buttonZurueck = new Button();
            buttonSpeichern = new Button();
            labelRegestrierung = new Label();
            labelBenutzername = new Label();
            labelPasswort = new Label();
            textBoxBenutzername = new TextBox();
            textBoxPasswort = new TextBox();
            SuspendLayout();
            // 
            // buttonZurueck
            // 
            buttonZurueck.Location = new Point(12, 12);
            buttonZurueck.Name = "buttonZurueck";
            buttonZurueck.Size = new Size(112, 34);
            buttonZurueck.TabIndex = 0;
            buttonZurueck.Text = "Zurück";
            buttonZurueck.UseVisualStyleBackColor = true;
            // 
            // buttonSpeichern
            // 
            buttonSpeichern.Location = new Point(322, 316);
            buttonSpeichern.Name = "buttonSpeichern";
            buttonSpeichern.Size = new Size(112, 34);
            buttonSpeichern.TabIndex = 1;
            buttonSpeichern.Text = "Speichern";
            buttonSpeichern.UseVisualStyleBackColor = true;
            buttonSpeichern.Click += buttonSpeichern_Click;
            // 
            // labelRegestrierung
            // 
            labelRegestrierung.AutoSize = true;
            labelRegestrierung.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegestrierung.Location = new Point(286, 77);
            labelRegestrierung.Name = "labelRegestrierung";
            labelRegestrierung.Size = new Size(203, 41);
            labelRegestrierung.TabIndex = 2;
            labelRegestrierung.Text = "Regestrierung";
            // 
            // labelBenutzername
            // 
            labelBenutzername.AutoSize = true;
            labelBenutzername.Location = new Point(122, 166);
            labelBenutzername.Name = "labelBenutzername";
            labelBenutzername.Size = new Size(133, 25);
            labelBenutzername.TabIndex = 3;
            labelBenutzername.Text = "Benutzername :";
            // 
            // labelPasswort
            // 
            labelPasswort.AutoSize = true;
            labelPasswort.Location = new Point(122, 234);
            labelPasswort.Name = "labelPasswort";
            labelPasswort.Size = new Size(91, 25);
            labelPasswort.TabIndex = 4;
            labelPasswort.Text = "Passwort :";
            // 
            // textBoxBenutzername
            // 
            textBoxBenutzername.Location = new Point(286, 166);
            textBoxBenutzername.Name = "textBoxBenutzername";
            textBoxBenutzername.Size = new Size(203, 31);
            textBoxBenutzername.TabIndex = 5;
            // 
            // textBoxPasswort
            // 
            textBoxPasswort.Location = new Point(286, 231);
            textBoxPasswort.Name = "textBoxPasswort";
            textBoxPasswort.Size = new Size(203, 31);
            textBoxPasswort.TabIndex = 6;
            // 
            // ViewRegestrierung
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPasswort);
            Controls.Add(textBoxBenutzername);
            Controls.Add(labelPasswort);
            Controls.Add(labelBenutzername);
            Controls.Add(labelRegestrierung);
            Controls.Add(buttonSpeichern);
            Controls.Add(buttonZurueck);
            Name = "ViewRegestrierung";
            Text = "ViewRegestrierung";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonZurueck;
        private Button buttonSpeichern;
        private Label labelRegestrierung;
        private Label labelBenutzername;
        private Label labelPasswort;
        private TextBox textBoxBenutzername;
        private TextBox textBoxPasswort;
    }
}