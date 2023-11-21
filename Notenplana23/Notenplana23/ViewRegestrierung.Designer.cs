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
            textBoxBenutzername = new TextBox();
            textBoxPasswort = new TextBox();
            buttonSpeichern = new Button();
            buttonZurueck = new Button();
            SuspendLayout();
            // 
            // labelRegestrierung
            // 
            labelRegestrierung.AutoSize = true;
            labelRegestrierung.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegestrierung.Location = new Point(302, 47);
            labelRegestrierung.Name = "labelRegestrierung";
            labelRegestrierung.Size = new Size(203, 41);
            labelRegestrierung.TabIndex = 0;
            labelRegestrierung.Text = "Regestrierung";
            // 
            // labelBenutzername
            // 
            labelBenutzername.AutoSize = true;
            labelBenutzername.Location = new Point(113, 131);
            labelBenutzername.Name = "labelBenutzername";
            labelBenutzername.Size = new Size(133, 25);
            labelBenutzername.TabIndex = 1;
            labelBenutzername.Text = "Benutzername :";
            // 
            // labelPasswort
            // 
            labelPasswort.AutoSize = true;
            labelPasswort.Location = new Point(113, 207);
            labelPasswort.Name = "labelPasswort";
            labelPasswort.Size = new Size(91, 25);
            labelPasswort.TabIndex = 2;
            labelPasswort.Text = "Passwort :";
            // 
            // textBoxBenutzername
            // 
            textBoxBenutzername.Location = new Point(302, 128);
            textBoxBenutzername.Name = "textBoxBenutzername";
            textBoxBenutzername.Size = new Size(203, 31);
            textBoxBenutzername.TabIndex = 3;
            // 
            // textBoxPasswort
            // 
            textBoxPasswort.Location = new Point(302, 204);
            textBoxPasswort.Name = "textBoxPasswort";
            textBoxPasswort.Size = new Size(203, 31);
            textBoxPasswort.TabIndex = 4;
            // 
            // buttonSpeichern
            // 
            buttonSpeichern.Location = new Point(343, 301);
            buttonSpeichern.Name = "buttonSpeichern";
            buttonSpeichern.Size = new Size(112, 34);
            buttonSpeichern.TabIndex = 5;
            buttonSpeichern.Text = "Speichern";
            buttonSpeichern.UseVisualStyleBackColor = true;
            buttonSpeichern.Click += buttonSpeichern_Click;
            // 
            // buttonZurueck
            // 
            buttonZurueck.Location = new Point(12, 12);
            buttonZurueck.Name = "buttonZurueck";
            buttonZurueck.Size = new Size(112, 34);
            buttonZurueck.TabIndex = 6;
            buttonZurueck.Text = "Zurück";
            buttonZurueck.UseVisualStyleBackColor = true;
            // 
            // ViewRegestrierung
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonZurueck);
            Controls.Add(buttonSpeichern);
            Controls.Add(textBoxPasswort);
            Controls.Add(textBoxBenutzername);
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
        private TextBox textBoxBenutzername;
        private TextBox textBoxPasswort;
        private Button buttonSpeichern;
        private Button buttonZurueck;
    }
}