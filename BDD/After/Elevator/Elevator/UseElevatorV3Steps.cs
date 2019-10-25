using TechTalk.SpecFlow;
using NSubstitute;

namespace Elevator
{
    [Binding]
    [Scope(Feature = "UseElevatorV3")]
    public class UseElevatorV3Steps
    {
        IElevatorBox elevator;
        ElevatorUser user;

        [Given(@"I am on the (.*) floor")]
        public void GivenIAmOnTheXFloor(int userLevel)
        {
            user = new ElevatorUser();
            user.CurrentFloor = userLevel;
        }

        [Given(@"the elevator is on the (.*) floor")]
        public void GivenTheElevatorIsOnTheXFloor(int elevatorLevel)
        {
            elevator = Substitute.ForPartsOf<ElevatorBox>();
            elevator.CurrentFloor = elevatorLevel;
        }

        [Given(@"no call for underground floor is registered")]
        public void GivenNoCallForUndergroundFloorIsRegistered()
        {
            elevator.ElevatorState = ElevatorState.Stopped;
        }

        [Given(@"a call for (.*) floor is registered")]
        public void GivenACallForXFloorIsRegistered(int callingLevel)
        {
            elevator.RegisterFloorRequest(callingLevel);
        }

        [When(@"I call elevator")]
        public void WhenICallElevator()
        {
            user.CallElevator(elevator);
        }

        [Then(@"the elevator opens door on (.*) level")]
        public void ThenTheElevatorOpensDoorOnXLevel(int openDoorLevel)
        {
            elevator.Received(1).OpenDoors(Arg.Is<int>(openDoorLevel));
        }

        [When(@"the elevator operates")]
        public void WhenTheElevatorOperates()
        {
            elevator.Operate();
        }
    }
}
