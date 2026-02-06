using UnityEngine;

namespace Joachim.ArcNES
{
    public class HelloWorld : MonoBehaviour
    {
        public XboxMono_XboxWithCode xbox;
        public int m_timeToUnarmed = 2000;
      

        public  void UnarmedPlayer()
        {
            xbox.PressKey(xbox.m_buttonYUp);
            xbox.ReleaseKeyInMilliseconds(xbox.m_buttonYUp, m_timeToUnarmed);
        }

        public void JumpPlayer()
        {
            xbox.PressKey(xbox.m_buttonADown);
            xbox.ReleaseKeyInMilliseconds(xbox.m_buttonADown,2000);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
