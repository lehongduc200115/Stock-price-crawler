using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingProjectWF
{
    public class Data
    {
        public int id { get; set; }
        public string sym { get; set; }
        public float lastPrice { get; set; }
        public int lastVol { get; set; }
        public string cl { get; set; }
        public float change { get; set; }
        public string changePc { get; set; }
        public int totalVol { get; set; }
        public DateTime time { get; set; }
        public string timeDisplay { get; set; }
        public float hp { get; set; }
        public string ch { get; set; }
        public float lp { get; set; }
        public string lc { get; set; }
        public float ap { get; set; }
        public string ca { get; set; }
        public DateTime timeServer { get; set; }
        public string timeServerDisplay { get; set; }
        public string sID { get; set; }
        public int lv { get; set; }
    }
}
