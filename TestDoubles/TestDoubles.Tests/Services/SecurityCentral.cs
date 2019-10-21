using TestDoubles.Tests.Models;

namespace TestDoubles.Tests.Services
{
    public class SecurityCentral
    {
        private readonly Window _window;
        private readonly Door _door;

        public SecurityCentral(Window window, Door door)
        {
            this._window = window;
            this._door = door;
        }

        public void SecurityOn()
        {
            _window.Close();
            _door.Close();
        }
    }
}
