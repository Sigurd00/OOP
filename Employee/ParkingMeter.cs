using System;

namespace OOP
{
    public class ParkingMeter
    {
        private int Coins;

        public ParkingMeter()
        {
            Coins = 0;
        }

        public ParkingMeter(int coins)
        {
            Coins = coins;
        }

        public void InsertCoins(int coins)
        {
            Coins += coins;
        }
        public void PayForParking(int weekday, int hours)
        {
            if(weekday < 5)
            {
                Coins -= new ComputeParkingRateWeekday().ParkingRate() * hours;
            }
            else
            {
                Coins -= new ComputeParkingRateWeekend().ParkingRate() * hours;
            }
        }
        public void ShowCoins()
        {
            Console.WriteLine(Coins);
        }
    }
    public abstract class ComputeParkingRate
    {
        public abstract int ParkingRate();
    }
    public class ComputeParkingRateWeekday : ComputeParkingRate
    {
        public override int ParkingRate()
        {
            return 2;
        }
    }

    public class ComputeParkingRateWeekend : ComputeParkingRate
    {
        public override int ParkingRate()
        {
            return 3;
        }
    }
}