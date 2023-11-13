namespace Notenplana23
{
    partial class ViewFach
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
            checkBoxPruefungsfach = new CheckBox();
            textBoxFachname = new TextBox();
            buttonSpeichern = new Button();
            buttonLoeschen = new Button();
            SuspendLayout();
            // 
            // labelFachname
            // 
            labelFachname.AutoSize = true;
            labelFachname.Location = new Point(116, 126);
            labelFachname.Name = "labelFachname";
            labelFachname.Size = new Size(100, 25);
            labelFachname.TabIndex = 0;
            labelFachname.Text = "Fachname :";
            // 
            // checkBoxPruefungsfach
            // 
            checkBoxPruefungsfach.AutoSize = true;
            checkBoxPruefungsfach.Location = new Point(116, 205);
            checkBoxPruefungsfach.Name = "checkBoxPruefungsfach";
            checkBoxPruefungsfach.Size = new Size(155, 29);
            checkBoxPruefungsfach.TabIndex = 2;
            checkBoxPruefungsfach.Text = "Prüfungsfach ?";
            checkBoxPruefungsfach.UseVisualStyleBackColor = true;
            // 
            // textBoxFachname
            // 
            textBoxFachname.Location = new Point(240, 126);
            textBoxFachname.Name = "textBoxFachname";
            textBoxFachname.Size = new Size(150, 31);
            textBoxFachname.TabIndex = 3;
            // 
            // buttonSpeichern
            // 
            buttonSpeichern.Location = new Point(124, 295);
            buttonSpeichern.Name = "buttonSpeichern";
            buttonSpeichern.Size = new Size(112, 34);
            buttonSpeichern.TabIndex = 4;
            buttonSpeichern.Text = "Speichern";
            buttonSpeichern.UseVisualStyleBackColor = true;
            // 
            // buttonLoeschen
            // 
            buttonLoeschen.Location = new Point(398, 295);
            buttonLoeschen.Name = "buttonLoeschen";
            buttonLoeschen.Size = new Size(112, 34);
            buttonLoeschen.TabIndex = 5;
            buttonLoeschen.Text = "Löschen";
            buttonLoeschen.UseVisualStyleBackColor = true;
            // 
            // ViewFach
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLoeschen);
            Controls.Add(buttonSpeichern);
            Controls.Add(textBoxFachname);
            Controls.Add(checkBoxPruefungsfach);
            Controls.Add(labelFachname);
            Name = "ViewFach";
            Text = "ViewFach";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFachname;
        private CheckBox checkBoxPruefungsfach;
        private TextBox textBoxFachname;
        private Button buttonSpeichern;
        private Button buttonLoeschen;
    }
}