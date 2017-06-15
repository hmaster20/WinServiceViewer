namespace WinServiceViewer
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.listViewService = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts = new System.Windows.Forms.ToolStrip();
            this.scanService = new System.Windows.Forms.ToolStripButton();
            this.tsUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsStopUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsRestoreUpdate = new System.Windows.Forms.ToolStripButton();
            this.test_start = new System.Windows.Forms.ToolStripButton();
            this.test_stop = new System.Windows.Forms.ToolStripButton();
            this.test_pause = new System.Windows.Forms.ToolStripButton();
            this.test_resume = new System.Windows.Forms.ToolStripButton();
            this.CancelScanService = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.ts.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewService
            // 
            this.listViewService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewService.FullRowSelect = true;
            this.listViewService.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewService.Location = new System.Drawing.Point(0, 25);
            this.listViewService.MultiSelect = false;
            this.listViewService.Name = "listViewService";
            this.listViewService.ShowGroups = false;
            this.listViewService.Size = new System.Drawing.Size(638, 239);
            this.listViewService.TabIndex = 0;
            this.listViewService.UseCompatibleStateImageBehavior = false;
            this.listViewService.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 100;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 264);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(638, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // ts
            // 
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanService,
            this.CancelScanService,
            this.tsUpdate,
            this.tsStopUpdate,
            this.tsRestoreUpdate,
            this.test_start,
            this.test_stop,
            this.test_pause,
            this.test_resume});
            this.ts.Location = new System.Drawing.Point(0, 0);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(638, 25);
            this.ts.TabIndex = 2;
            this.ts.Text = "toolStrip1";
            // 
            // scanService
            // 
            this.scanService.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scanService.Image = global::WinServiceViewer.Properties.Resources.start;
            this.scanService.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scanService.Name = "scanService";
            this.scanService.Size = new System.Drawing.Size(23, 22);
            this.scanService.Text = "Получить список служб";
            // 
            // tsUpdate
            // 
            this.tsUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUpdate.Name = "tsUpdate";
            this.tsUpdate.Size = new System.Drawing.Size(23, 22);
            this.tsUpdate.Text = "Update";
            this.tsUpdate.Click += new System.EventHandler(this.tsUpdate_Click);
            // 
            // tsStopUpdate
            // 
            this.tsStopUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsStopUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsStopUpdate.Image")));
            this.tsStopUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStopUpdate.Name = "tsStopUpdate";
            this.tsStopUpdate.Size = new System.Drawing.Size(23, 22);
            this.tsStopUpdate.Text = "StopUpdate";
            this.tsStopUpdate.Click += new System.EventHandler(this.tsStopUpdate_Click);
            // 
            // tsRestoreUpdate
            // 
            this.tsRestoreUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRestoreUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsRestoreUpdate.Image")));
            this.tsRestoreUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRestoreUpdate.Name = "tsRestoreUpdate";
            this.tsRestoreUpdate.Size = new System.Drawing.Size(23, 22);
            this.tsRestoreUpdate.Text = "RestoreUpdate";
            // 
            // test_start
            // 
            this.test_start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.test_start.Image = ((System.Drawing.Image)(resources.GetObject("test_start.Image")));
            this.test_start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.test_start.Name = "test_start";
            this.test_start.Size = new System.Drawing.Size(23, 22);
            this.test_start.Text = "test_start";
            this.test_start.Click += new System.EventHandler(this.test_start_Click);
            // 
            // test_stop
            // 
            this.test_stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.test_stop.Image = ((System.Drawing.Image)(resources.GetObject("test_stop.Image")));
            this.test_stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.test_stop.Name = "test_stop";
            this.test_stop.Size = new System.Drawing.Size(23, 22);
            this.test_stop.Text = "test_stop";
            this.test_stop.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // test_pause
            // 
            this.test_pause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.test_pause.Image = ((System.Drawing.Image)(resources.GetObject("test_pause.Image")));
            this.test_pause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.test_pause.Name = "test_pause";
            this.test_pause.Size = new System.Drawing.Size(23, 22);
            this.test_pause.Text = "test_pause";
            this.test_pause.Click += new System.EventHandler(this.test_pause_Click);
            // 
            // test_resume
            // 
            this.test_resume.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.test_resume.Image = ((System.Drawing.Image)(resources.GetObject("test_resume.Image")));
            this.test_resume.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.test_resume.Name = "test_resume";
            this.test_resume.Size = new System.Drawing.Size(23, 22);
            this.test_resume.Text = "test_resume";
            this.test_resume.Click += new System.EventHandler(this.test_resume_Click);
            // 
            // CancelScanService
            // 
            this.CancelScanService.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CancelScanService.Enabled = false;
            this.CancelScanService.Image = global::WinServiceViewer.Properties.Resources.stop;
            this.CancelScanService.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelScanService.Name = "CancelScanService";
            this.CancelScanService.Size = new System.Drawing.Size(23, 22);
            this.CancelScanService.Text = "Отмена";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 286);
            this.Controls.Add(this.listViewService);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Main";
            this.Text = "Список сервисов";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewService;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripButton tsUpdate;
        private System.Windows.Forms.ToolStripButton tsStopUpdate;
        private System.Windows.Forms.ToolStripButton tsRestoreUpdate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripButton test_start;
        private System.Windows.Forms.ToolStripButton test_stop;
        private System.Windows.Forms.ToolStripButton test_pause;
        private System.Windows.Forms.ToolStripButton test_resume;
        private System.Windows.Forms.ToolStripButton scanService;
        private System.Windows.Forms.ToolStripButton CancelScanService;
    }
}

