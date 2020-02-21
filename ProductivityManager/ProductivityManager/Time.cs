using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityManager
{
    class Timer
    {
        private int hours;
        private int minutes;
        private int seconds;
        private int timeLeft;


        //Takes hours, minutes, and seconds, stores them and sets the time left equal to that amount
        public void SetTime(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            ResetTime();
        }

        //Sets time left in seconds equal to the current stored hours, minutes, and seconds
        public void ResetTime()
        {
            timeLeft = TimeToSeconds(hours, minutes, seconds);
        }

        //Converts hours, minutes, and seconds to seconds
        private int TimeToSeconds(int hours, int minutes, int seconds)
        {
            return seconds + (minutes * 60) + (hours * 3600);
        }

        //Returns a string representing the time left in hh:mm:ss format 
        private String TimeLeftToString()
        {
            int tTime = timeLeft;
            String hours = (tTime / 3600).ToString();
            if (hours.Length < 2)
                hours = "0" + hours;
            tTime %= 3600;
            String minutes = (tTime / 60).ToString();
            if (minutes.Length < 2)
                minutes = "0" + minutes;
            tTime %= 60;
            String seconds = tTime.ToString();
            if (seconds.Length < 2)
                seconds = "0" + seconds;
            return $"{hours}:{minutes}:{seconds}";
        }

        //Updates the time left, returns true if there is time remaining, false if no time left
        public bool TimerTick()
        {
            if(timeLeft > 1)
            {
                timeLeft--;
                return true;
            }
            else if(timeLeft == 1)
            {
                timeLeft--;
                return false;
            }
            return false;
        }

        //Returns string representation of the time left
        public String ReadTime()
        {
            return TimeLeftToString();
        }

    }

    class Stopwatch
    {
        private int timeAccumulated;

        public Stopwatch()
        {
            timeAccumulated = 0;
        }

        //Updates the time accumulated
        public void StopwatchTick()
        {
            timeAccumulated++;
        }


        //Resets the stopwatch to 0 seconds
        public void ResetStopwatch()
        {
            timeAccumulated = 0;
        }

        //Returns the time accumulated as a string in hh:mm:ss format
        private String TimeAccToString()
        {
            int tTime = timeAccumulated;
            String hours = (tTime / 3600).ToString();
            if (hours.Length < 2)
                hours = "0" + hours;
            tTime %= 3600;
            String minutes = (tTime / 60).ToString();
            if (minutes.Length < 2)
                minutes = "0" + minutes;
            tTime %= 60;
            String seconds = tTime.ToString();
            if (seconds.Length < 2)
                seconds = "0" + seconds;
            return $"{hours}:{minutes}:{seconds}";
        }

        //Returns string representation of the time accumulated
        public String ReadTime()
        {
            return TimeAccToString();
        }


    }

}
