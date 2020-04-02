namespace GetGrid
{
    partial class mainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.infoStatus = new System.Windows.Forms.StatusStrip();
            this.info = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuTableName = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miTableNameDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnGetDelete = new System.Windows.Forms.Button();
            this.btnGetUpdate = new System.Windows.Forms.Button();
            this.lblTableName = new System.Windows.Forms.Label();
            this.btnGetInsert = new System.Windows.Forms.Button();
            this.cmbTableName = new System.Windows.Forms.ComboBox();
            this.btnRefreshGrid = new System.Windows.Forms.Button();
            this.menuConfig = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miOpenLog = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.infoStatus.SuspendLayout();
            this.menuTableName.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.menuConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoStatus
            // 
            this.infoStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.info});
            this.infoStatus.Location = new System.Drawing.Point(0, 418);
            this.infoStatus.Name = "infoStatus";
            this.infoStatus.Size = new System.Drawing.Size(658, 22);
            this.infoStatus.TabIndex = 2;
            this.infoStatus.Text = "GetGrid";
            // 
            // info
            // 
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 17);
            // 
            // menuTableName
            // 
            this.menuTableName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTableNameDelete});
            this.menuTableName.Name = "menuTableName";
            this.menuTableName.Size = new System.Drawing.Size(99, 26);
            // 
            // miTableNameDelete
            // 
            this.miTableNameDelete.Name = "miTableNameDelete";
            this.miTableNameDelete.Size = new System.Drawing.Size(98, 22);
            this.miTableNameDelete.Text = "削除";
            this.miTableNameDelete.Click += new System.EventHandler(this.miTableNameDelete_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlControl);
            this.splitContainer1.Panel2MinSize = 70;
            this.splitContainer1.Size = new System.Drawing.Size(658, 418);
            this.splitContainer1.SplitterDistance = 344;
            this.splitContainer1.TabIndex = 9;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 21;
            this.dataGridView.Size = new System.Drawing.Size(658, 344);
            this.dataGridView.TabIndex = 1;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btnMenu);
            this.pnlControl.Controls.Add(this.btnGetDelete);
            this.pnlControl.Controls.Add(this.btnGetUpdate);
            this.pnlControl.Controls.Add(this.lblTableName);
            this.pnlControl.Controls.Add(this.btnGetInsert);
            this.pnlControl.Controls.Add(this.cmbTableName);
            this.pnlControl.Controls.Add(this.btnRefreshGrid);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(658, 70);
            this.pnlControl.TabIndex = 8;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMenu.Location = new System.Drawing.Point(621, 38);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(25, 24);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.Text = "...";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnGetDelete
            // 
            this.btnGetDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGetDelete.Location = new System.Drawing.Point(534, 38);
            this.btnGetDelete.Name = "btnGetDelete";
            this.btnGetDelete.Size = new System.Drawing.Size(81, 24);
            this.btnGetDelete.TabIndex = 11;
            this.btnGetDelete.Text = "DELETE";
            this.btnGetDelete.UseVisualStyleBackColor = true;
            this.btnGetDelete.Click += new System.EventHandler(this.btnGetDelete_Click);
            // 
            // btnGetUpdate
            // 
            this.btnGetUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGetUpdate.Location = new System.Drawing.Point(447, 38);
            this.btnGetUpdate.Name = "btnGetUpdate";
            this.btnGetUpdate.Size = new System.Drawing.Size(81, 24);
            this.btnGetUpdate.TabIndex = 10;
            this.btnGetUpdate.Text = "UPDATE";
            this.btnGetUpdate.UseVisualStyleBackColor = true;
            this.btnGetUpdate.Click += new System.EventHandler(this.btnGetUpdate_Click);
            // 
            // lblTableName
            // 
            this.lblTableName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTableName.Location = new System.Drawing.Point(339, 11);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(74, 16);
            this.lblTableName.TabIndex = 9;
            this.lblTableName.Text = "テーブル名";
            // 
            // btnGetInsert
            // 
            this.btnGetInsert.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGetInsert.Location = new System.Drawing.Point(360, 38);
            this.btnGetInsert.Name = "btnGetInsert";
            this.btnGetInsert.Size = new System.Drawing.Size(81, 24);
            this.btnGetInsert.TabIndex = 7;
            this.btnGetInsert.Text = "INSERT";
            this.btnGetInsert.UseVisualStyleBackColor = true;
            this.btnGetInsert.Click += new System.EventHandler(this.btnGetInsert_Click);
            // 
            // cmbTableName
            // 
            this.cmbTableName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbTableName.ContextMenuStrip = this.menuTableName;
            this.cmbTableName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbTableName.FormattingEnabled = true;
            this.cmbTableName.Location = new System.Drawing.Point(419, 8);
            this.cmbTableName.Name = "cmbTableName";
            this.cmbTableName.Size = new System.Drawing.Size(227, 24);
            this.cmbTableName.Sorted = true;
            this.cmbTableName.TabIndex = 8;
            // 
            // btnRefreshGrid
            // 
            this.btnRefreshGrid.Location = new System.Drawing.Point(12, 8);
            this.btnRefreshGrid.Name = "btnRefreshGrid";
            this.btnRefreshGrid.Size = new System.Drawing.Size(103, 54);
            this.btnRefreshGrid.TabIndex = 5;
            this.btnRefreshGrid.Text = "テーブル読込";
            this.btnRefreshGrid.UseVisualStyleBackColor = true;
            this.btnRefreshGrid.Click += new System.EventHandler(this.btnRefreshGrid_Click);
            // 
            // menuConfig
            // 
            this.menuConfig.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpenLog,
            this.miOpenConfig,
            this.miHelp});
            this.menuConfig.Name = "menuConfig";
            this.menuConfig.Size = new System.Drawing.Size(153, 92);
            // 
            // miOpenLog
            // 
            this.miOpenLog.Name = "miOpenLog";
            this.miOpenLog.Size = new System.Drawing.Size(152, 22);
            this.miOpenLog.Text = "ログ";
            this.miOpenLog.Click += new System.EventHandler(this.miOpenLog_Click);
            // 
            // miOpenConfig
            // 
            this.miOpenConfig.Name = "miOpenConfig";
            this.miOpenConfig.Size = new System.Drawing.Size(152, 22);
            this.miOpenConfig.Text = "設定";
            this.miOpenConfig.Click += new System.EventHandler(this.miOpenConfig_Click);
            // 
            // miHelp
            // 
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(152, 22);
            this.miHelp.Text = "ヘルプ（Web）";
            this.miHelp.Click += new System.EventHandler(this.miHelp_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 440);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.infoStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "GetGrid";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.infoStatus.ResumeLayout(false);
            this.infoStatus.PerformLayout();
            this.menuTableName.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.menuConfig.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip infoStatus;
        private System.Windows.Forms.ToolStripStatusLabel info;
        private System.Windows.Forms.ContextMenuStrip menuTableName;
        private System.Windows.Forms.ToolStripMenuItem miTableNameDelete;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Button btnGetInsert;
        private System.Windows.Forms.ComboBox cmbTableName;
        private System.Windows.Forms.Button btnRefreshGrid;
        private System.Windows.Forms.Button btnGetDelete;
        private System.Windows.Forms.Button btnGetUpdate;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ContextMenuStrip menuConfig;
        private System.Windows.Forms.ToolStripMenuItem miOpenLog;
        private System.Windows.Forms.ToolStripMenuItem miOpenConfig;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
    }
}

