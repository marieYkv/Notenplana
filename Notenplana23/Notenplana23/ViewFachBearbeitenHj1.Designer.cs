namespace Notenplana23
{
    partial class ViewFachBearbeitenHj1
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
            labelFachBearbeiten = new Label();
            labelFach = new Label();
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
            buttonZurueck.Click += buttonZurueck_Click;
            // 
            // labelFachBearbeiten
            // 
            labelFachBearbeiten.AutoSize = true;
            labelFachBearbeiten.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelFachBearbeiten.Location = new Point(108, 73);
            labelFachBearbeiten.Name = "labelFachBearbeiten";
            labelFachBearbeiten.Size = new Size(229, 41);
            labelFachBearbeiten.TabIndex = 1;
            labelFachBearbeiten.Text = "Fach bearbeiten";
            // 
            // labelFach
            // 
            labelFach.AutoSize = true;
            labelFach.Location = new Point(108, 157);
            labelFach.Name = "labelFach";
            labelFach.Size = new Size(51, 25);
            labelFach.TabIndex = 10;
            labelFach.Text = "Fach:";
            // 
            // ViewFachBearbeitenHj1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelFach);
            Controls.Add(labelFachBearbeiten);
            Controls.Add(buttonZurueck);
            Name = "ViewFachBearbeitenHj1";
            Text = "ViewFachBearbeitenHj1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonZurueck;
        private Label labelFachBearbeiten;
        private Label labelFach;
    }
}