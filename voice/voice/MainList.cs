using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voice
{
    class MainList
    {
        public string Message { get; set; }
        private string img_Pic;

        public string Img_Pic
        {
            get { return img_Pic; }
            set { img_Pic = value; }
        }

        private string tBox_Name;
        public string TBox_Name
        {
            get { return tBox_Name; }
            set { tBox_Name = value; }
        }
        private string tBox_Date;
        public string TBox_Date
        {
            get { return tBox_Date; }
            set { tBox_Date = value; }
        }
        private string tBox_Time;
        public string TBox_Time
        {
            get { return tBox_Time; }
            set { tBox_Time = value; }
        }
        private string tBox_MainTitle;
        public string TBox_MainTitle
        {
            get { return tBox_MainTitle; }
            set { tBox_MainTitle = value; }
        }
        private string tBox_Audience;
        public string TBox_Audience
        {
            get { return tBox_Audience; }
            set { tBox_Audience = value; }
        }
        private string tBox_Purpose;
        public string TBox_Purpose
        {
            get { return tBox_Purpose; }
            set { tBox_Purpose = value; }
        }
        private string tBox_Gender;
        public string TBox_Gender
        {
            get { return tBox_Gender; }
            set { tBox_Gender = value; }
        }
        private string tBox_Age;
        public string TBox_Age
        {
            get { return tBox_Age; }
            set { tBox_Age = value; }
        }
        private string img_Gender_Pic;
        public string Img_Gender_Pic
        {
            get { return img_Gender_Pic; }
            set { img_Gender_Pic = value; }
        }
        private string tBox_Count;
        public string TBox_Count
        {
            get { return tBox_Count; }
            set { tBox_Count = value; }
        }




        public MainList()
        {

        }
    }
}
