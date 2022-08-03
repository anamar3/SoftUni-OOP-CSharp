using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot:IID
    {
        private string model;
        public Robot(string model,string iD)
        {
            Model = model;
            ID = iD;
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string ID { get; set; }

    }
}
