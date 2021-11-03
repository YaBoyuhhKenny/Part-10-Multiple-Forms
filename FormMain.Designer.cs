namespace Part_10_Multiple_Forms
{
    partial class FormMain
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
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnRemoveNames = new System.Windows.Forms.Button();
            this.btnEditName = new System.Windows.Forms.Button();
            this.lstnames = new System.Windows.Forms.ListBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(12, 12);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(90, 25);
            this.btnAddName.TabIndex = 0;
            this.btnAddName.Text = "Add name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnRemoveNames
            // 
            this.btnRemoveNames.Location = new System.Drawing.Point(12, 74);
            this.btnRemoveNames.Name = "btnRemoveNames";
            this.btnRemoveNames.Size = new System.Drawing.Size(90, 25);
            this.btnRemoveNames.TabIndex = 1;
            this.btnRemoveNames.Text = "Remove names";
            this.btnRemoveNames.UseVisualStyleBackColor = true;
            this.btnRemoveNames.Click += new System.EventHandler(this.btnRemoveNames_Click);
            // 
            // btnEditName
            // 
            this.btnEditName.Location = new System.Drawing.Point(12, 43);
            this.btnEditName.Name = "btnEditName";
            this.btnEditName.Size = new System.Drawing.Size(90, 25);
            this.btnEditName.TabIndex = 2;
            this.btnEditName.Text = "Edit name";
            this.btnEditName.UseVisualStyleBackColor = true;
            // 
            // lstnames
            // 
            this.lstnames.FormattingEnabled = true;
            this.lstnames.Location = new System.Drawing.Point(108, 8);
            this.lstnames.Name = "lstnames";
            this.lstnames.Size = new System.Drawing.Size(139, 186);
            this.lstnames.TabIndex = 3;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(12, 168);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(90, 25);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 205);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lstnames);
            this.Controls.Add(this.btnEditName);
            this.Controls.Add(this.btnRemoveNames);
            this.Controls.Add(this.btnAddName);
            this.Name = "FormMain";
            this.Text = "Main form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnRemoveNames;
        private System.Windows.Forms.Button btnEditName;
        private System.Windows.Forms.ListBox lstnames;
        private System.Windows.Forms.Button btnQuit;
    }
}

