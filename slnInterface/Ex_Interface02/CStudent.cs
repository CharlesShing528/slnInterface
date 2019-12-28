using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 一個類別可以同時實作多個介面，其做法是在該類別宣告時
/// ，在「類別名稱：」後面接多個介面名稱，名稱間要用逗號「，」隔開。
/// </summary>
namespace Ex_Interface02
{
    public class CStudent:IPass,ILevel  //宣告 CStudent 類別實作 IPass 和 ILevel介面
    {
        /// <summary>
        /// 設定 passOK 為字串私有欄位用來存放及格或不及格訊息
        /// </summary>
        public String passOK { get; set; }

        /// <summary>
        /// 實作 score 屬性用來有放分數，並給予被始值60，
        /// </summary>
        private int score = 60;
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        /// <summary>
        /// 實作 Pass()方法
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public String Pass(int grade)
        {
            if(grade>=score)
            {
                passOK = "及格";
            }
            else
            {
                passOK = "不及格";
            }
            return passOK;
        }

        /// <summary>
        /// 設定 levelN 字串私有欄位用來存放等第評語
        /// </summary>
        public String levelN;

        /// <summary>
        /// 實作 high 高標屬性，用來存放高標分數，並給予初始值80
        /// </summary>
        private int high = 80;
        public int High
        {
            get { return high; }
            set { high = value; }
        }

        /// <summary>
        /// 實作 Low 低標屬性，用來存放低標分數，一給予初始值55
        /// </summary>
        private int low = 55;
        public int Low
        {
            get { return low; }
            set { low = value; }
        }

        /// <summary>
        /// 實作 Level()方法，若傳入的成績>=80,傳回"表現優異"；
        /// 若55< =成積 < 80，"差強人意";
        /// 若成續 < 55，傳回"有待加強"
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public String Level(int grade)
        {
            if (grade >= high) levelN = "表現優異";
            if ((grade >= low) && (grade < high)) levelN = "差強人意";
            if (grade < low) levelN = "有待加強";
            return levelN;
        }
    }
}
