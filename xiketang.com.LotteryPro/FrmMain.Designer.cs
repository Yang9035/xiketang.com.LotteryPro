namespace xiketang.com.LotteryPro
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNumber01 = new System.Windows.Forms.Label();
            this.lbNumber02 = new System.Windows.Forms.Label();
            this.lbNumber03 = new System.Windows.Forms.Label();
            this.lbNumber04 = new System.Windows.Forms.Label();
            this.lbNumber05 = new System.Windows.Forms.Label();
            this.lbNumber06 = new System.Windows.Forms.Label();
            this.lbNumber07 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbNumberList = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(400, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "双色球随机选号器";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文细黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(66, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "双色球随机选号器";
            // 
            // lbNumber01
            // 
            this.lbNumber01.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNumber01.ForeColor = System.Drawing.Color.White;
            this.lbNumber01.Image = ((System.Drawing.Image)(resources.GetObject("lbNumber01.Image")));
            this.lbNumber01.Location = new System.Drawing.Point(29, 125);
            this.lbNumber01.Name = "lbNumber01";
            this.lbNumber01.Size = new System.Drawing.Size(49, 45);
            this.lbNumber01.TabIndex = 1;
            this.lbNumber01.Text = "00";
            this.lbNumber01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNumber02
            // 
            this.lbNumber02.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNumber02.ForeColor = System.Drawing.Color.White;
            this.lbNumber02.Image = ((System.Drawing.Image)(resources.GetObject("lbNumber02.Image")));
            this.lbNumber02.Location = new System.Drawing.Point(84, 125);
            this.lbNumber02.Name = "lbNumber02";
            this.lbNumber02.Size = new System.Drawing.Size(49, 45);
            this.lbNumber02.TabIndex = 1;
            this.lbNumber02.Text = "00";
            this.lbNumber02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNumber03
            // 
            this.lbNumber03.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNumber03.ForeColor = System.Drawing.Color.White;
            this.lbNumber03.Image = ((System.Drawing.Image)(resources.GetObject("lbNumber03.Image")));
            this.lbNumber03.Location = new System.Drawing.Point(139, 125);
            this.lbNumber03.Name = "lbNumber03";
            this.lbNumber03.Size = new System.Drawing.Size(49, 45);
            this.lbNumber03.TabIndex = 1;
            this.lbNumber03.Text = "00";
            this.lbNumber03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNumber04
            // 
            this.lbNumber04.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNumber04.ForeColor = System.Drawing.Color.White;
            this.lbNumber04.Image = ((System.Drawing.Image)(resources.GetObject("lbNumber04.Image")));
            this.lbNumber04.Location = new System.Drawing.Point(194, 125);
            this.lbNumber04.Name = "lbNumber04";
            this.lbNumber04.Size = new System.Drawing.Size(49, 45);
            this.lbNumber04.TabIndex = 1;
            this.lbNumber04.Text = "00";
            this.lbNumber04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNumber05
            // 
            this.lbNumber05.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNumber05.ForeColor = System.Drawing.Color.White;
            this.lbNumber05.Image = ((System.Drawing.Image)(resources.GetObject("lbNumber05.Image")));
            this.lbNumber05.Location = new System.Drawing.Point(249, 125);
            this.lbNumber05.Name = "lbNumber05";
            this.lbNumber05.Size = new System.Drawing.Size(49, 45);
            this.lbNumber05.TabIndex = 1;
            this.lbNumber05.Text = "00";
            this.lbNumber05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNumber06
            // 
            this.lbNumber06.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNumber06.ForeColor = System.Drawing.Color.White;
            this.lbNumber06.Image = ((System.Drawing.Image)(resources.GetObject("lbNumber06.Image")));
            this.lbNumber06.Location = new System.Drawing.Point(304, 125);
            this.lbNumber06.Name = "lbNumber06";
            this.lbNumber06.Size = new System.Drawing.Size(49, 45);
            this.lbNumber06.TabIndex = 1;
            this.lbNumber06.Text = "00";
            this.lbNumber06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNumber07
            // 
            this.lbNumber07.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNumber07.ForeColor = System.Drawing.Color.White;
            this.lbNumber07.Image = ((System.Drawing.Image)(resources.GetObject("lbNumber07.Image")));
            this.lbNumber07.Location = new System.Drawing.Point(359, 125);
            this.lbNumber07.Name = "lbNumber07";
            this.lbNumber07.Size = new System.Drawing.Size(49, 45);
            this.lbNumber07.TabIndex = 1;
            this.lbNumber07.Text = "00";
            this.lbNumber07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(33, 192);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 35);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "启  动";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(129, 192);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 35);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "选  择";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(225, 192);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 35);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "清  除";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(321, 192);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 35);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "确认购买";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbNumberList
            // 
            this.lbNumberList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.lbNumberList.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNumberList.ForeColor = System.Drawing.Color.White;
            this.lbNumberList.FormattingEnabled = true;
            this.lbNumberList.ItemHeight = 25;
            this.lbNumberList.Location = new System.Drawing.Point(33, 249);
            this.lbNumberList.Name = "lbNumberList";
            this.lbNumberList.Size = new System.Drawing.Size(363, 129);
            this.lbNumberList.TabIndex = 3;
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 423);
            this.Controls.Add(this.lbNumberList);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbNumber07);
            this.Controls.Add(this.lbNumber06);
            this.Controls.Add(this.lbNumber05);
            this.Controls.Add(this.lbNumber04);
            this.Controls.Add(this.lbNumber03);
            this.Controls.Add(this.lbNumber02);
            this.Controls.Add(this.lbNumber01);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "双色球随机选号器";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNumber01;
        private System.Windows.Forms.Label lbNumber02;
        private System.Windows.Forms.Label lbNumber03;
        private System.Windows.Forms.Label lbNumber04;
        private System.Windows.Forms.Label lbNumber05;
        private System.Windows.Forms.Label lbNumber06;
        private System.Windows.Forms.Label lbNumber07;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ListBox lbNumberList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timer;
    }
}

