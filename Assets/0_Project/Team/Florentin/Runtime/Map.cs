using UnityEngine;

namespace Florentin.ArcNES
{
    public class Map : MonoBehaviour
    {
        public XboxMono_XboxWithCode xbox;

        public int m_timeToActivateMap = 2000;

        public int peekMapTime = 1000;
        /* ----------------------------- PRESS TO SHOW OR HIDE MAP --------------------------- */
        
        [ContextMenu("Click to show map")]
        public void ShowMapOnClick()
        {  xbox.PressKeyInMilliseconds(1309,0);
            xbox.ReleaseKeyInMilliseconds(1309,m_timeToActivateMap);
        }
        
        [ContextMenu("Click to show map quickly")]
        public void ShowMapQuicklyOnClick()
        {  
            xbox.PressKeyInMilliseconds(1309,0);
            xbox.ReleaseKeyInMilliseconds(1309,m_timeToActivateMap);
            // Le bouton est pressé et relaché pour afficher la map
            // Il y a un délai 
            xbox.PressKeyInMilliseconds(1309,m_timeToActivateMap+peekMapTime);
            xbox.ReleaseKeyInMilliseconds(1309,m_timeToActivateMap*2+peekMapTime);
        }
        
        [ContextMenu("Click to hide map")]
        public void HideMapOnClick()
        {
            PressToHideMap(0f);
        }
        
        public void PressToHideMap(float seconds)
        {
            xbox.StrokeKeyInMilliseconds(1302,0,3000);
        }
    }
}