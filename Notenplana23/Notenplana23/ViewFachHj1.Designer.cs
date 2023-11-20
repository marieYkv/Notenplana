namespace Notenplana23
{
    partial class ViewFachHj1
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
            labelFachEinfuegen = new Label();
            labelFachname = new Label();
            textBoxFachname = new TextBox();
            checkBoxPruefungsfach = new CheckBox();
            buttonSpeichern = new Button();
            buttonBearbeiten = new Button();
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
            // labelFachEinfuegen
            // 
            labelFachEinfuegen.AutoSize = true;
            labelFachEinfuegen.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelFachEinfuegen.Location = new Point(250, 73);
            labelFachEinfuegen.Name = "labelFachEinfuegen";
            labelFachEinfuegen.Size = new Size(203, 41);
            labelFachEinfuegen.TabIndex = 1;
            labelFachEinfuegen.Text = "Fach einfügen";
            // 
            // labelFachname
            // 
            labelFachname.AutoSize = true;
            labelFachname.Location = new Point(250, 164);
            labelFachname.Name = "labelFachname";
            labelFachname.Size = new Size(91, 25);
            labelFachname.TabIndex = 2;
            labelFachname.Text = "Fachname";
            // 
            // textBoxFachname
            // 
            textBoxFachname.Location = new Point(370, 161);
            textBoxFachname.Name = "textBoxFachname";
            textBoxFachname.Size = new Size(150, 31);
            textBoxFachname.TabIndex = 3;
            // 
            // checkBoxPruefungsfach
            // 
            checkBoxPruefungsfach.AutoSize = true;
            checkBoxPruefungsfach.Location = new Point(250, 230);
            checkBoxPruefungsfach.Name = "checkBoxPruefungsfach";
            checkBoxPruefungsfach.Size = new Size(150, 29);
            checkBoxPruefungsfach.TabIndex = 4;
            checkBoxPruefungsfach.Text = "Prüfungsfach?";
            checkBoxPruefungsfach.UseVisualStyleBackColor = true;
            // 
            // buttonSpeichern
            // 
            buttonSpeichern.Location = new Point(196, 288);
            buttonSpeichern.Name = "buttonSpeichern";
            buttonSpeichern.Size = new Size(112, 34);
            buttonSpeichern.TabIndex = 5;
            buttonSpeichern.Text = "Speichern";
            buttonSpeichern.UseVisualStyleBackColor = true;
            // 
            // buttonBearbeiten
            // 
            buttonBearbeiten.Location = new Point(408, 288);
            buttonBearbeiten.Name = "buttonBearbeiten";
            buttonBearbeiten.Size = new Size(112, 34);
            buttonBearbeiten.TabIndex = 6;
            buttonBearbeiten.Text = "Bearbeiten";
            buttonBearbeiten.UseVisualStyleBackColor = true;
            // 
            // ViewFachHj1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBearbeiten);
            Controls.Add(buttonSpeichern);
            Controls.Add(checkBoxPruefungsfach);
            Controls.Add(textBoxFachname);
            Controls.Add(labelFachname);
            Controls.Add(labelFachEinfuegen);
            Controls.Add(buttonZurueck);
            Name = "ViewFachHj1";
            Text = "ViewFachHj1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonZurueck;
        private Label labelFachEinfuegen;
        private Label labelFachname;
        private TextBox textBoxFachname;
        private CheckBox checkBoxPruefungsfach;
        private Button buttonSpeichern;
        private Button buttonBearbeiten;
    }
}