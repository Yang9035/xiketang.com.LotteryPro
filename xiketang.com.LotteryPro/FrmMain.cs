using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xiketang.com.LotteryPro
{
    public partial class FrmMain : Form
    {
        //创建选号器对象
        private Selector newSelector = new Selector();
        //每次得到的随机数
        List<string> randomNuber = null;
        public FrmMain()
        {
            InitializeComponent();
            this.btnSelect.Enabled = false;
        }
        #region  拖动和关闭窗体

        private Point mouseOff;//鼠标移动位置变量
        private bool leftFlag;//标签是否为左键
        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }
        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }
        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }
        #endregion
        //启动
        private void btnStart_Click(object sender, EventArgs e)
        {
            this.timer.Start();
            this.btnSelect.Enabled = true;
            this.btnStart.Enabled = false;
        }
        //选择
        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.timer.Stop();
            this.btnSelect.Enabled = false;
            this.btnStart.Enabled = true;
            //创建双色球对象
            DoubleChromosphere dc = new DoubleChromosphere()
            {
                Numbers = this.randomNuber,
            };
            //添加到选好池中
            this.newSelector.SelectedNubers.Add(dc);
            //显示号码
            string num = string.Empty;
            foreach (string item in this.randomNuber)
            {
                num += item + "  ";
            }
            this.lbNumberList.Items.Add(num);
        }
        //清除
        private void btnDel_Click(object sender, EventArgs e)
        {
            this.newSelector.SelectedNubers.Clear(); //从集合中清除
            this.lbNumberList.Items.Clear();//从列表中清除
        }
        //确认购买
        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
        //关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //定时器时间，每隔50hm调用一次
        private void timer_Tick(object sender, EventArgs e)
        {
            //通过调用选号器，得到随机数
            randomNuber = newSelector.CreateRandomNumber();
            //把得到的随机数显示在UI中
            this.lbNumber01.Text = randomNuber[0];
            this.lbNumber02.Text = randomNuber[1];
            this.lbNumber03.Text = randomNuber[2];
            this.lbNumber04.Text = randomNuber[3];
            this.lbNumber05.Text = randomNuber[4];
            this.lbNumber06.Text = randomNuber[5];
            this.lbNumber07.Text = randomNuber[6];
        }
    }
}
