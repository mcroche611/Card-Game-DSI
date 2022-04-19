using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Gaming.Input;
using Windows.UI.Xaml;

namespace card_game_DSI
{
    internal class InputHandler
    {
        private readonly object myLock = new object();
        private List<Gamepad> myGamepads = new List<Gamepad>();
        public Gamepad mainGamepad = null;
        GamepadReading reading, prereading;
        DispatcherTimer GamePadTimer;
        const float INPUT_DEADZONE = 0.1f;
        const float SENSIBILIDAD = 10.0f;
    }
}
