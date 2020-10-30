using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.LotteryPro
{
   /// <summary>
   /// 选号器类
   /// </summary>
    public class Selector
    {
        //红球池
        public List<string> RedNumberList { get; set; }
        //蓝球池
        public List<string> BlueNumberList { get; set; }
        //存储选择的号码，同时初始化属性
        public List<DoubleChromosphere> SelectedNubers { get; set; } = new List<DoubleChromosphere>();
        private Random random = new Random();//随机数生成器，只在本类内使用
        /// <summary>
        /// 构造方法，初始化球池
        /// </summary>
        public Selector()
        {
            RedNumberList = new List<string>
            {
                "01","02","03","04","05","06","07","08","09","10",
                "11","12","13","14","15","16","17","18","19","20",
                "21","22","23","24","25","26","27","28","29","30",
                "31","32","33"
            };
            BlueNumberList = new List<string>()
            {
                "01","02","03","04","05","06","07","08","09","10",
                "11","12","13","14","15","16"
            };
        }
        public List<string> CreateRandomNumber()
        {
            List<string> numList = new List<string>();
            while (true)
            {
                if (numList.Count==6)
                {
                    break;
                }
                string num = RedNumberList[random.Next(33)];
                if (numList.Contains(num))
                {
                    continue;
                }
                else
                {
                    numList.Add(num);
                }
            }
            numList.Add(BlueNumberList[random.Next(16)]);
            return numList;
        }
    }
}
