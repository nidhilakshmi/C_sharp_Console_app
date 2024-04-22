public class Bus 
{   private static Bus bus;
    private Bus()
    {
        
    }
    public string GetName()
    {
       return "KSRTC";
    }
    public static Bus GetBusName()
    {
       if(bus == null)
       {
        Bus bus1 = new Bus();
        bus =  bus1;
       }
       return bus;
    }
    
    // using this we can create only one object which means singleton implimentation
}