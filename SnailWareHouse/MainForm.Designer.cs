namespace SnailWareHouse
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableDelete_bt = new System.Windows.Forms.Button();
            this.tableCreate_bt = new System.Windows.Forms.Button();
            this.searchTextInput = new System.Windows.Forms.TextBox();
            this.entryDelete_bt = new System.Windows.Forms.Button();
            this.entryUpdate_bt = new System.Windows.Forms.Button();
            this.entrySearch_bt = new System.Windows.Forms.Button();
            this.entryCreate_bt = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableList = new System.Windows.Forms.ListBox();
            this.dataViewer = new System.Windows.Forms.DataGridView();
            this.tooltip_createTableBt = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableDelete_bt);
            this.splitContainer1.Panel1.Controls.Add(this.tableCreate_bt);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.searchTextInput);
            this.splitContainer1.Panel2.Controls.Add(this.entryDelete_bt);
            this.splitContainer1.Panel2.Controls.Add(this.entryUpdate_bt);
            this.splitContainer1.Panel2.Controls.Add(this.entrySearch_bt);
            this.splitContainer1.Panel2.Controls.Add(this.entryCreate_bt);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1246, 63);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 8;
            // 
            // tableDelete_bt
            // 
            this.tableDelete_bt.Image = global::SnailWareHouse.Properties.Resources.DeleteDatabase_png;
            this.tableDelete_bt.Location = new System.Drawing.Point(136, 4);
            this.tableDelete_bt.Name = "tableDelete_bt";
            this.tableDelete_bt.Size = new System.Drawing.Size(131, 56);
            this.tableDelete_bt.TabIndex = 1;
            this.tooltip_createTableBt.SetToolTip(this.tableDelete_bt, "Delete table. First delect a table below then press this button to delete it.");
            this.tableDelete_bt.UseVisualStyleBackColor = true;
            this.tableDelete_bt.Click += new System.EventHandler(this.tableDelete_bt_Click);
            // 
            // tableCreate_bt
            // 
            this.tableCreate_bt.Image = global::SnailWareHouse.Properties.Resources.AddDatabase1_png;
            this.tableCreate_bt.Location = new System.Drawing.Point(6, 4);
            this.tableCreate_bt.Name = "tableCreate_bt";
            this.tableCreate_bt.Size = new System.Drawing.Size(128, 56);
            this.tableCreate_bt.TabIndex = 0;
            this.tableCreate_bt.Tag = "";
            this.tooltip_createTableBt.SetToolTip(this.tableCreate_bt, "Create table");
            this.tableCreate_bt.UseVisualStyleBackColor = true;
            this.tableCreate_bt.Click += new System.EventHandler(this.tableCreate_bt_Click);
            // 
            // searchTextInput
            // 
            this.searchTextInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextInput.Location = new System.Drawing.Point(512, 4);
            this.searchTextInput.Name = "searchTextInput";
            this.searchTextInput.Size = new System.Drawing.Size(459, 55);
            this.searchTextInput.TabIndex = 4;
            this.tooltip_createTableBt.SetToolTip(this.searchTextInput, "enter search text here");
            // 
            // entryDelete_bt
            // 
            this.entryDelete_bt.Image = global::SnailWareHouse.Properties.Resources.DeleteRow_png;
            this.entryDelete_bt.Location = new System.Drawing.Point(130, 3);
            this.entryDelete_bt.Name = "entryDelete_bt";
            this.entryDelete_bt.Size = new System.Drawing.Size(121, 57);
            this.entryDelete_bt.TabIndex = 1;
            this.tooltip_createTableBt.SetToolTip(this.entryDelete_bt, "Delete Entry. First select a row then press this button to delete.");
            this.entryDelete_bt.UseVisualStyleBackColor = true;
            this.entryDelete_bt.Click += new System.EventHandler(this.entryDelete_bt_Click);
            // 
            // entryUpdate_bt
            // 
            this.entryUpdate_bt.Image = global::SnailWareHouse.Properties.Resources.EditRow_png;
            this.entryUpdate_bt.Location = new System.Drawing.Point(257, 3);
            this.entryUpdate_bt.Name = "entryUpdate_bt";
            this.entryUpdate_bt.Size = new System.Drawing.Size(121, 57);
            this.entryUpdate_bt.TabIndex = 2;
            this.tooltip_createTableBt.SetToolTip(this.entryUpdate_bt, "Update entry. First select a row then press this button to update its cells.");
            this.entryUpdate_bt.UseVisualStyleBackColor = true;
            this.entryUpdate_bt.Click += new System.EventHandler(this.entryUpdate_bt_Click);
            // 
            // entrySearch_bt
            // 
            this.entrySearch_bt.Image = global::SnailWareHouse.Properties.Resources.Filter_png;
            this.entrySearch_bt.Location = new System.Drawing.Point(384, 3);
            this.entrySearch_bt.Name = "entrySearch_bt";
            this.entrySearch_bt.Size = new System.Drawing.Size(121, 57);
            this.entrySearch_bt.TabIndex = 3;
            this.tooltip_createTableBt.SetToolTip(this.entrySearch_bt, "Search entry");
            this.entrySearch_bt.UseVisualStyleBackColor = true;
            this.entrySearch_bt.Click += new System.EventHandler(this.entrySearch_bt_Click);
            // 
            // entryCreate_bt
            // 
            this.entryCreate_bt.Image = global::SnailWareHouse.Properties.Resources.AddRow_png;
            this.entryCreate_bt.Location = new System.Drawing.Point(3, 3);
            this.entryCreate_bt.Name = "entryCreate_bt";
            this.entryCreate_bt.Size = new System.Drawing.Size(121, 57);
            this.entryCreate_bt.TabIndex = 0;
            this.tooltip_createTableBt.SetToolTip(this.entryCreate_bt, "Add entry");
            this.entryCreate_bt.UseVisualStyleBackColor = true;
            this.entryCreate_bt.Click += new System.EventHandler(this.entryCreate_bt_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 63);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableList);
            this.splitContainer2.Panel1MinSize = 0;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataViewer);
            this.splitContainer2.Panel2MinSize = 0;
            this.splitContainer2.Size = new System.Drawing.Size(1246, 560);
            this.splitContainer2.SplitterDistance = 271;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.TabStop = false;
            // 
            // tableList
            // 
            this.tableList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableList.FormattingEnabled = true;
            this.tableList.ItemHeight = 31;
            this.tableList.Location = new System.Drawing.Point(0, 0);
            this.tableList.Name = "tableList";
            this.tableList.ScrollAlwaysVisible = true;
            this.tableList.Size = new System.Drawing.Size(271, 560);
            this.tableList.TabIndex = 0;
            this.tableList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tableList_MouseClick);
            // 
            // dataViewer
            // 
            this.dataViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataViewer.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewer.Location = new System.Drawing.Point(0, 0);
            this.dataViewer.Name = "dataViewer";
            this.dataViewer.ReadOnly = true;
            this.dataViewer.RowTemplate.Height = 24;
            this.dataViewer.ShowEditingIcon = false;
            this.dataViewer.Size = new System.Drawing.Size(974, 560);
            this.dataViewer.TabIndex = 0;
            this.tooltip_createTableBt.SetToolTip(this.dataViewer, "Select a table on the right to display its content here.");
            this.dataViewer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataViewer_RowHeaderMouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 623);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1264, 670);
            this.Name = "MainForm";
            this.Text = "Snail - WareHouse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tableCreate_bt;
        private System.Windows.Forms.Button entryCreate_bt;
        private System.Windows.Forms.Button entryUpdate_bt;
        private System.Windows.Forms.Button entryDelete_bt;
        private System.Windows.Forms.Button entrySearch_bt;
        private System.Windows.Forms.Button tableDelete_bt;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox searchTextInput;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox tableList;
        private System.Windows.Forms.DataGridView dataViewer;
        private System.Windows.Forms.ToolTip tooltip_createTableBt;
    }
}

