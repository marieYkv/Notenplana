namespace Notenplana23
{
    partial class ViewProfil
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
            buttonBearbeiten = new Button();
            buttonLoeschen = new Button();
            labelBenutzername = new Label();
            labelPasswort = new Label();
            textBoxBenutzername = new TextBox();
            textBoxPasswort = new TextBox();
            buttonAbmelden = new Button();
            labelProfil = new Label();
            buttonZurueck = new Button();
            SuspendLayout();
            // 
            // buttonBearbeiten
            // 
            buttonBearbeiten.Location = new Point(139, 290);
            buttonBearbeiten.Name = "buttonBearbeiten";
            buttonBearbeiten.Size = new Size(112, 34);
            buttonBearbeiten.TabIndex = 1;
            buttonBearbeiten.Text = "Bearbeiten";
            buttonBearbeiten.UseVisualStyleBackColor = true;
            // 
            // buttonLoeschen
            // 
            buttonLoeschen.Location = new Point(509, 290);
            buttonLoeschen.Name = "buttonLoeschen";
            buttonLoeschen.Size = new Size(112, 34);
            buttonLoeschen.TabIndex = 2;
            buttonLoeschen.Text = "Löschen";
            buttonLoeschen.UseVisualStyleBackColor = true;
            // 
            // labelBenutzername
            // 
            labelBenutzername.AutoSize = true;
            labelBenutzername.Location = new Point(83, 111);
            labelBenutzername.Name = "labelBenutzername";
            labelBenutzername.Size = new Size(133, 25);
            labelBenutzername.TabIndex = 3;
            labelBenutzername.Text = "Benutzername :";
            // 
            // labelPasswort
            // 
            labelPasswort.AutoSize = true;
            labelPasswort.Location = new Point(83, 181);
            labelPasswort.Name = "labelPasswort";
            labelPasswort.Size = new Size(91, 25);
            labelPasswort.TabIndex = 4;
            labelPasswort.Text = "Passwort :";
            // 
            // textBoxBenutzername
            // 
            textBoxBenutzername.Location = new Point(237, 108);
            textBoxBenutzername.Name = "textBoxBenutzername";
            textBoxBenutzername.Size = new Size(350, 31);
            textBoxBenutzername.TabIndex = 5;
            // 
            // textBoxPasswort
            // 
            textBoxPasswort.Location = new Point(237, 178);
            textBoxPasswort.Name = "textBoxPasswort";
            textBoxPasswort.Size = new Size(359, 31);
            textBoxPasswort.TabIndex = 6;
            // 
            // buttonAbmelden
            // 
            buttonAbmelden.Location = new Point(331, 290);
            buttonAbmelden.Name = "buttonAbmelden";
            buttonAbmelden.Size = new Size(112, 34);
            buttonAbmelden.TabIndex = 7;
            buttonAbmelden.Text = "Abmelden";
            buttonAbmelden.UseVisualStyleBackColor = true;
            // 
            // labelProfil
            // 
            labelProfil.AutoSize = true;
            labelProfil.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelProfil.Location = new Point(341, 31);
            labelProfil.Name = "labelProfil";
            labelProfil.Size = new Size(86, 41);
            labelProfil.TabIndex = 8;
            labelProfil.Text = "Profil";
            // 
            // buttonZurueck
            // 
            buttonZurueck.Location = new Point(12, 12);
            buttonZurueck.Name = "buttonZurueck";
            buttonZurueck.Size = new Size(112, 34);
            buttonZurueck.TabIndex = 9;
            buttonZurueck.Text = "Zurück";
            buttonZurueck.UseVisualStyleBackColor = true;
            // 
            // ViewProfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonZurueck);
            Controls.Add(labelProfil);
            Controls.Add(buttonAbmelden);
            Controls.Add(textBoxPasswort);
            Controls.Add(textBoxBenutzername);
            Controls.Add(labelPasswort);
            Controls.Add(labelBenutzername);
            Controls.Add(buttonLoeschen);
            Controls.Add(buttonBearbeiten);
            Name = "ViewProfil";
            Text = "ViewProfil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBearbeiten;
        private Button buttonLoeschen;
        private Label labelBenutzername;
        private Label labelPasswort;
        private TextBox textBoxBenutzername;
        private TextBox textBoxPasswort;
        private Button buttonAbmelden;
        private Label labelProfil;
        private Button buttonZurueck;
    }
}