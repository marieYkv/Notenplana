namespace Notenplana23
{
    partial class ViewProfiBearbeiten
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
            labelProfilBearbeiten = new Label();
            labelBenutzername = new Label();
            labelPasswort = new Label();
            textBoxBenutzername = new TextBox();
            textBoxPasswort = new TextBox();
            buttonBearbeiten = new Button();
            buttonSpeichern = new Button();
            buttonLoeschen = new Button();
            SuspendLayout();
            // 
            // buttonZurueck
            // 
            buttonZurueck.Location = new Point(12, 12);
            buttonZurueck.Margin = new Padding(2);
            buttonZurueck.Name = "buttonZurueck";
            buttonZurueck.Size = new Size(112, 34);
            buttonZurueck.TabIndex = 0;
            buttonZurueck.Text = "Zurück";
            buttonZurueck.UseVisualStyleBackColor = true;
            buttonZurueck.Click += buttonZurueck_Click;
            // 
            // labelProfilBearbeiten
            // 
            labelProfilBearbeiten.AutoSize = true;
            labelProfilBearbeiten.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelProfilBearbeiten.Location = new Point(260, 85);
            labelProfilBearbeiten.Margin = new Padding(2, 0, 2, 0);
            labelProfilBearbeiten.Name = "labelProfilBearbeiten";
            labelProfilBearbeiten.Size = new Size(236, 41);
            labelProfilBearbeiten.TabIndex = 1;
            labelProfilBearbeiten.Text = "Profil Bearbeiten";
            // 
            // labelBenutzername
            // 
            labelBenutzername.AutoSize = true;
            labelBenutzername.Location = new Point(185, 179);
            labelBenutzername.Margin = new Padding(2, 0, 2, 0);
            labelBenutzername.Name = "labelBenutzername";
            labelBenutzername.Size = new Size(133, 25);
            labelBenutzername.TabIndex = 2;
            labelBenutzername.Text = "Benutzername :";
            // 
            // labelPasswort
            // 
            labelPasswort.AutoSize = true;
            labelPasswort.Location = new Point(185, 238);
            labelPasswort.Margin = new Padding(2, 0, 2, 0);
            labelPasswort.Name = "labelPasswort";
            labelPasswort.Size = new Size(91, 25);
            labelPasswort.TabIndex = 3;
            labelPasswort.Text = "Passwort :";
            // 
            // textBoxBenutzername
            // 
            textBoxBenutzername.Enabled = false;
            textBoxBenutzername.Location = new Point(342, 184);
            textBoxBenutzername.Margin = new Padding(2);
            textBoxBenutzername.Name = "textBoxBenutzername";
            textBoxBenutzername.Size = new Size(265, 31);
            textBoxBenutzername.TabIndex = 4;
            // 
            // textBoxPasswort
            // 
            textBoxPasswort.Enabled = false;
            textBoxPasswort.Location = new Point(342, 231);
            textBoxPasswort.Margin = new Padding(2);
            textBoxPasswort.Name = "textBoxPasswort";
            textBoxPasswort.Size = new Size(265, 31);
            textBoxPasswort.TabIndex = 5;
            // 
            // buttonBearbeiten
            // 
            buttonBearbeiten.Location = new Point(198, 328);
            buttonBearbeiten.Margin = new Padding(2);
            buttonBearbeiten.Name = "buttonBearbeiten";
            buttonBearbeiten.Size = new Size(112, 34);
            buttonBearbeiten.TabIndex = 6;
            buttonBearbeiten.Text = "Bearbeiten";
            buttonBearbeiten.UseVisualStyleBackColor = true;
            buttonBearbeiten.Click += buttonBearbeiten_Click;
            // 
            // buttonSpeichern
            // 
            buttonSpeichern.Enabled = false;
            buttonSpeichern.Location = new Point(342, 328);
            buttonSpeichern.Margin = new Padding(2);
            buttonSpeichern.Name = "buttonSpeichern";
            buttonSpeichern.Size = new Size(112, 34);
            buttonSpeichern.TabIndex = 7;
            buttonSpeichern.Text = "Speichern";
            buttonSpeichern.UseVisualStyleBackColor = true;
            buttonSpeichern.Click += buttonSpeichern_Click;
            // 
            // buttonLoeschen
            // 
            buttonLoeschen.Enabled = false;
            buttonLoeschen.Location = new Point(495, 328);
            buttonLoeschen.Margin = new Padding(2);
            buttonLoeschen.Name = "buttonLoeschen";
            buttonLoeschen.Size = new Size(112, 34);
            buttonLoeschen.TabIndex = 8;
            buttonLoeschen.Text = "Löschen";
            buttonLoeschen.UseVisualStyleBackColor = true;
            buttonLoeschen.Click += buttonLoeschen_Click;
            // 
            // ViewProfiBearbeiten
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLoeschen);
            Controls.Add(buttonSpeichern);
            Controls.Add(buttonBearbeiten);
            Controls.Add(textBoxPasswort);
            Controls.Add(textBoxBenutzername);
            Controls.Add(labelPasswort);
            Controls.Add(labelBenutzername);
            Controls.Add(labelProfilBearbeiten);
            Controls.Add(buttonZurueck);
            Margin = new Padding(2);
            Name = "ViewProfiBearbeiten";
            Text = "ViewProfiBearbeiten";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonZurueck;
        private Label labelProfilBearbeiten;
        private Label labelBenutzername;
        private Label labelPasswort;
        private TextBox textBoxBenutzername;
        private TextBox textBoxPasswort;
        private Button buttonBearbeiten;
        private Button buttonSpeichern;
        private Button buttonLoeschen;
    }
}