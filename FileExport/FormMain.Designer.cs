
namespace FileExport
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelFileNames = new System.Windows.Forms.Label();
            this.textBoxFiles = new System.Windows.Forms.TextBox();
            this.labelExport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFileNames
            // 
            this.labelFileNames.AutoSize = true;
            this.labelFileNames.Location = new System.Drawing.Point(12, 9);
            this.labelFileNames.Name = "labelFileNames";
            this.labelFileNames.Size = new System.Drawing.Size(26, 12);
            this.labelFileNames.TabIndex = 0;
            this.labelFileNames.Text = "&File:";
            // 
            // textBoxFiles
            // 
            this.textBoxFiles.AllowDrop = true;
            this.textBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFiles.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxFiles.Location = new System.Drawing.Point(12, 24);
            this.textBoxFiles.MaxLength = 0;
            this.textBoxFiles.Multiline = true;
            this.textBoxFiles.Name = "textBoxFiles";
            this.textBoxFiles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxFiles.Size = new System.Drawing.Size(776, 350);
            this.textBoxFiles.TabIndex = 1;
            this.textBoxFiles.WordWrap = false;
            this.textBoxFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxFiles_DragDrop);
            this.textBoxFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxFiles_DragEnter);
            // 
            // labelExport
            // 
            this.labelExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExport.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExport.Location = new System.Drawing.Point(724, 377);
            this.labelExport.Name = "labelExport";
            this.labelExport.Size = new System.Drawing.Size(64, 64);
            this.labelExport.TabIndex = 2;
            this.labelExport.Text = "Export";
            this.labelExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExport.DragOver += new System.Windows.Forms.DragEventHandler(this.labelExport_DragOver);
            this.labelExport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelExport_MouseDown);
            this.labelExport.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelExport_MouseMove);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelExport);
            this.Controls.Add(this.textBoxFiles);
            this.Controls.Add(this.labelFileNames);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "FileExport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFileNames;
        private System.Windows.Forms.TextBox textBoxFiles;
        private System.Windows.Forms.Label labelExport;
    }
}

