using Unity.Plastic.Newtonsoft.Json.Bson;
using UnityEngine;

namespace ArcNes.Eloi
{


    public class Example_XboxArcRaidersBasicMainMenu : MonoBehaviour { 
    


        public void StartGame()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("ArcRaiders_MainScene");
        }

    }
    // TO BE TESTED;
    public class Example_XboxArcRaidersBasicWrapper : MonoBehaviour
    {
        public XboxMono_XboxWithCode m_xbox;

        public float m_quickPressionTime= 0.2f;
        public float m_unarmedPressionTime = 0.5f;

        public float m_joystickPressionTime = 0.2f;
        public float m_timeToAimUpToDown = 1;

        public void PressAndReleaseKeyQuickly(int keyCodeDown) {
            m_xbox.PressKey(keyCodeDown);
            m_xbox.ReleaseKeyInSeconds(keyCodeDown, m_quickPressionTime);
        }


        public void Surrender() {
            throw new System.NotImplementedException();
        }

        public void Jump()
            => PressAndReleaseKeyQuickly(m_xbox.m_buttonADown);
        public void Crouch()
            => PressAndReleaseKeyQuickly(m_xbox.m_buttonBRight);

        public void DodgeRoll()
            => m_xbox.DoubleClick(m_xbox.m_buttonBRight,500,500);

        public void Unarmed()
            => m_xbox.StrokeKeyY_ForSeconds(m_unarmedPressionTime);


        public void MeleeWeapon()
            => PressAndReleaseKeyQuickly(m_xbox.m_arrowLeft);

        public void SwapWeapon()
            => PressAndReleaseKeyQuickly(m_xbox.m_buttonYUp);

        public void OpenEmoteForSeconds(float seconds)
            => m_xbox.StrokeKeyInSeconds(m_xbox.m_arrowUp, 0,seconds);

        public void StartProximityTalk()
            => m_xbox.PressKey(m_xbox.m_arrowLeft);

        public void StopProximityTalk()
            => m_xbox.ReleaseKey(m_xbox.m_arrowLeft);


        public void ToggleFlashlight()
            => PressAndReleaseKeyQuickly(m_xbox.m_arrowRight);

        public void ShoulderSwap()
            => m_xbox.StrokeKeyForSeconds(m_xbox.m_buttonRightStick, m_joystickPressionTime);
        public void ToggleSprint()
            => m_xbox.StrokeKeyForSeconds(m_xbox.m_buttonLeftStick, m_joystickPressionTime);
        public void OpenMap()
            => m_xbox.StrokeKeyForSeconds(m_xbox.m_buttonMenuLeft, m_joystickPressionTime);
        public void OpenInventory()
            => m_xbox.StrokeKeyForSeconds(m_xbox.m_buttonMenuLeft, 0.1f);
        public void OpenMenu()
            => m_xbox.StrokeKeyForSeconds(m_xbox.m_buttonMenuRight, 0.1f);

        public void CircleItem()
            => PressAndReleaseKeyQuickly(m_xbox.m_buttonLeftSide);

        public void Ping()
            => PressAndReleaseKeyQuickly(m_xbox.m_buttonRightSide);

        public void Interact()
            => PressAndReleaseKeyQuickly(m_xbox.m_buttonXLeft);
        public void Reload()
            => PressAndReleaseKeyQuickly(m_xbox.m_buttonXLeft);


        public void SwapSecretPocketWithItemOne() {

            throw new System.NotImplementedException();
        }
    }
}
