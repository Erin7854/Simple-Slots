using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Slots
{
    public class slotsValue
    {
        private string slotName; //plaintext slot name
        private string slotSymbol; //Character that will be displayed in the slot view
        private double slotCoefficient; //winnings multiplier
        private double slotChance; //chance for the symbol to appear in the machine

        public slotsValue(string slotName, string slotSymbol, double slotCoefficient, double slotChance)
        {
            this.slotName = slotName;
            this.slotSymbol = slotSymbol;
            this.slotCoefficient = slotCoefficient;
            this.slotChance = slotChance;
        }
        public string SlotName { get { return slotName; } }
        public string SlotSymbol { get { return slotSymbol; } }
        public double SlotCoefficient { get { return slotCoefficient; } }
        public double SlotChance { get { return slotChance; } }
    }
}
