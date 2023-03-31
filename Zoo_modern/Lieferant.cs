using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_modern {
    internal class Lieferant {
        private string name;

        public void SetName(string n) {
            name = n;
        }

        public string GetName() {
            return name;
        }

        public Lieferant(string name) {
            this.name = name;
        }

        public Rechnung RechnungErstellen() {
            return new Rechnung();
        }
    }
}
