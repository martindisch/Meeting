namespace Meeting
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbData = new System.Windows.Forms.GroupBox();
            this.lbSubjects = new System.Windows.Forms.ListBox();
            this.bAddSubject = new System.Windows.Forms.Button();
            this.lbParticipants = new System.Windows.Forms.ListBox();
            this.bAddParticipants = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.gbMeetings = new System.Windows.Forms.GroupBox();
            this.bGenerate = new System.Windows.Forms.Button();
            this.lbMeetings = new System.Windows.Forms.ListBox();
            this.gbData.SuspendLayout();
            this.gbMeetings.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.bAddParticipants);
            this.gbData.Controls.Add(this.lbParticipants);
            this.gbData.Controls.Add(this.bAddSubject);
            this.gbData.Controls.Add(this.lbSubjects);
            this.gbData.Location = new System.Drawing.Point(13, 13);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(338, 526);
            this.gbData.TabIndex = 0;
            this.gbData.TabStop = false;
            this.gbData.Text = "Grunddaten";
            // 
            // lbSubjects
            // 
            this.lbSubjects.FormattingEnabled = true;
            this.lbSubjects.ItemHeight = 16;
            this.lbSubjects.Location = new System.Drawing.Point(7, 22);
            this.lbSubjects.Name = "lbSubjects";
            this.lbSubjects.Size = new System.Drawing.Size(325, 180);
            this.lbSubjects.TabIndex = 0;
            // 
            // bAddSubject
            // 
            this.bAddSubject.Location = new System.Drawing.Point(165, 209);
            this.bAddSubject.Name = "bAddSubject";
            this.bAddSubject.Size = new System.Drawing.Size(167, 28);
            this.bAddSubject.TabIndex = 1;
            this.bAddSubject.Text = "Thema hinzufügen";
            this.bAddSubject.UseVisualStyleBackColor = true;
            this.bAddSubject.Click += new System.EventHandler(this.bAddSubject_Click);
            // 
            // lbParticipants
            // 
            this.lbParticipants.FormattingEnabled = true;
            this.lbParticipants.ItemHeight = 16;
            this.lbParticipants.Location = new System.Drawing.Point(7, 244);
            this.lbParticipants.Name = "lbParticipants";
            this.lbParticipants.Size = new System.Drawing.Size(325, 244);
            this.lbParticipants.TabIndex = 2;
            // 
            // bAddParticipants
            // 
            this.bAddParticipants.Location = new System.Drawing.Point(166, 494);
            this.bAddParticipants.Name = "bAddParticipants";
            this.bAddParticipants.Size = new System.Drawing.Size(166, 28);
            this.bAddParticipants.TabIndex = 3;
            this.bAddParticipants.Text = "Teilnehmer hinzufügen";
            this.bAddParticipants.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(670, 545);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(160, 28);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Daten speichern";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(504, 545);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(160, 28);
            this.bLoad.TabIndex = 5;
            this.bLoad.Text = "Daten laden";
            this.bLoad.UseVisualStyleBackColor = true;
            // 
            // gbMeetings
            // 
            this.gbMeetings.Controls.Add(this.lbMeetings);
            this.gbMeetings.Location = new System.Drawing.Point(371, 13);
            this.gbMeetings.Name = "gbMeetings";
            this.gbMeetings.Size = new System.Drawing.Size(559, 526);
            this.gbMeetings.TabIndex = 1;
            this.gbMeetings.TabStop = false;
            this.gbMeetings.Text = "Treffen";
            // 
            // bGenerate
            // 
            this.bGenerate.Location = new System.Drawing.Point(836, 545);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(94, 28);
            this.bGenerate.TabIndex = 1;
            this.bGenerate.Text = "Generieren";
            this.bGenerate.UseVisualStyleBackColor = true;
            // 
            // lbMeetings
            // 
            this.lbMeetings.FormattingEnabled = true;
            this.lbMeetings.ItemHeight = 16;
            this.lbMeetings.Location = new System.Drawing.Point(7, 22);
            this.lbMeetings.Name = "lbMeetings";
            this.lbMeetings.Size = new System.Drawing.Size(546, 500);
            this.lbMeetings.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 582);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bGenerate);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.gbMeetings);
            this.Controls.Add(this.gbData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meeting";
            this.gbData.ResumeLayout(false);
            this.gbMeetings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.ListBox lbSubjects;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bAddParticipants;
        private System.Windows.Forms.ListBox lbParticipants;
        private System.Windows.Forms.Button bAddSubject;
        private System.Windows.Forms.GroupBox gbMeetings;
        private System.Windows.Forms.ListBox lbMeetings;
        private System.Windows.Forms.Button bGenerate;
    }
}

