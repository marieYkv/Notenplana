namespace Notenplana23
{
    partial class ViewFachHj2
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
            buttonBearbeiten = new Button();
            checkBoxPruefungsfach = new CheckBox();
            textBoxFachname = new TextBox();
            labelFachEinfuegen = new Label();
            labelFachname = new Label();
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
            buttonSpeichern.Location = new Point(186, 299);
            buttonSpeichern.Name = "buttonSpeichern";
            buttonSpeichern.Size = new Size(112, 34);
            buttonSpeichern.TabIndex = 1;
            buttonSpeichern.Text = "Speichern";
            buttonSpeichern.UseVisualStyleBackColor = true;
            // 
            // buttonBearbeiten
            // 
            buttonBearbeiten.Location = new Point(439, 299);
            buttonBearbeiten.Name = "buttonBearbeiten";
            buttonBearbeiten.Size = new Size(112, 34);
            buttonBearbeiten.TabIndex = 2;
            buttonBearbeiten.Text = "Bearbeiten";
            buttonBearbeiten.UseVisualStyleBackColor = true;
            // 
            // checkBoxPruefungsfach
            // 
            checkBoxPruefungsfach.AutoSize = true;
            checkBoxPruefungsfach.Location = new Point(245, 202);
            checkBoxPruefungsfach.Name = "checkBoxPruefungsfach";
            checkBoxPruefungsfach.Size = new Size(150, 29);
            checkBoxPruefungsfach.TabIndex = 3;
            checkBoxPruefungsfach.Text = "Prüfungsfach?";
            checkBoxPruefungsfach.UseVisualStyleBackColor = true;
            // 
            // textBoxFachname
            // 
            textBoxFachname.Location = new Point(346, 140);
            textBoxFachname.Name = "textBoxFachname";
            textBoxFachname.Size = new Size(185, 31);
            textBoxFachname.TabIndex = 4;
            // 
            // labelFachEinfuegen
            // 
            labelFachEinfuegen.AutoSize = true;
            labelFachEinfuegen.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelFachEinfuegen.Location = new Point(289, 68);
            labelFachEinfuegen.Name = "labelFachEinfuegen";
            labelFachEinfuegen.Size = new Size(203, 41);
            labelFachEinfuegen.TabIndex = 5;
            labelFachEinfuegen.Text = "Fach einfügen";
            // 
            // labelFachname
            // 
            labelFachname.AutoSize = true;
            labelFachname.Location = new Point(233, 143);
            labelFachname.Name = "labelFachname";
            labelFachname.Size = new Size(91, 25);
            labelFachname.TabIndex = 6;
            labelFachname.Text = "Fachname";
            // 
            // ViewFachHj2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelFachname);
            Controls.Add(labelFachEinfuegen);
            Controls.Add(textBoxFachname);
            Controls.Add(checkBoxPruefungsfach);
            Controls.Add(buttonBearbeiten);
            Controls.Add(buttonSpeichern);
            Controls.Add(buttonZurueck);
            Name = "ViewFachHj2";
            Text = "ViewFachHj2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonZurueck;
        private Button buttonSpeichern;
        private Button buttonBearbeiten;
        private CheckBox checkBoxPruefungsfach;
        private TextBox textBoxFachname;
        private Label labelFachEinfuegen;
        private Label labelFachname;
    }
}