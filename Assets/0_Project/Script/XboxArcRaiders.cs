using System.Threading;
using UnityEngine;

public class XboxArcRaiders : MonoBehaviour
{

    public XboxMono_XboxWithCode xbox;


    [ContextMenu("Move Forward For One Seconds")]
    public void MoveForwardForOneSeconds()
    {
        MoveForwardForSeconds(1);
    }

    public void MoveForwardForSeconds(float seconds) {

        xbox.PressKeyInMilliseconds(1352, 0);
        xbox.ReleaseKeyInMilliseconds(1352, (int)(seconds*1000f));
    }
}
