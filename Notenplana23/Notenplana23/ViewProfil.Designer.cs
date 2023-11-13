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
            label1 = new Label();
            labelPasswort = new Label();
            textBoxBenutzername = new TextBox();
            textBox2 = new TextBox();
            buttonAbmelden = new Button();
            SuspendLayout();
            // 
            // buttonBearbeiten
            // 
            buttonBearbeiten.Location = new Point(177, 290);
            buttonBearbeiten.Name = "buttonBearbeiten";
            buttonBearbeiten.Size = new Size(112, 34);
            buttonBearbeiten.TabIndex = 1;
            buttonBearbeiten.Text = "Bearbeiten";
            buttonBearbeiten.UseVisualStyleBackColor = true;
            // 
            // buttonLoeschen
            // 
            buttonLoeschen.Location = new Point(430, 290);
            buttonLoeschen.Name = "buttonLoeschen";
            buttonLoeschen.Size = new Size(112, 34);
            buttonLoeschen.TabIndex = 2;
            buttonLoeschen.Text = "Löschen";
            buttonLoeschen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 98);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 3;
            label1.Text = "Benutzername :";
            // 
            // labelPasswort
            // 
            labelPasswort.AutoSize = true;
            labelPasswort.Location = new Point(101, 168);
            labelPasswort.Name = "labelPasswort";
            labelPasswort.Size = new Size(91, 25);
            labelPasswort.TabIndex = 4;
            labelPasswort.Text = "Passwort :";
            // 
            // textBoxBenutzername
            // 
            textBoxBenutzername.Location = new Point(237, 95);
            textBoxBenutzername.Name = "textBoxBenutzername";
            textBoxBenutzername.Size = new Size(350, 31);
            textBoxBenutzername.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(228, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(359, 31);
            textBox2.TabIndex = 6;
            // 
            // buttonAbmelden
            // 
            buttonAbmelden.Location = new Point(306, 373);
            buttonAbmelden.Name = "buttonAbmelden";
            buttonAbmelden.Size = new Size(112, 34);
            buttonAbmelden.TabIndex = 7;
            buttonAbmelden.Text = "Abmelden";
            buttonAbmelden.UseVisualStyleBackColor = true;
            // 
            // ViewProfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAbmelden);
            Controls.Add(textBox2);
            Controls.Add(textBoxBenutzername);
            Controls.Add(labelPasswort);
            Controls.Add(label1);
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
        private Label label1;
        private Label labelPasswort;
        private TextBox textBoxBenutzername;
        private TextBox textBox2;
        private Button buttonAbmelden;
    }
}