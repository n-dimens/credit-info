using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestForm {
    public class ItemDDL {
        public double Code { get; set; }
        public string Name { get; set; }
        public override string ToString() {
            return Name + " :" + Code.ToString();
        }
    }
}
