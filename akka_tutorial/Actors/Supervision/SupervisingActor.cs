using Akka.Actor;

namespace akka_tutorial.Actors.Supervision;

public class SupervisingActor : UntypedActor
{
    private IActorRef child = Context.ActorOf(Props.Create<SupervisedActor>(), "supervised-actor");

    protected override void OnReceive(object message)
    {
        switch (message)
        {
            case "failChild":
                child.Tell("fail");
                break;
        }
    }
}