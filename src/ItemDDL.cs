using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestForm {
    // todo: struct?
    public class ItemDDL {
        private readonly string name;

        public double Code { get; private set; }

        public ItemDDL(string name, double code) {
            this.name = name;
            Code = code;
        }

        // Для отображения в OrganisationForm.cbBanks
        public override string ToString() {
            return this.name + " : " + Code.ToString();
        }
    }
}
