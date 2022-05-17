using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Slots
{
    public class slotsGame
    {
        private List<slotsValue> slotsValueList = new List<slotsValue>(); //list of all different values that can appear
        private double moneyCount; //money balance for the game
        private List<double> slotThresholds = new List<double>(); //index paired with slots value list. each value represents the threshold at which the value is picked
        private int rngMax = 100; // set rng to pick between 1 and 100
        private int slotWidth = 3; //number of slots in a row (number of columns)
        private int slotHeight = 4; // number of slots in a column (number of rows)

        public slotsGame()
        {
            this.moneyCount = 0;
        }

        /// <summary>
        /// Add a slotsValue to slotsValueList
        /// </summary>
        /// <param name="newSlot"></param>
        public void addSlotValue(slotsValue newSlot)
        {
            slotsValueList.Add(newSlot);
        }
        /// <summary>
        /// Setter for moneyCount. Will not update if moneyCount is below 1.
        /// </summary>
        /// <param name="deposit"></param>
        /// <returns></returns>
        public double setDeposit(double deposit)
        {
            if (moneyCount < 1)
            {
                this.moneyCount = deposit;
            }
            return money;
        }
        /// <summary>
        /// Iterate through each SlotValue to create a list of thresholds for RNG to use later. Safe to call multiple times.
        /// </summary>
        public void setSlotProbabilities()
        {
            double totalProbability = 0;
            slotThresholds.Clear(); //in case of calling multiple times
            foreach( slotsValue slot in slotsValueList)
            {
                totalProbability += slot.SlotChance * rngMax; // this creates a linear distribution so one slot symbol would be "1-45" and nother would be "46-70"
                slotThresholds.Add(totalProbability);
            }
        }
        /// <summary>
        /// Removes wager value from moneyCount
        /// </summary>
        /// <param name="wager"></param>
        public void wagerMoney(double wager)
        {
            moneyCount -= wager;
        }
        /// <summary>
        /// Adds winnings value to moneyCount
        /// </summary>
        /// <param name="winnings"></param>
        public void addWinnings(double winnings)
        {
            moneyCount += winnings;
        }

        public List<slotsValue> slotValues
        {
            get { return slotsValueList; }
        }
        public double money
        {
            get { return moneyCount; }
        }

        public int SlotHeight
        {
            get { return slotHeight; }
        }
        public int SlotWidth 
        { 
            get { return slotWidth; }
        }
        public List<double> SlotThresholds
        { 
            get { return slotThresholds; } 
        }
    }
}
