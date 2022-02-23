using System;
using System.Collections.Generic;
using System.Text;

namespace Project2021
{
    class Pool
    {
        private bool[] tracks;

        public Pool()
        {
            tracks = new bool[6];
            for (int i = 0; i < tracks.Length; i++)
            {
                tracks[i] = false;
            }
        }
        public void TrackReservationAdd(int track)
        {
            if (tracks[track-1] == false)
            {
                tracks[track - 1] = true;
            }
            else
            {
                Tools.WriteLineRed("This track is already taken. Please choose another.");
                Tools.Dots(5, 700);
            }
        }
        public bool TrackReservationDelete(int track)
        {
            if  (tracks[track-1] == true)
            {
                tracks[track - 1] = false;
                return true;
            }
            else
            {
                Tools.WriteLineRed("This track is not busy.");
                Tools.Dots(5, 700);
                return false;
            }
        }
        public override string ToString()
        {
            string info = "\t--- swimming pool ---\n";
            info += "\t";
            for (int t = 1; t < tracks.Length +1;t++)
            {
                info += "|" + t + "|";
            }
            info += " = Track number\n";

            for (int n = 0; n < 10; n++)
            {
                info += "\t";
                for (int i = 0; i < tracks.Length; i++)
                {
                    if (tracks[i])
                    {
                        info += "|X|";
                    }
                    else
                    {
                        info += "|O|";
                    }
                }
                info += "\n";
            }
            
            return info;
        }
    }
}
