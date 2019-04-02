using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voice
{
    public class TodoItem
    {
        public string Id { get; set; }

        //[JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        //[JsonProperty(PropertyName = "complete")]
        public bool Complete { get; set; }
    }

    public class test
    {
        public int Id { get; set; }

        //[JsonProperty(PropertyName = "text")]
        public string a { get; set; }

        //[JsonProperty(PropertyName = "complete")]
        public string b { get; set; }
    }

    public class User1
    {
        public string id { get; set; }

        //[JsonProperty(PropertyName = "text")]
        public string u_name { get; set; }

        public string u_pass { get; set; }

        public string u_profile { get; set; }
        public string u_pic { get; set; }
        public int u_requestes { get; set; }
        public int u_followers { get; set; }
        public int u_folloing { get; set; }

    }
}
