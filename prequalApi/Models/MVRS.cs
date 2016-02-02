using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prequalApi.Models
{
    class MVRS
    {
        public int ID { get; set; }
        public string accountNumber { get; set; }
        public string meterNumber { get; set; }
        public string comment { get; set; }
        public string rdgRead { get; set; }
        //Date type in SQL
        public DateTime readDate { get; set; }
        public TimeSpan readTime { get; set; }
        public string readCode { get; set; }
        public string skipCode { get; set; }
        public string tCode1 { get; set; }
        public string tCode2 { get; set; }
        public string mReaderId { get; set; }
        public string readType { get; set; }
        public string preReading { get; set; }
        public string readMethod { get; set; }
        public string textPrompt { get; set; }
        public string FileName { get; set; }

    }
}
