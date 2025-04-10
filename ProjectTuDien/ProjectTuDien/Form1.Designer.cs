
namespace ProjectTuDien
{
    partial class TuDienSieuCap
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
            this.ThanhSearch = new System.Windows.Forms.TextBox();
            this.av = new System.Windows.Forms.Label();
            this.ThemTu = new System.Windows.Forms.Button();
            this.XoaTu = new System.Windows.Forms.Button();
            this.AddTu = new System.Windows.Forms.TextBox();
            this.XacNhan = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.AnhViet = new System.Windows.Forms.Button();
            this.LichSuSearch = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.XoaLichSu = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.DocTu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ThanhSearch
            // 
            this.ThanhSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThanhSearch.Location = new System.Drawing.Point(40, 90);
            this.ThanhSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ThanhSearch.Name = "ThanhSearch";
            this.ThanhSearch.Size = new System.Drawing.Size(600, 26);
            this.ThanhSearch.TabIndex = 0;
            this.ThanhSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // av
            // 
            this.av.AutoSize = true;
            this.av.BackColor = System.Drawing.Color.MidnightBlue;
            this.av.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.av.Font = new System.Drawing.Font("Unbounded Medium", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.av.ForeColor = System.Drawing.Color.White;
            this.av.Location = new System.Drawing.Point(159, 0);
            this.av.Name = "av";
            this.av.Size = new System.Drawing.Size(414, 58);
            this.av.TabIndex = 5;
            this.av.Text = "Từ Điển SIEUCAP";
            this.av.Click += new System.EventHandler(this.av_Click);
            // 
            // ThemTu
            // 
            this.ThemTu.BackColor = System.Drawing.Color.MidnightBlue;
            this.ThemTu.FlatAppearance.BorderSize = 0;
            this.ThemTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemTu.Font = new System.Drawing.Font("Unbounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemTu.ForeColor = System.Drawing.Color.White;
            this.ThemTu.Location = new System.Drawing.Point(105, 449);
            this.ThemTu.Margin = new System.Windows.Forms.Padding(4);
            this.ThemTu.Name = "ThemTu";
            this.ThemTu.Size = new System.Drawing.Size(142, 50);
            this.ThemTu.TabIndex = 6;
            this.ThemTu.Text = "Thêm từ";
            this.ThemTu.UseVisualStyleBackColor = false;
            this.ThemTu.Click += new System.EventHandler(this.button1_Click);
            // 
            // XoaTu
            // 
            this.XoaTu.BackColor = System.Drawing.Color.MidnightBlue;
            this.XoaTu.FlatAppearance.BorderSize = 0;
            this.XoaTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XoaTu.Font = new System.Drawing.Font("Unbounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaTu.ForeColor = System.Drawing.Color.White;
            this.XoaTu.Location = new System.Drawing.Point(308, 449);
            this.XoaTu.Margin = new System.Windows.Forms.Padding(4);
            this.XoaTu.Name = "XoaTu";
            this.XoaTu.Size = new System.Drawing.Size(142, 50);
            this.XoaTu.TabIndex = 7;
            this.XoaTu.Text = "Xóa từ";
            this.XoaTu.UseVisualStyleBackColor = false;
            this.XoaTu.Click += new System.EventHandler(this.XoaTu_Click_1);
            // 
            // AddTu
            // 
            this.AddTu.Location = new System.Drawing.Point(20, 521);
            this.AddTu.Name = "AddTu";
            this.AddTu.Size = new System.Drawing.Size(512, 22);
            this.AddTu.TabIndex = 8;
            this.AddTu.Visible = false;
            this.AddTu.WordWrap = false;
            this.AddTu.TextChanged += new System.EventHandler(this.AddTu_TextChanged);
            // 
            // XacNhan
            // 
            this.XacNhan.BackColor = System.Drawing.Color.MidnightBlue;
            this.XacNhan.FlatAppearance.BorderSize = 0;
            this.XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XacNhan.Font = new System.Drawing.Font("Unbounded", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XacNhan.ForeColor = System.Drawing.Color.White;
            this.XacNhan.Location = new System.Drawing.Point(537, 518);
            this.XacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.XacNhan.Name = "XacNhan";
            this.XacNhan.Size = new System.Drawing.Size(158, 27);
            this.XacNhan.TabIndex = 9;
            this.XacNhan.Text = "Xác nhận";
            this.XacNhan.UseVisualStyleBackColor = false;
            this.XacNhan.Visible = false;
            this.XacNhan.Click += new System.EventHandler(this.XacNhan_Click);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Result.Font = new System.Drawing.Font("Unbounded", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.White;
            this.Result.Location = new System.Drawing.Point(20, 145);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(512, 366);
            this.Result.TabIndex = 10;
            // 
            // AnhViet
            // 
            this.AnhViet.BackColor = System.Drawing.Color.MidnightBlue;
            this.AnhViet.FlatAppearance.BorderSize = 0;
            this.AnhViet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnhViet.Font = new System.Drawing.Font("Unbounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnhViet.ForeColor = System.Drawing.Color.White;
            this.AnhViet.Location = new System.Drawing.Point(537, 145);
            this.AnhViet.Margin = new System.Windows.Forms.Padding(4);
            this.AnhViet.Name = "AnhViet";
            this.AnhViet.Size = new System.Drawing.Size(158, 57);
            this.AnhViet.TabIndex = 14;
            this.AnhViet.Text = "Anh-Việt";
            this.AnhViet.UseVisualStyleBackColor = false;
            // 
            // LichSuSearch
            // 
            this.LichSuSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LichSuSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LichSuSearch.Font = new System.Drawing.Font("Unbounded Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LichSuSearch.ForeColor = System.Drawing.Color.White;
            this.LichSuSearch.FormattingEnabled = true;
            this.LichSuSearch.ItemHeight = 25;
            this.LichSuSearch.Location = new System.Drawing.Point(537, 254);
            this.LichSuSearch.Name = "LichSuSearch";
            this.LichSuSearch.Size = new System.Drawing.Size(159, 225);
            this.LichSuSearch.TabIndex = 15;
            this.LichSuSearch.SelectedIndexChanged += new System.EventHandler(this.LichSuSearch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Unbounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(537, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 48);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lịch sử";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // XoaLichSu
            // 
            this.XoaLichSu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.XoaLichSu.FlatAppearance.BorderSize = 0;
            this.XoaLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XoaLichSu.Font = new System.Drawing.Font("Unbounded", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaLichSu.ForeColor = System.Drawing.Color.White;
            this.XoaLichSu.Location = new System.Drawing.Point(537, 463);
            this.XoaLichSu.Name = "XoaLichSu";
            this.XoaLichSu.Size = new System.Drawing.Size(159, 48);
            this.XoaLichSu.TabIndex = 17;
            this.XoaLichSu.Text = "Xóa lịch sử";
            this.XoaLichSu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XoaLichSu.UseVisualStyleBackColor = false;
            this.XoaLichSu.Click += new System.EventHandler(this.XoaLichSu_Click_1);
            // 
            // buttonX
            // 
            this.buttonX.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonX.BackgroundImage = global::ProjectTuDien.Properties.Resources.dauX;
            this.buttonX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonX.FlatAppearance.BorderSize = 0;
            this.buttonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX.Location = new System.Drawing.Point(671, 12);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(35, 35);
            this.buttonX.TabIndex = 23;
            this.buttonX.UseVisualStyleBackColor = false;
            // 
            // DocTu
            // 
            this.DocTu.BackColor = System.Drawing.Color.Lavender;
            this.DocTu.BackgroundImage = global::ProjectTuDien.Properties.Resources.loa;
            this.DocTu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DocTu.FlatAppearance.BorderSize = 0;
            this.DocTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DocTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocTu.Location = new System.Drawing.Point(499, 149);
            this.DocTu.Margin = new System.Windows.Forms.Padding(4);
            this.DocTu.Name = "DocTu";
            this.DocTu.Size = new System.Drawing.Size(30, 30);
            this.DocTu.TabIndex = 13;
            this.DocTu.UseVisualStyleBackColor = false;
            this.DocTu.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(723, 68);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox2.Location = new System.Drawing.Point(20, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(676, 55);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.White;
            this.SearchButton.BackgroundImage = global::ProjectTuDien.Properties.Resources.search;
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(648, 90);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(26, 26);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox3.BackgroundImage = global::ProjectTuDien.Properties.Resources.thungrac;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(656, 473);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 29);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // TuDienSieuCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(718, 561);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.XoaLichSu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LichSuSearch);
            this.Controls.Add(this.AnhViet);
            this.Controls.Add(this.DocTu);
            this.Controls.Add(this.XacNhan);
            this.Controls.Add(this.AddTu);
            this.Controls.Add(this.XoaTu);
            this.Controls.Add(this.ThemTu);
            this.Controls.Add(this.av);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ThanhSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TuDienSieuCap";
            this.ShowInTaskbar = false;
            this.Text = "Tu Dien Anh-Viet SIEUCAP";
            this.Load += new System.EventHandler(this.TuDienSieuCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ThanhSearch;
        private System.Windows.Forms.Label av;
        private System.Windows.Forms.Button ThemTu;
        private System.Windows.Forms.Button XoaTu;
        private System.Windows.Forms.TextBox AddTu;
        private System.Windows.Forms.Button XacNhan;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button DocTu;
        private System.Windows.Forms.Button AnhViet;
        private System.Windows.Forms.ListBox LichSuSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button XoaLichSu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.PictureBox pictureBox3;
    }

}

