namespace Notenplana23
{
    partial class ViewHauptprogramm
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
            labelAlarmwertFach = new Label();
            labelAlarmwertPruefungsfach = new Label();
            linkLabelFachHinzufuegen1 = new LinkLabel();
            linkLabelFachHinzufuegen2 = new LinkLabel();
            linkLabelProfil = new LinkLabel();
            textBoxAlarmwertFach = new TextBox();
            textBoxAlarmwertPruefungsfach = new TextBox();
            labelErstesHalbjahr = new Label();
            labelZweitesHalbjahr = new Label();
            SuspendLayout();
            // 
            // labelAlarmwertFach
            // 
            labelAlarmwertFach.AutoSize = true;
            labelAlarmwertFach.Location = new Point(31, 40);
            labelAlarmwertFach.Name = "labelAlarmwertFach";
            labelAlarmwertFach.Size = new Size(142, 25);
            labelAlarmwertFach.TabIndex = 0;
            labelAlarmwertFach.Text = "Alarmwert Fach :";
            // 
            // labelAlarmwertPruefungsfach
            // 
            labelAlarmwertPruefungsfach.AutoSize = true;
            labelAlarmwertPruefungsfach.Location = new Point(31, 113);
            labelAlarmwertPruefungsfach.Name = "labelAlarmwertPruefungsfach";
            labelAlarmwertPruefungsfach.Size = new Size(211, 25);
            labelAlarmwertPruefungsfach.TabIndex = 1;
            labelAlarmwertPruefungsfach.Text = "Alarmwert Prüfungsfach :";
            // 
            // linkLabelFachHinzufuegen1
            // 
            linkLabelFachHinzufuegen1.AutoSize = true;
            linkLabelFachHinzufuegen1.Location = new Point(61, 288);
            linkLabelFachHinzufuegen1.Name = "linkLabelFachHinzufuegen1";
            linkLabelFachHinzufuegen1.Size = new Size(157, 25);
            linkLabelFachHinzufuegen1.TabIndex = 2;
            linkLabelFachHinzufuegen1.TabStop = true;
            linkLabelFachHinzufuegen1.Text = "+ Fach hinzufügen";
            // 
            // linkLabelFachHinzufuegen2
            // 
            linkLabelFachHinzufuegen2.AutoSize = true;
            linkLabelFachHinzufuegen2.Location = new Point(61, 374);
            linkLabelFachHinzufuegen2.Name = "linkLabelFachHinzufuegen2";
            linkLabelFachHinzufuegen2.Size = new Size(157, 25);
            linkLabelFachHinzufuegen2.TabIndex = 3;
            linkLabelFachHinzufuegen2.TabStop = true;
            linkLabelFachHinzufuegen2.Text = "+ Fach hinzufügen";
            // 
            // linkLabelProfil
            // 
            linkLabelProfil.AutoSize = true;
            linkLabelProfil.Location = new Point(636, 37);
            linkLabelProfil.Name = "linkLabelProfil";
            linkLabelProfil.Size = new Size(53, 25);
            linkLabelProfil.TabIndex = 4;
            linkLabelProfil.TabStop = true;
            linkLabelProfil.Text = "Profil";
            // 
            // textBoxAlarmwertFach
            // 
            textBoxAlarmwertFach.Location = new Point(260, 37);
            textBoxAlarmwertFach.Name = "textBoxAlarmwertFach";
            textBoxAlarmwertFach.Size = new Size(70, 31);
            textBoxAlarmwertFach.TabIndex = 5;
            // 
            // textBoxAlarmwertPruefungsfach
            // 
            textBoxAlarmwertPruefungsfach.Location = new Point(260, 110);
            textBoxAlarmwertPruefungsfach.Name = "textBoxAlarmwertPruefungsfach";
            textBoxAlarmwertPruefungsfach.Size = new Size(70, 31);
            textBoxAlarmwertPruefungsfach.TabIndex = 6;
            // 
            // labelErstesHalbjahr
            // 
            labelErstesHalbjahr.AutoSize = true;
            labelErstesHalbjahr.Location = new Point(31, 250);
            labelErstesHalbjahr.Name = "labelErstesHalbjahr";
            labelErstesHalbjahr.Size = new Size(129, 25);
            labelErstesHalbjahr.TabIndex = 7;
            labelErstesHalbjahr.Text = "Erstes Halbjahr";
            // 
            // labelZweitesHalbjahr
            // 
            labelZweitesHalbjahr.AutoSize = true;
            labelZweitesHalbjahr.Location = new Point(31, 333);
            labelZweitesHalbjahr.Name = "labelZweitesHalbjahr";
            labelZweitesHalbjahr.Size = new Size(142, 25);
            labelZweitesHalbjahr.TabIndex = 8;
            labelZweitesHalbjahr.Text = "Zweites Halbjahr";
            // 
            // ViewHauptprogramm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelZweitesHalbjahr);
            Controls.Add(labelErstesHalbjahr);
            Controls.Add(textBoxAlarmwertPruefungsfach);
            Controls.Add(textBoxAlarmwertFach);
            Controls.Add(linkLabelProfil);
            Controls.Add(linkLabelFachHinzufuegen2);
            Controls.Add(linkLabelFachHinzufuegen1);
            Controls.Add(labelAlarmwertPruefungsfach);
            Controls.Add(labelAlarmwertFach);
            Name = "ViewHauptprogramm";
            Text = "ViewHauptprogramm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAlarmwertFach;
        private Label labelAlarmwertPruefungsfach;
        private LinkLabel linkLabelFachHinzufuegen1;
        private LinkLabel linkLabelFachHinzufuegen2;
        private LinkLabel linkLabelProfil;
        private TextBox textBoxAlarmwertFach;
        private TextBox textBoxAlarmwertPruefungsfach;
        private Label labelErstesHalbjahr;
        private Label labelZweitesHalbjahr;
    }
}