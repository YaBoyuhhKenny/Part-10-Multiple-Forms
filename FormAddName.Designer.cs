namespace Part_10_Multiple_Forms
{
    partial class FormAddName
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
            this.btnDone = new System.Windows.Forms.Button();
            this.btnAddName = new System.Windows.Forms.Button();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.txtAddNames = new System.Windows.Forms.TextBox();
            this.lblInstuctions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(249, 52);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(93, 22);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(150, 52);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(93, 22);
            this.btnAddName.TabIndex = 1;
            this.btnAddName.Text = "Add";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Location = new System.Drawing.Point(12, 12);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(132, 147);
            this.lstNames.TabIndex = 2;
            // 
            // txtAddNames
            // 
            this.txtAddNames.Location = new System.Drawing.Point(150, 26);
            this.txtAddNames.Name = "txtAddNames";
            this.txtAddNames.Size = new System.Drawing.Size(192, 20);
            this.txtAddNames.TabIndex = 3;
            // 
            // lblInstuctions
            // 
            this.lblInstuctions.AutoSize = true;
            this.lblInstuctions.Location = new System.Drawing.Point(150, 9);
            this.lblInstuctions.Name = "lblInstuctions";
            this.lblInstuctions.Size = new System.Drawing.Size(164, 13);
            this.lblInstuctions.TabIndex = 4;
            this.lblInstuctions.Text = "Enter a name below then hit Add.";
            // 
            // FormAddName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 173);
            this.Controls.Add(this.lblInstuctions);
            this.Controls.Add(this.txtAddNames);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.btnDone);
            this.Name = "FormAddName";
            this.Text = "Add a name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.TextBox txtAddNames;
        private System.Windows.Forms.Label lblInstuctions;
    }
}