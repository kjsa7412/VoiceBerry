using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voice
{
    class SpeechPage_List
    {
        public string Message { get; set; }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string date;
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string img_Source;
        public string Img_Source
        {
            get { return img_Source; }
            set { img_Source = value; }
        }

        private string img_Source2;
        public string Img_Source2
        {
            get { return img_Source2; }
            set { img_Source2 = value; }
        }
    }
}
