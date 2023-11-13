namespace Notenplana23
{
    partial class ViewNote
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
            labelFachname = new Label();
            labelNote = new Label();
            textBoxFachname = new TextBox();
            textBoxNote = new TextBox();
            buttonSpeichern = new Button();
            buttonLoeschen = new Button();
            SuspendLayout();
            // 
            // labelFachname
            // 
            labelFachname.AutoSize = true;
            labelFachname.Location = new Point(55, 108);
            labelFachname.Name = "labelFachname";
            labelFachname.Size = new Size(100, 25);
            labelFachname.TabIndex = 0;
            labelFachname.Text = "Fachname :";
            // 
            // labelNote
            // 
            labelNote.AutoSize = true;
            labelNote.Location = new Point(55, 172);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(60, 25);
            labelNote.TabIndex = 1;
            labelNote.Text = "Note :";
            // 
            // textBoxFachname
            // 
            textBoxFachname.Location = new Point(219, 108);
            textBoxFachname.Name = "textBoxFachname";
            textBoxFachname.Size = new Size(150, 31);
            textBoxFachname.TabIndex = 2;
            // 
            // textBoxNote
            // 
            textBoxNote.Location = new Point(219, 169);
            textBoxNote.Name = "textBoxNote";
            textBoxNote.Size = new Size(150, 31);
            textBoxNote.TabIndex = 3;
            // 
            // buttonSpeichern
            // 
            buttonSpeichern.Location = new Point(127, 309);
            buttonSpeichern.Name = "buttonSpeichern";
            buttonSpeichern.Size = new Size(112, 34);
            buttonSpeichern.TabIndex = 4;
            buttonSpeichern.Text = "Speichern";
            buttonSpeichern.UseVisualStyleBackColor = true;
            // 
            // buttonLoeschen
            // 
            buttonLoeschen.Location = new Point(424, 309);
            buttonLoeschen.Name = "buttonLoeschen";
            buttonLoeschen.Size = new Size(112, 34);
            buttonLoeschen.TabIndex = 5;
            buttonLoeschen.Text = "Löschen";
            buttonLoeschen.UseVisualStyleBackColor = true;
            // 
            // ViewNote
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLoeschen);
            Controls.Add(buttonSpeichern);
            Controls.Add(textBoxNote);
            Controls.Add(textBoxFachname);
            Controls.Add(labelNote);
            Controls.Add(labelFachname);
            Name = "ViewNote";
            Text = "ViewNote";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFachname;
        private Label labelNote;
        private TextBox textBoxFachname;
        private TextBox textBoxNote;
        private Button buttonSpeichern;
        private Button buttonLoeschen;
    }
}