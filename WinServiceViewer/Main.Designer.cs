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
            this.listViewService = new System.Windows.Forms.ListView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsScanStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsState = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts = new System.Windows.Forms.ToolStrip();
            this.btnStart = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.statusStrip.SuspendLayout();
            this.ts.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewService
            // 
            this.listViewService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewService.FullRowSelect = true;
            this.listViewService.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewService.Location = new System.Drawing.Point(0, 25);
            this.listViewService.MultiSelect = false;
            this.listViewService.Name = "listViewService";
            this.listViewService.ShowGroups = false;
            this.listViewService.Size = new System.Drawing.Size(638, 239);
            this.listViewService.TabIndex = 0;
            this.listViewService.UseCompatibleStateImageBehavior = false;
            this.listViewService.View = System.Windows.Forms.View.Details;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsScanStatus,
            this.tsState});
            this.statusStrip.Location = new System.Drawing.Point(0, 264);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(638, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsScanStatus
            // 
            this.tsScanStatus.Name = "tsScanStatus";
            this.tsScanStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // tsState
            // 
            this.tsState.Name = "tsState";
            this.tsState.Size = new System.Drawing.Size(0, 17);
            // 
            // ts
            // 
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStart,
            this.btnStop});
            this.ts.Location = new System.Drawing.Point(0, 0);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(638, 25);
            this.ts.TabIndex = 2;
            this.ts.Text = "toolStrip1";
            // 
            // btnStart
            // 
            this.btnStart.CheckOnClick = true;
            this.btnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStart.Image = global::WinServiceViewer.Properties.Resources.start;
            this.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(23, 22);
            this.btnStart.Text = "Получить список сервисов";
            this.btnStart.CheckedChanged += new System.EventHandler(this.btnStart_CheckedChanged);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Enabled = false;
            this.btnStop.Image = global::WinServiceViewer.Properties.Resources.stop;
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(23, 22);
            this.btnStop.Text = "Отмена";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 286);
            this.Controls.Add(this.listViewService);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.statusStrip);
            this.Name = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewService;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripStatusLabel tsScanStatus;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripButton btnStart;
        private System.Windows.Forms.ToolStripStatusLabel tsState;
    }
}

