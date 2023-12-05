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
            labelBenutzername = new Label();
            buttonAbmelden = new Button();
            labelProfil = new Label();
            buttonZurueck = new Button();
            labelName = new Label();
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
            buttonBearbeiten.Click += buttonBearbeiten_Click;
            // 
            // labelBenutzername
            // 
            labelBenutzername.AutoSize = true;
            labelBenutzername.Location = new Point(139, 122);
            labelBenutzername.Name = "labelBenutzername";
            labelBenutzername.Size = new Size(133, 25);
            labelBenutzername.TabIndex = 3;
            labelBenutzername.Text = "Benutzername :";
            // 
            // buttonAbmelden
            // 
            buttonAbmelden.Location = new Point(465, 290);
            buttonAbmelden.Name = "buttonAbmelden";
            buttonAbmelden.Size = new Size(112, 34);
            buttonAbmelden.TabIndex = 7;
            buttonAbmelden.Text = "Abmelden";
            buttonAbmelden.UseVisualStyleBackColor = true;
            buttonAbmelden.Click += buttonAbmelden_Click;
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
            buttonZurueck.Click += buttonZurueck_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(315, 122);
            labelName.Name = "labelName";
            labelName.Size = new Size(96, 25);
            labelName.TabIndex = 10;
            labelName.Text = "labelName";
            // 
            // ViewProfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelName);
            Controls.Add(buttonZurueck);
            Controls.Add(labelProfil);
            Controls.Add(buttonAbmelden);
            Controls.Add(labelBenutzername);
            Controls.Add(buttonBearbeiten);
            Name = "ViewProfil";
            Text = "ViewProfil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBearbeiten;
        private Label labelBenutzername;
        private Button buttonAbmelden;
        private Label labelProfil;
        private Button buttonZurueck;
        private Label labelName;
    }
}