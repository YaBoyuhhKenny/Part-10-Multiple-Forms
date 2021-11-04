namespace Part_10_Multiple_Forms
{
    partial class FormChangeName
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
            this.lstNames = new System.Windows.Forms.ListBox();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtChangeNames = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Location = new System.Drawing.Point(195, 12);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(166, 212);
            this.lstNames.TabIndex = 0;
            // 
            // btnChangeName
            // 
            this.btnChangeName.Location = new System.Drawing.Point(8, 64);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(87, 31);
            this.btnChangeName.TabIndex = 1;
            this.btnChangeName.Text = "Change";
            this.btnChangeName.UseVisualStyleBackColor = true;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructions.Location = new System.Drawing.Point(5, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(184, 26);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Type a new name than hit change to \r\nchange the selected name";
            // 
            // txtChangeNames
            // 
            this.txtChangeNames.Location = new System.Drawing.Point(8, 38);
            this.txtChangeNames.Name = "txtChangeNames";
            this.txtChangeNames.Size = new System.Drawing.Size(145, 20);
            this.txtChangeNames.TabIndex = 3;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(8, 101);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(87, 31);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(12, 230);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(0, 13);
            this.lblSelected.TabIndex = 5;
            // 
            // FormChangeName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 252);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtChangeNames);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnChangeName);
            this.Controls.Add(this.lstNames);
            this.Name = "FormChangeName";
            this.Text = "Change names";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtChangeNames;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblSelected;
    }
}