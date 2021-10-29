public class Gearbox
{
    public List<int> Gears = new List<int>();
    public int CurrentGear { get; private set; }

    public Gearbox(List<int> gears)
    {
        Gears = gears;
    }

    public void ChangeGear(int gear)
    {
        if (Gears.IndexOf(gear) != -1)
        {
            throw new ArgumentException();
        }
        else if (gear + 1 < CurrentGear || gear - 1 > CurrentGear)
        {
            throw new IllegalGearChangeException();
        }
        else
        {
            CurrentGear = gear;
        }
    }
}
