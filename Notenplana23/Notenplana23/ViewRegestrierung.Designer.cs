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
            this.buttonZurueck = new System.Windows.Forms.Button();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.labelRegestrierung = new System.Windows.Forms.Label();
            this.labelBenutzername = new System.Windows.Forms.Label();
            this.labelPasswort = new System.Windows.Forms.Label();
            this.textBoxBenutzername = new System.Windows.Forms.TextBox();
            this.textBoxPasswort = new System.Windows.Forms.TextBox();
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
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(258, 253);
            this.buttonSpeichern.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(90, 27);
            this.buttonSpeichern.TabIndex = 1;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // labelRegestrierung
            // 
            this.labelRegestrierung.AutoSize = true;
            this.labelRegestrierung.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRegestrierung.Location = new System.Drawing.Point(229, 62);
            this.labelRegestrierung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegestrierung.Name = "labelRegestrierung";
            this.labelRegestrierung.Size = new System.Drawing.Size(169, 35);
            this.labelRegestrierung.TabIndex = 2;
            this.labelRegestrierung.Text = "Regestrierung";
            // 
            // labelBenutzername
            // 
            this.labelBenutzername.AutoSize = true;
            this.labelBenutzername.Location = new System.Drawing.Point(98, 133);
            this.labelBenutzername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBenutzername.Name = "labelBenutzername";
            this.labelBenutzername.Size = new System.Drawing.Size(111, 20);
            this.labelBenutzername.TabIndex = 3;
            this.labelBenutzername.Text = "Benutzername :";
            // 
            // labelPasswort
            // 
            this.labelPasswort.AutoSize = true;
            this.labelPasswort.Location = new System.Drawing.Point(98, 187);
            this.labelPasswort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasswort.Name = "labelPasswort";
            this.labelPasswort.Size = new System.Drawing.Size(73, 20);
            this.labelPasswort.TabIndex = 4;
            this.labelPasswort.Text = "Passwort :";
            // 
            // textBoxBenutzername
            // 
            this.textBoxBenutzername.Location = new System.Drawing.Point(229, 133);
            this.textBoxBenutzername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBenutzername.Name = "textBoxBenutzername";
            this.textBoxBenutzername.Size = new System.Drawing.Size(163, 27);
            this.textBoxBenutzername.TabIndex = 5;
            // 
            // textBoxPasswort
            // 
            this.textBoxPasswort.Location = new System.Drawing.Point(229, 185);
            this.textBoxPasswort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPasswort.Name = "textBoxPasswort";
            this.textBoxPasswort.Size = new System.Drawing.Size(163, 27);
            this.textBoxPasswort.TabIndex = 6;
            // 
            // ViewRegestrierung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.textBoxPasswort);
            this.Controls.Add(this.textBoxBenutzername);
            this.Controls.Add(this.labelPasswort);
            this.Controls.Add(this.labelBenutzername);
            this.Controls.Add(this.labelRegestrierung);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.buttonZurueck);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewRegestrierung";
            this.Text = "ViewRegestrierung";
            this.ResumeLayout(false);
            this.PerformLayout();

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