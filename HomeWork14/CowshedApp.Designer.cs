namespace HomeWork14
{
    partial class CowshedApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CowshedApp));
            this.CowPicture = new System.Windows.Forms.PictureBox();
            this.MainSplit = new System.Windows.Forms.SplitContainer();
            this.MainTree = new System.Windows.Forms.TreeView();
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CowPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).BeginInit();
            this.MainSplit.Panel1.SuspendLayout();
            this.MainSplit.Panel2.SuspendLayout();
            this.MainSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // CowPicture
            // 
            this.CowPicture.Image = ((System.Drawing.Image)(resources.GetObject("CowPicture.Image")));
            this.CowPicture.Location = new System.Drawing.Point(0, 0);
            this.CowPicture.Name = "CowPicture";
            this.CowPicture.Size = new System.Drawing.Size(200, 200);
            this.CowPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CowPicture.TabIndex = 0;
            this.CowPicture.TabStop = false;
            // 
            // MainSplit
            // 
            this.MainSplit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainSplit.Location = new System.Drawing.Point(0, 0);
            this.MainSplit.Name = "MainSplit";
            // 
            // MainSplit.Panel1
            // 
            this.MainSplit.Panel1.Controls.Add(this.MainTree);
            this.MainSplit.Panel1.Controls.Add(this.CowPicture);
            // 
            // MainSplit.Panel2
            // 
            this.MainSplit.Panel2.Controls.Add(this.MainTable);
            this.MainSplit.Panel2.Controls.Add(this.CloseButton);
            this.MainSplit.Panel2.Controls.Add(this.ShowButton);
            this.MainSplit.Panel2.Controls.Add(this.DownloadButton);
            this.MainSplit.Size = new System.Drawing.Size(1022, 608);
            this.MainSplit.SplitterDistance = 200;
            this.MainSplit.TabIndex = 0;
            // 
            // MainTree
            // 
            this.MainTree.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainTree.Location = new System.Drawing.Point(0, 206);
            this.MainTree.Name = "MainTree";
            this.MainTree.Size = new System.Drawing.Size(195, 402);
            this.MainTree.TabIndex = 0;
            // 
            // MainTable
            // 
            this.MainTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.Location = new System.Drawing.Point(32, 181);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 1;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Size = new System.Drawing.Size(752, 414);
            this.MainTable.TabIndex = 3;
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Location = new System.Drawing.Point(624, 56);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(160, 70);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowButton.Location = new System.Drawing.Point(329, 56);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(160, 70);
            this.ShowButton.TabIndex = 1;
            this.ShowButton.Text = "Показать";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DownloadButton.Location = new System.Drawing.Point(32, 56);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(160, 70);
            this.DownloadButton.TabIndex = 0;
            this.DownloadButton.Text = "Загрузить";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // CowshedApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 608);
            this.Controls.Add(this.MainSplit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CowshedApp";
            this.Text = "Cowshed";
            ((System.ComponentModel.ISupportInitialize)(this.CowPicture)).EndInit();
            this.MainSplit.Panel1.ResumeLayout(false);
            this.MainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).EndInit();
            this.MainSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CowPicture;
        private System.Windows.Forms.SplitContainer MainSplit;
        private System.Windows.Forms.TreeView MainTree;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.TableLayoutPanel MainTable;
    }
}

