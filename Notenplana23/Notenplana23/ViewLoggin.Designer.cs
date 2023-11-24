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
            this.buttonLoggin = new System.Windows.Forms.Button();
            this.buttonRegestrieren = new System.Windows.Forms.Button();
            this.labelLoggin = new System.Windows.Forms.Label();
            this.labelBenutzername = new System.Windows.Forms.Label();
            this.labelPasswort = new System.Windows.Forms.Label();
            this.textBoxBenutzername = new System.Windows.Forms.TextBox();
            this.textBoxPasswort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLoggin
            // 
            this.buttonLoggin.Location = new System.Drawing.Point(251, 246);
            this.buttonLoggin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoggin.Name = "buttonLoggin";
            this.buttonLoggin.Size = new System.Drawing.Size(90, 27);
            this.buttonLoggin.TabIndex = 0;
            this.buttonLoggin.Text = "Loggin";
            this.buttonLoggin.UseVisualStyleBackColor = true;
            this.buttonLoggin.Click += new System.EventHandler(this.buttonLoggin_Click);
            // 
            // buttonRegestrieren
            // 
            this.buttonRegestrieren.Location = new System.Drawing.Point(244, 294);
            this.buttonRegestrieren.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegestrieren.Name = "buttonRegestrieren";
            this.buttonRegestrieren.Size = new System.Drawing.Size(104, 27);
            this.buttonRegestrieren.TabIndex = 1;
            this.buttonRegestrieren.Text = "Regestrieren";
            this.buttonRegestrieren.UseVisualStyleBackColor = true;
            this.buttonRegestrieren.Click += new System.EventHandler(this.buttonRegestrieren_Click);
            // 
            // labelLoggin
            // 
            this.labelLoggin.AutoSize = true;
            this.labelLoggin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoggin.Location = new System.Drawing.Point(251, 51);
            this.labelLoggin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoggin.Name = "labelLoggin";
            this.labelLoggin.Size = new System.Drawing.Size(92, 35);
            this.labelLoggin.TabIndex = 2;
            this.labelLoggin.Text = "Loggin";
            // 
            // labelBenutzername
            // 
            this.labelBenutzername.AutoSize = true;
            this.labelBenutzername.Location = new System.Drawing.Point(97, 133);
            this.labelBenutzername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBenutzername.Name = "labelBenutzername";
            this.labelBenutzername.Size = new System.Drawing.Size(111, 20);
            this.labelBenutzername.TabIndex = 3;
            this.labelBenutzername.Text = "Benutzername :";
            // 
            // labelPasswort
            // 
            this.labelPasswort.AutoSize = true;
            this.labelPasswort.Location = new System.Drawing.Point(97, 186);
            this.labelPasswort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasswort.Name = "labelPasswort";
            this.labelPasswort.Size = new System.Drawing.Size(73, 20);
            this.labelPasswort.TabIndex = 4;
            this.labelPasswort.Text = "Passwort :";
            // 
            // textBoxBenutzername
            // 
            this.textBoxBenutzername.Location = new System.Drawing.Point(219, 130);
            this.textBoxBenutzername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBenutzername.Name = "textBoxBenutzername";
            this.textBoxBenutzername.Size = new System.Drawing.Size(188, 27);
            this.textBoxBenutzername.TabIndex = 5;
            // 
            // textBoxPasswort
            // 
            this.textBoxPasswort.Location = new System.Drawing.Point(219, 186);
            this.textBoxPasswort.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPasswort.Name = "textBoxPasswort";
            this.textBoxPasswort.Size = new System.Drawing.Size(188, 27);
            this.textBoxPasswort.TabIndex = 6;
            // 
            // ViewLoggin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.textBoxPasswort);
            this.Controls.Add(this.textBoxBenutzername);
            this.Controls.Add(this.labelPasswort);
            this.Controls.Add(this.labelBenutzername);
            this.Controls.Add(this.labelLoggin);
            this.Controls.Add(this.buttonRegestrieren);
            this.Controls.Add(this.buttonLoggin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewLoggin";
            this.Text = "ViewLoggin";
            this.ResumeLayout(false);
            this.PerformLayout();

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