namespace Notenplana23
{
    partial class ViewNoteHj2
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
            buttonSpeichern = new Button();
            textBoxNote3 = new TextBox();
            textBoxNote2 = new TextBox();
            textBoxNote1 = new TextBox();
            comboBoxFachname = new ComboBox();
            buttonZurueck = new Button();
            labelNote3 = new Label();
            labelNote2 = new Label();
            labelNote1 = new Label();
            labelFachname = new Label();
            labelNoteEinfuegen = new Label();
            SuspendLayout();
            // 
            // buttonBearbeiten
            // 
            buttonBearbeiten.Location = new Point(438, 366);
            buttonBearbeiten.Name = "buttonBearbeiten";
            buttonBearbeiten.Size = new Size(112, 34);
            buttonBearbeiten.TabIndex = 23;
            buttonBearbeiten.Text = "Bearbeiten";
            buttonBearbeiten.UseVisualStyleBackColor = true;
            // 
            // buttonSpeichern
            // 
            buttonSpeichern.Location = new Point(219, 366);
            buttonSpeichern.Name = "buttonSpeichern";
            buttonSpeichern.Size = new Size(112, 34);
            buttonSpeichern.TabIndex = 22;
            buttonSpeichern.Text = "Speichern";
            buttonSpeichern.UseVisualStyleBackColor = true;
            // 
            // textBoxNote3
            // 
            textBoxNote3.Location = new Point(275, 307);
            textBoxNote3.Name = "textBoxNote3";
            textBoxNote3.Size = new Size(96, 31);
            textBoxNote3.TabIndex = 21;
            // 
            // textBoxNote2
            // 
            textBoxNote2.Location = new Point(275, 255);
            textBoxNote2.Name = "textBoxNote2";
            textBoxNote2.Size = new Size(96, 31);
            textBoxNote2.TabIndex = 20;
            // 
            // textBoxNote1
            // 
            textBoxNote1.Location = new Point(275, 206);
            textBoxNote1.Name = "textBoxNote1";
            textBoxNote1.Size = new Size(96, 31);
            textBoxNote1.TabIndex = 19;
            // 
            // comboBoxFachname
            // 
            comboBoxFachname.FormattingEnabled = true;
            comboBoxFachname.Location = new Point(275, 149);
            comboBoxFachname.Name = "comboBoxFachname";
            comboBoxFachname.Size = new Size(182, 33);
            comboBoxFachname.TabIndex = 18;
            // 
            // buttonZurueck
            // 
            buttonZurueck.Location = new Point(12, 12);
            buttonZurueck.Name = "buttonZurueck";
            buttonZurueck.Size = new Size(112, 34);
            buttonZurueck.TabIndex = 17;
            buttonZurueck.Text = "Zurück";
            buttonZurueck.UseVisualStyleBackColor = true;
            // 
            // labelNote3
            // 
            labelNote3.AutoSize = true;
            labelNote3.Location = new Point(147, 310);
            labelNote3.Name = "labelNote3";
            labelNote3.Size = new Size(75, 25);
            labelNote3.TabIndex = 16;
            labelNote3.Text = "Note 3 :";
            // 
            // labelNote2
            // 
            labelNote2.AutoSize = true;
            labelNote2.Location = new Point(147, 261);
            labelNote2.Name = "labelNote2";
            labelNote2.Size = new Size(75, 25);
            labelNote2.TabIndex = 15;
            labelNote2.Text = "Note 2 :";
            // 
            // labelNote1
            // 
            labelNote1.AutoSize = true;
            labelNote1.Location = new Point(147, 209);
            labelNote1.Name = "labelNote1";
            labelNote1.Size = new Size(75, 25);
            labelNote1.TabIndex = 14;
            labelNote1.Text = "Note 1 :";
            // 
            // labelFachname
            // 
            labelFachname.AutoSize = true;
            labelFachname.Location = new Point(147, 152);
            labelFachname.Name = "labelFachname";
            labelFachname.Size = new Size(100, 25);
            labelFachname.TabIndex = 13;
            labelFachname.Text = "Fachname :";
            // 
            // labelNoteEinfuegen
            // 
            labelNoteEinfuegen.AutoSize = true;
            labelNoteEinfuegen.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelNoteEinfuegen.Location = new Point(275, 68);
            labelNoteEinfuegen.Name = "labelNoteEinfuegen";
            labelNoteEinfuegen.Size = new Size(209, 41);
            labelNoteEinfuegen.TabIndex = 12;
            labelNoteEinfuegen.Text = "Note einfügen";
            // 
            // ViewNoteHj2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBearbeiten);
            Controls.Add(buttonSpeichern);
            Controls.Add(textBoxNote3);
            Controls.Add(textBoxNote2);
            Controls.Add(textBoxNote1);
            Controls.Add(comboBoxFachname);
            Controls.Add(buttonZurueck);
            Controls.Add(labelNote3);
            Controls.Add(labelNote2);
            Controls.Add(labelNote1);
            Controls.Add(labelFachname);
            Controls.Add(labelNoteEinfuegen);
            Name = "ViewNoteHj2";
            Text = "ViewNoteHj2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBearbeiten;
        private Button buttonSpeichern;
        private TextBox textBoxNote3;
        private TextBox textBoxNote2;
        private TextBox textBoxNote1;
        private ComboBox comboBoxFachname;
        private Button buttonZurueck;
        private Label labelNote3;
        private Label labelNote2;
        private Label labelNote1;
        private Label labelFachname;
        private Label labelNoteEinfuegen;
    }
}