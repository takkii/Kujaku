using System;

namespace Kujaku
{
    public class Time
    {
        // private 
        private int Year;
        private int Month;
        private int Date;
        private int Hour;
        private int Minute;
        private int Second;

        // public
        public void DisplayCurrentTime()
        {
            System.Console.WriteLine("{0}/{1}/{2} {3}:{4}:{5}", Year, Month, Date, Hour, Minute, Second);
        }

        // コンストラクタ
        public Time( System.DateTime dt )
        {
            Year = dt.Year;
            Month = dt.Month;
            Date = dt.Day;
            Hour = dt.Hour;
            Minute = dt.Minute;
            Second = dt.Second;
        }
        public Time(int Year, int Month, int Date, int Hour, int Minite, int Second )
        {
            this.Year = Year;
            this.Month = Month;
            this.Date = Date;
            this.Hour = Hour;
            this.Minute = Minute;
            this.Second = Second;
        }
    }

    public class Kujaku{
        static void Main(){
            System.DateTime currentTime = System.DateTime.Now;

            Time t1 = new Time( currentTime );
            t1.DisplayCurrentTime();

            Time t2 = new Time(2019, 8, 24, 20, 5, 30);
            t2.DisplayCurrentTime();
        }
    }
}
