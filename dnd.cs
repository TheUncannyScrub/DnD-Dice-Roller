using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Dice_GUI
{
    public partial class dnd : Form
    {
        public int diceSides;
        public int diceRolls;
        public String storedValues;
        public Random random = new Random();



        private int rollDice(int sides)
        {
            int diceLanded = random.Next(1, sides+1);
            return diceLanded;
        }


        public dnd()
        {
            InitializeComponent();
        }

        private void btn_roll_Click(object sender, EventArgs e)
        {
            String rolls = txt_rolls.Text;
            String sides = txt_sides.Text;

            int rollValue = 0;
            int sideValue = 0;
            if (int.TryParse(rolls, out rollValue))
            {
                diceRolls = rollValue;

                if (int.TryParse(sides, out sideValue))
                {
                    diceSides = sideValue;

                    for (int i = 1; i <= diceRolls; i++)
                    {
                        storedValues += rollDice(diceSides) + ",";
                    }

                    string[] storedIntsAsStrings = storedValues.Split(',');
                    int[] storedIntsAsInts = new int[storedIntsAsStrings.Length];


                    for (int i = 0; i < storedIntsAsStrings.Length; i++)
                    {
                        int.TryParse(storedIntsAsStrings[i], out storedIntsAsInts[i]);
                    }

                    // rtf_output.AppendText(storedValues + "\n");
                    int lastIndex = storedValues.LastIndexOf(',');
                    rtf_output.AppendText("\n" + Convert.ToString(storedIntsAsInts.Sum()) + " : " + storedValues.TrimEnd(','));
                    rtf_output.ScrollToCaret();
                    storedValues = "";

                }
                else
                {
                    MessageBox.Show("The side value is not a number", "NaN - Side Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The roll value is not a number", "NaN - Roll Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
