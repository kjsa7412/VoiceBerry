using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voice
{
    class RecodePage_Sub1_List
    {
        public string Message { get; set; }

        private string img_Back;
        public string Img_Back
        {
            get { return img_Back; }
            set { img_Back = value; }
        }

        private string tBox_SubTitle;
        public string TBox_SubTitle
        {
            get { return tBox_SubTitle; }
            set { tBox_SubTitle = value; }
        }

        private string tBox_Content;
        public string TBox_Content
        {
            get { return tBox_Content; }
            set { tBox_Content = value; }
        }

        private string tBox_Time;
        public string TBox_Time
        {
            get { return tBox_Time; }
            set { tBox_Time = value; }
        }
    }
}
