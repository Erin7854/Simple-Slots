using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Slots
{
    public class slotSpin
    {
        private List<slotsValue> slotValues = new List<slotsValue>(); //slots used to spin with
        private List<double> slotThresholds = new List<double>(); //thresholds for choosing slots when spinning
        private Random random = new Random();
        private string spinLine = "* * *";
        private int slotWidth = 0;
        private double spinWinnings = 0;

        public slotSpin(List<slotsValue> slotValues, List<double> slotThresholds, int slotWidth)
        {
            this.slotValues = slotValues;
            this.slotThresholds = slotThresholds;
            this.slotWidth = slotWidth;
        }
        /// <summary>
        /// Call to generate spinLine and spinWinnings values that can be read after this callback
        /// </summary>
        /// <param name="wager"></param>
        public void spin(double wager)
        {
            int rng;
            List<string> line = new List<string>(); //create emtpy list to store symbols

            //generate a symbol for each space in this row
            for (int i = 0; i < slotWidth; i++)
            {
                //choose a random symbol, weighted by their chance
                rng = random.Next(1, 100);

                for (int j = 0; j < slotThresholds.Count; j++)
                {
                    //choose symbol if rng is below their threshold
                    if (rng <= slotThresholds[j])
                    {
                        //add symbol and space character 
                        line.Add(slotValues[j].SlotSymbol);
                        line.Add(" ");
                        //dont want to add more symbols than necessary
                        break;
                    }
                }
                
            }
            //set the winnings based on the line created
            spinWinnings = wager * verifyWinnings(line);
            //set the line so that it can be read
            spinLine = string.Join("", line.ToArray());
        }
        /// <summary>
        /// returns a winning multiplier based off of the sum of the coeffcients of matching symbols. Will return 0 if symbols are not the same or can be wildcarded
        /// ONLY WORKS FOR WIDTH 3
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public double verifyWinnings(List<string> line)
        {
            double winningCoefficient = 0;
            //Will set true if a match of 3 (including wildcards) is found
            bool hasWon = false;
            //verify based on first symbol
            if (line[0] != "*")
            {
                //check second symbol matches
                if ((line[2] == line[0]) || (line[2] == "*"))
                {
                    //check third symbol matches
                    if ((line[4] == line[0]) || (line[4] == "*"))
                    {
                        hasWon = true;
                    }
                }
            }
            else
            {
                //if symbol 1 is a wildcard then if the second symbol is too its a match
                if (line[2] == "*")
                {
                    hasWon = true;
                }
                //if symbol 1 is a wild card, symbol 3 must match symbol 2 or be a wild card itself to win
                else if ((line[4] == line[2]) || (line[4] == "*"))
                {
                    hasWon = true;
                }
            }
            //create a list of slotsValues to iterate through to sum winning coefficients
            if (hasWon)
            {
                List<slotsValue> slots = new List<slotsValue>();

                for (int i = 0; i < line.Count; i += 2)
                {
                    foreach (slotsValue slot in slotValues)
                    {
                        if (line[i] == slot.SlotSymbol)
                        {
                            slots.Add(slot);
                        }
                    }
                }
                foreach (slotsValue slot in slots)
                {
                    winningCoefficient += slot.SlotCoefficient;
                }
            }
            return winningCoefficient;
        }

        public string SpinLine { get { return spinLine; } }
        public double SpinWinnings { get { return spinWinnings; } }
    }
}
