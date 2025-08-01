using Akka.Actor;
using Akka.Event;

namespace Iot_Demo;

public class IotSupervisor : UntypedActor
{
    public ILoggingAdapter Log { get; } = Context.GetLogger();

    protected override void PreStart() => Log.Info("IoT App Started");
    protected override void PostStop() => Log.Info("IoT App Stopped");

    protected override void OnReceive(object message)
    {
    }

    public static Props Props() => Akka.Actor.Props.Create<IotSupervisor>();
}