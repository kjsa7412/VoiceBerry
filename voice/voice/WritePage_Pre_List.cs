using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voice
{
    class WritePage_Pre_List
    {
        public string Message { get; set; }

            private string img_Back;
            public string Img_Back
            {
                get { return img_Back; }
                set { img_Back = value; }
            }

            private string height_Back;
            public string Height_Back
            {
                get { return height_Back; }
                set { height_Back = value; }
            }

            private string visible_Content;
            public string Visible_Content
            {
                get { return visible_Content; }
                set { visible_Content = value; }
            }

            private string text_Title;
            public string Text_Title
            {
                get { return text_Title; }
                set { text_Title = value; }
            }

            private string text_Content;
            public string Text_Content
            {
                get { return text_Content; }
                set { text_Content = value; }
            }

            private string height_Content;
            public string Height_Content
            {
                get { return height_Content; }
                set { height_Content = value; }
            }
    }
}
