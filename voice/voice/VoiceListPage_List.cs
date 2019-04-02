using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voice
{
    class VoiceListPage_List
    {

        public string Message { get; set; }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string time;
        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        private string date;
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
