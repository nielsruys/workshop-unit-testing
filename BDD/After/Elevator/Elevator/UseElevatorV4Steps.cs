using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NSubstitute;

namespace Elevator
{
    [Binding]
    public class UseElevatorV4Steps
    {
        private IElevatorBox elevator;

        [Scope(Feature = "UseElevatorV4")]
        [Given(@"the elevator is on the (.*) floor")]
        public void GivenTheElevatorIsOnTheFloor(int currentFloor)
        {
            elevator = Substitute.ForPartsOf<ElevatorBox>();
            elevator.CurrentFloor = currentFloor;
        }

        [Scope(Feature = "UseElevatorV4")]
        [When(@"the following elevator users:")]
        public void GivenTheFollowingElevatorUsers(Table table)
        {
            var users = table.CreateSet<ElevatorUser>();

            foreach (var user in users)
            {
                user.CallElevator(elevator);
                user.RequestFloor(elevator);
            }
        }

        [Scope(Feature = "UseElevatorV4")]
        [When(@"the elevator operates")]
        public void WhenTheElevatorOperates()
        {
            elevator.Operate();
        }

        [Scope(Feature = "UseElevatorV4")]
        [Then(@"the elevator will open its door in this order:")]
        public void ThenTheElevatorWillOpenItsDoorInThisOrder(Table table)
        {
            for (var i = 0; i < table.RowCount; i++)
            {
                elevator.Received(1).OpenDoors(int.Parse(table.Rows[i]["Floor"]));
            }
        }
    }
}
