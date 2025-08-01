using akka_tutorial;
using Akka.Actor;

var sys = ActorSystem.Create("FirstActorSystem");

/*
 * PrintRef Actor Test
 *
 * var firstRef = sys.ActorOf(Props.Create<PrintRefActor>(), "first-actor");
 * Console.WriteLine($"First: {firstRef}");
 * firstRef.Tell("printit", ActorRefs.NoSender);
 */


 var firstStartStop = sys.ActorOf(Props.Create<StartStopActor1>(), "first_ss");
 firstStartStop.Tell("stop");


