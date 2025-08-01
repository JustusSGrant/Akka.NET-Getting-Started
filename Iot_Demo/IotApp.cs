using Akka.Actor;

namespace Iot_Demo;

public class IotApp
{
    public static void Init()
    {
        using (var system = ActorSystem.Create("iot-system"))
        {
            var supervisor = system.ActorOf(IotSupervisor.Props(), "iot-supervisor");
            Console.ReadLine();
        }
    }
}