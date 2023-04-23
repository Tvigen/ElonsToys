class RemoteControlCar
{
    public int Distance = 0;
    public int Battery = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return "Driven " + Distance.ToString() + " meters";
    }

    public string BatteryDisplay()
    {
        if (Battery == 0)
        {
            return "Battery empty";
        }
        return "Battery at " + Battery + "%";
    }

    public void Drive()
    {
        if (Battery == 0)
        {
            return;
        }
        Distance += 20;
        Battery -= 1;
    }
}
