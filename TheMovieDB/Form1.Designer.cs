namespace TheMovieDB
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.MoviesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GenreBox = new System.Windows.Forms.ListBox();
            this.TrendingList = new System.Windows.Forms.Panel();
            this.SearchTitle = new System.Windows.Forms.Label();
            this.SearchView = new System.Windows.Forms.ListView();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.MovieTitle = new System.Windows.Forms.Label();
            this.MoviePic = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SearchBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.search_button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.TrendingList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePic)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.HomeButton);
            this.flowLayoutPanel1.Controls.Add(this.MoviesButton);
            this.flowLayoutPanel1.Controls.Add(this.SearchBox1);
            this.flowLayoutPanel1.Controls.Add(this.search_button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1394, 48);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.ForeColor = System.Drawing.Color.Transparent;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.Location = new System.Drawing.Point(3, 3);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(75, 48);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // MoviesButton
            // 
            this.MoviesButton.BackColor = System.Drawing.Color.Transparent;
            this.MoviesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MoviesButton.BackgroundImage")));
            this.MoviesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MoviesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoviesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoviesButton.Location = new System.Drawing.Point(84, 3);
            this.MoviesButton.Name = "MoviesButton";
            this.MoviesButton.Size = new System.Drawing.Size(113, 42);
            this.MoviesButton.TabIndex = 2;
            this.MoviesButton.Text = "Movies";
            this.MoviesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MoviesButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1342, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(52, 620);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 642);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1342, 26);
            this.panel3.TabIndex = 4;
            // 
            // GenreBox
            // 
            this.GenreBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GenreBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.GenreBox.FormattingEnabled = true;
            this.GenreBox.ItemHeight = 16;
            this.GenreBox.Location = new System.Drawing.Point(0, 48);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(155, 594);
            this.GenreBox.TabIndex = 0;
            this.GenreBox.SelectedIndexChanged += new System.EventHandler(this.GenreBox_SelectedIndexChanged);
            // 
            // TrendingList
            // 
            this.TrendingList.Controls.Add(this.SearchTitle);
            this.TrendingList.Controls.Add(this.SearchView);
            this.TrendingList.Controls.Add(this.DescriptionBox);
            this.TrendingList.Controls.Add(this.MovieTitle);
            this.TrendingList.Controls.Add(this.MoviePic);
            this.TrendingList.Controls.Add(this.listBox1);
            this.TrendingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrendingList.Location = new System.Drawing.Point(155, 48);
            this.TrendingList.Name = "TrendingList";
            this.TrendingList.Size = new System.Drawing.Size(1187, 594);
            this.TrendingList.TabIndex = 5;
            // 
            // SearchTitle
            // 
            this.SearchTitle.AutoSize = true;
            this.SearchTitle.Location = new System.Drawing.Point(270, 19);
            this.SearchTitle.Name = "SearchTitle";
            this.SearchTitle.Size = new System.Drawing.Size(46, 17);
            this.SearchTitle.TabIndex = 7;
            this.SearchTitle.Text = "label1";
            // 
            // SearchView
            // 
            this.SearchView.HideSelection = false;
            this.SearchView.Location = new System.Drawing.Point(257, 6);
            this.SearchView.Name = "SearchView";
            this.SearchView.Size = new System.Drawing.Size(411, 186);
            this.SearchView.TabIndex = 6;
            this.SearchView.UseCompatibleStateImageBehavior = false;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionBox.Location = new System.Drawing.Point(596, 377);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DescriptionBox.Size = new System.Drawing.Size(570, 211);
            this.DescriptionBox.TabIndex = 4;
            this.DescriptionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MovieTitle
            // 
            this.MovieTitle.AutoSize = true;
            this.MovieTitle.ForeColor = System.Drawing.Color.Transparent;
            this.MovieTitle.Location = new System.Drawing.Point(299, 369);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Size = new System.Drawing.Size(0, 17);
            this.MovieTitle.TabIndex = 2;
            this.MovieTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoviePic
            // 
            this.MoviePic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MoviePic.Location = new System.Drawing.Point(732, 19);
            this.MoviePic.Name = "MoviePic";
            this.MoviePic.Size = new System.Drawing.Size(434, 289);
            this.MoviePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoviePic.TabIndex = 1;
            this.MoviePic.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 596);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SearchBox1
            // 
            this.SearchBox1.Location = new System.Drawing.Point(203, 3);
            this.SearchBox1.Name = "SearchBox1";
            this.SearchBox1.Size = new System.Drawing.Size(123, 22);
            this.SearchBox1.TabIndex = 3;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // search_button1
            // 
            this.search_button1.Image = ((System.Drawing.Image)(resources.GetObject("search_button1.Image")));
            this.search_button1.Location = new System.Drawing.Point(332, 3);
            this.search_button1.Name = "search_button1";
            this.search_button1.Size = new System.Drawing.Size(42, 39);
            this.search_button1.TabIndex = 4;
            this.search_button1.UseVisualStyleBackColor = true;
            this.search_button1.Click += new System.EventHandler(this.search_button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1394, 668);
            this.Controls.Add(this.TrendingList);
            this.Controls.Add(this.GenreBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "The Movies DB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.TrendingList.ResumeLayout(false);
            this.TrendingList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox GenreBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button MoviesButton;
        private System.Windows.Forms.Panel TrendingList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label MovieTitle;
        private System.Windows.Forms.PictureBox MoviePic;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label SearchTitle;
        private System.Windows.Forms.ListView SearchView;
        private System.Windows.Forms.TextBox SearchBox1;
        private System.Windows.Forms.Button search_button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}

