namespace ListOrganizer
{
    partial class frmListOrganizer
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
            this.lstItemsViewer = new System.Windows.Forms.ListBox();
            this.lblListOfItems = new System.Windows.Forms.Label();
            this.btnNumberOfEntries = new System.Windows.Forms.Button();
            this.btnEntriesInList = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnFindEntry = new System.Windows.Forms.Button();
            this.btnDisableAccess = new System.Windows.Forms.Button();
            this.btnEnableAccess = new System.Windows.Forms.Button();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.btnRemoveEntry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstItemsViewer
            // 
            this.lstItemsViewer.FormattingEnabled = true;
            this.lstItemsViewer.Location = new System.Drawing.Point(26, 56);
            this.lstItemsViewer.Name = "lstItemsViewer";
            this.lstItemsViewer.Size = new System.Drawing.Size(314, 212);
            this.lstItemsViewer.TabIndex = 0;
            // 
            // lblListOfItems
            // 
            this.lblListOfItems.Font = new System.Drawing.Font("Geneva", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfItems.Location = new System.Drawing.Point(40, 17);
            this.lblListOfItems.Name = "lblListOfItems";
            this.lblListOfItems.Size = new System.Drawing.Size(280, 25);
            this.lblListOfItems.TabIndex = 1;
            this.lblListOfItems.Text = "The Item Organizer";
            this.lblListOfItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblListOfItems.Click += new System.EventHandler(this.lblListOfEntries_Click);
            // 
            // btnNumberOfEntries
            // 
            this.btnNumberOfEntries.Location = new System.Drawing.Point(27, 323);
            this.btnNumberOfEntries.Name = "btnNumberOfEntries";
            this.btnNumberOfEntries.Size = new System.Drawing.Size(98, 29);
            this.btnNumberOfEntries.TabIndex = 4;
            this.btnNumberOfEntries.Text = "# of Entries";
            this.btnNumberOfEntries.UseVisualStyleBackColor = true;
            this.btnNumberOfEntries.Click += new System.EventHandler(this.btnNumberOfEntries_Click);
            // 
            // btnEntriesInList
            // 
            this.btnEntriesInList.Location = new System.Drawing.Point(135, 323);
            this.btnEntriesInList.Name = "btnEntriesInList";
            this.btnEntriesInList.Size = new System.Drawing.Size(98, 29);
            this.btnEntriesInList.TabIndex = 5;
            this.btnEntriesInList.Text = "Show All Entries";
            this.btnEntriesInList.UseVisualStyleBackColor = true;
            this.btnEntriesInList.Click += new System.EventHandler(this.btnEntriesInList_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(243, 323);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(98, 29);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnFindEntry
            // 
            this.btnFindEntry.Location = new System.Drawing.Point(243, 288);
            this.btnFindEntry.Name = "btnFindEntry";
            this.btnFindEntry.Size = new System.Drawing.Size(98, 29);
            this.btnFindEntry.TabIndex = 6;
            this.btnFindEntry.Text = "Find Entry";
            this.btnFindEntry.UseVisualStyleBackColor = true;
            this.btnFindEntry.Click += new System.EventHandler(this.btnFindEntry_Click);
            // 
            // btnDisableAccess
            // 
            this.btnDisableAccess.Location = new System.Drawing.Point(46, 368);
            this.btnDisableAccess.Name = "btnDisableAccess";
            this.btnDisableAccess.Size = new System.Drawing.Size(129, 39);
            this.btnDisableAccess.TabIndex = 8;
            this.btnDisableAccess.Text = "Disable Access";
            this.btnDisableAccess.UseVisualStyleBackColor = true;
            this.btnDisableAccess.Click += new System.EventHandler(this.btnDisableEntry_Click);
            // 
            // btnEnableAccess
            // 
            this.btnEnableAccess.Location = new System.Drawing.Point(189, 368);
            this.btnEnableAccess.Name = "btnEnableAccess";
            this.btnEnableAccess.Size = new System.Drawing.Size(129, 39);
            this.btnEnableAccess.TabIndex = 9;
            this.btnEnableAccess.Text = "Enable Access";
            this.btnEnableAccess.UseVisualStyleBackColor = true;
            this.btnEnableAccess.Click += new System.EventHandler(this.btnEnableEntry_Click);
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Location = new System.Drawing.Point(27, 288);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(98, 29);
            this.btnAddEntry.TabIndex = 2;
            this.btnAddEntry.Text = "Add";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // btnRemoveEntry
            // 
            this.btnRemoveEntry.Location = new System.Drawing.Point(135, 288);
            this.btnRemoveEntry.Name = "btnRemoveEntry";
            this.btnRemoveEntry.Size = new System.Drawing.Size(98, 29);
            this.btnRemoveEntry.TabIndex = 3;
            this.btnRemoveEntry.Text = "Remove";
            this.btnRemoveEntry.UseVisualStyleBackColor = true;
            this.btnRemoveEntry.Click += new System.EventHandler(this.btnRemoveEntry_Click);
            // 
            // frmListOrganizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 422);
            this.Controls.Add(this.btnEnableAccess);
            this.Controls.Add(this.btnDisableAccess);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnFindEntry);
            this.Controls.Add(this.btnEntriesInList);
            this.Controls.Add(this.btnNumberOfEntries);
            this.Controls.Add(this.btnRemoveEntry);
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(this.lblListOfItems);
            this.Controls.Add(this.lstItemsViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmListOrganizer";
            this.Text = "List Organizer";
            this.Load += new System.EventHandler(this.frmListOrganizer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstItemsViewer;
        private System.Windows.Forms.Label lblListOfItems;
        private System.Windows.Forms.Button btnNumberOfEntries;
        private System.Windows.Forms.Button btnEntriesInList;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnFindEntry;
        private System.Windows.Forms.Button btnDisableAccess;
        private System.Windows.Forms.Button btnEnableAccess;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.Button btnRemoveEntry;
    }
}

