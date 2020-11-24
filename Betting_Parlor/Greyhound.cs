using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Betting_Parlor
{
    class Greyhound
    {
        public int startingPosition;
        public int racetrackLength;
        public int Location;
        public PictureBox MyPictureBox=null;
        public bool Run(int advance)
        {
            Location += advance;
            MyPictureBox.Left = startingPosition + advance;
            startingPosition = MyPictureBox.Location.X;
            if (startingPosition >= racetrackLength-100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void TakeStartingPosition()
        {

            
            if (startingPosition >= 0)
            {
                MyPictureBox.Left = startingPosition - (450);
                startingPosition = MyPictureBox.Location.X;
            }
        }
    }
}
