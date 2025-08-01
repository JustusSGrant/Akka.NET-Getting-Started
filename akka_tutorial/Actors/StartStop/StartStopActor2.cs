using Akka.Actor;

namespace akka_tutorial;

public class StartStopActor2 : UntypedActor
{
    protected override void PreStart() => Console.WriteLine("second Started");
    protected override void PostStop() => Console.WriteLine("second Stopped");

    protected override void OnReceive(object message)
    {
    }
}