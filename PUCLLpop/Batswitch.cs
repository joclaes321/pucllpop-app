using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUCLLpop
{
    class Batswitch
    {
        public Batswitch()
        {
            //this.Items = new IList<Batswitch>();

        }

        public IList<Batswitch> Items { get; private set; }

        public string Name{ get; set; }
        public string Tags { get; set; }
        public string Time { get; set; }
        public bool sw1 { get; set; }
        public bool sw2 { get; set; }
        public bool sw3 { get; set; }
        public bool sw4 { get; set; }
        public bool sw5 { get; set; }
        public bool sw6 { get; set; }




    }
}
