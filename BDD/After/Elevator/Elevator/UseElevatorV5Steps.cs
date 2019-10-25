using System;
using NSubstitute;
using TechTalk.SpecFlow;

namespace Elevator
{
    [Binding]
    [Scope(Feature = "UseElevatorV5")]
    public class UseElevatorV5Steps
    {
        private IElevatorBox elevator;

        [Given(@"the elevator is on the (.*) floor")]
        public void GivenTheElevatorIsOnTheFloor(int currentFloor)
        {
            elevator = Substitute.ForPartsOf<ElevatorBox>();
            elevator.CurrentFloor = currentFloor;
        }

        [Given(@"(.*) wants to take elevator from (.*) floor to (.*) floor")]
        public void GivenUserWantsToTakeElevatorFromFloorToFloor(string userName, int currentFloor, int goingTo)
        {
            var user = new ElevatorUser
            {
                Name = userName,
                CurrentFloor = currentFloor,
                GoingTo = goingTo
            };
            user.CallElevator(elevator);
            user.RequestFloor(elevator);
        }

        [When(@"the elevator operates")]
        public void WhenTheElevatorOperates()
        {
            elevator.Operate();
        }

        [Then(@"the elevator opens doors on (.*) floor")]
        public void ThenTheElevatorOpensDoorsOnFloor(int expectedFloor)
        {
            elevator.Received().OpenDoors(expectedFloor);
        }
    }
}
