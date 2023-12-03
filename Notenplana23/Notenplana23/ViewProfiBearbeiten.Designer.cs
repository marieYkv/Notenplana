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
            this.buttonZurueck = new System.Windows.Forms.Button();
            this.labelProfilBearbeiten = new System.Windows.Forms.Label();
            this.labelBenutzername = new System.Windows.Forms.Label();
            this.labelPasswort = new System.Windows.Forms.Label();
            this.textBoxBenutzername = new System.Windows.Forms.TextBox();
            this.textBoxPasswort = new System.Windows.Forms.TextBox();
            this.buttonBearbeiten = new System.Windows.Forms.Button();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.buttonLoeschen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonZurueck
            // 
            this.buttonZurueck.Location = new System.Drawing.Point(10, 10);
            this.buttonZurueck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonZurueck.Name = "buttonZurueck";
            this.buttonZurueck.Size = new System.Drawing.Size(90, 27);
            this.buttonZurueck.TabIndex = 0;
            this.buttonZurueck.Text = "Zurück";
            this.buttonZurueck.UseVisualStyleBackColor = true;
            this.buttonZurueck.Click += new System.EventHandler(this.buttonZurueck_Click);
            // 
            // labelProfilBearbeiten
            // 
            this.labelProfilBearbeiten.AutoSize = true;
            this.labelProfilBearbeiten.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProfilBearbeiten.Location = new System.Drawing.Point(208, 68);
            this.labelProfilBearbeiten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProfilBearbeiten.Name = "labelProfilBearbeiten";
            this.labelProfilBearbeiten.Size = new System.Drawing.Size(198, 35);
            this.labelProfilBearbeiten.TabIndex = 1;
            this.labelProfilBearbeiten.Text = "Profil Bearbeiten";
            // 
            // labelBenutzername
            // 
            this.labelBenutzername.AutoSize = true;
            this.labelBenutzername.Location = new System.Drawing.Point(148, 143);
            this.labelBenutzername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBenutzername.Name = "labelBenutzername";
            this.labelBenutzername.Size = new System.Drawing.Size(111, 20);
            this.labelBenutzername.TabIndex = 2;
            this.labelBenutzername.Text = "Benutzername :";
            // 
            // labelPasswort
            // 
            this.labelPasswort.AutoSize = true;
            this.labelPasswort.Location = new System.Drawing.Point(148, 190);
            this.labelPasswort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasswort.Name = "labelPasswort";
            this.labelPasswort.Size = new System.Drawing.Size(73, 20);
            this.labelPasswort.TabIndex = 3;
            this.labelPasswort.Text = "Passwort :";
            // 
            // textBoxBenutzername
            // 
            this.textBoxBenutzername.Enabled = false;
            this.textBoxBenutzername.Location = new System.Drawing.Point(274, 147);
            this.textBoxBenutzername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBenutzername.Name = "textBoxBenutzername";
            this.textBoxBenutzername.Size = new System.Drawing.Size(213, 27);
            this.textBoxBenutzername.TabIndex = 4;
            // 
            // textBoxPasswort
            // 
            this.textBoxPasswort.Enabled = false;
            this.textBoxPasswort.Location = new System.Drawing.Point(274, 185);
            this.textBoxPasswort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPasswort.Name = "textBoxPasswort";
            this.textBoxPasswort.Size = new System.Drawing.Size(213, 27);
            this.textBoxPasswort.TabIndex = 5;
            // 
            // buttonBearbeiten
            // 
            this.buttonBearbeiten.Location = new System.Drawing.Point(158, 262);
            this.buttonBearbeiten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBearbeiten.Name = "buttonBearbeiten";
            this.buttonBearbeiten.Size = new System.Drawing.Size(90, 27);
            this.buttonBearbeiten.TabIndex = 6;
            this.buttonBearbeiten.Text = "Bearbeiten";
            this.buttonBearbeiten.UseVisualStyleBackColor = true;
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(274, 262);
            this.buttonSpeichern.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(90, 27);
            this.buttonSpeichern.TabIndex = 7;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            // 
            // buttonLoeschen
            // 
            this.buttonLoeschen.Location = new System.Drawing.Point(396, 262);
            this.buttonLoeschen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLoeschen.Name = "buttonLoeschen";
            this.buttonLoeschen.Size = new System.Drawing.Size(90, 27);
            this.buttonLoeschen.TabIndex = 8;
            this.buttonLoeschen.Text = "Löschen";
            this.buttonLoeschen.UseVisualStyleBackColor = true;
            // 
            // ViewProfiBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.buttonLoeschen);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.buttonBearbeiten);
            this.Controls.Add(this.textBoxPasswort);
            this.Controls.Add(this.textBoxBenutzername);
            this.Controls.Add(this.labelPasswort);
            this.Controls.Add(this.labelBenutzername);
            this.Controls.Add(this.labelProfilBearbeiten);
            this.Controls.Add(this.buttonZurueck);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewProfiBearbeiten";
            this.Text = "ViewProfiBearbeiten";
            this.ResumeLayout(false);
            this.PerformLayout();

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