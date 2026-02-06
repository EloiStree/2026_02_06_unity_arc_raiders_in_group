using UnityEngine;

namespace Blen.ArcNES
{
    public class InputJoystickToArcGame : MonoBehaviour
    {
        public XboxMono_XboxWithCode m_xbox;
        public Vector2 m_joystickLeft;


        public void SetJoystick(Vector2 joystickLeft)
        {
            m_joystickLeft = joystickLeft;
            m_xbox.SetLeftStickVerticalValuePercent11( m_joystickLeft.y);
            m_xbox.SetRightStickHorizontalValuePercent11(m_joystickLeft.x);

        }

    }
}
