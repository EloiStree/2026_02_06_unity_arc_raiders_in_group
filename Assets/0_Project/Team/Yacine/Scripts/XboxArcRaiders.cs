using Mono.Cecil.Cil;
using UnityEngine;

public class YacineXboxArcRaiders : MonoBehaviour
{
    public XboxMono_XboxWithCode xbox;

    [ContextMenu("Move Forward For One Second")]
    public void MoveForwardForOneSecond()
    {
        MoveForwardForSeconds(1);
    }

    [ContextMenu("Move Left For One Second")]
    public void MoveLeftForOneSecond()
    {
        MoveLeftForSeconds(1);
    }

    [ContextMenu("Move Right For One Second")]
    public void MoveRightForOneSecond()
    {
        MoveRightForSeconds(1);
    }

    [ContextMenu("Move Backward For One Second")]
    public void MoveBackwardForOneSecond()
    {
        MoveBackwaredForSeconds(1);
    }

    [ContextMenu("Jump For One Second")]
    public void JumpForOneSecond()
    {
        JumpForSeconds(1);
    }

    [ContextMenu("Shoulder Swap For One Second")]
    public void ShoulderSwapForOneSecond()
    {
        ShoulderSwapForSeconds(1);
    }

    [ContextMenu("Sprint For One Second")]
    public void SprintForOneSecond()
    {
        SprintForSeconds(1);
    }

    [ContextMenu("Sprint For Three Seconds")]
    public void SprintForThreeSeconds()
    {
        SprintForSeconds(3);
    }

    [ContextMenu("Crouch For One Second")]
    public void CrouchForOneSecond()
    {
        CrouchForSeconds(1);
    }

    [ContextMenu("Forward Dodge Roll")]
    public void ForwardDodgeRoll()
    {
        SprintForSeconds(2);
        DodgeRoll();
    }

    public void RotateRightForSeconds(float seconds)
    {
        xbox.PressKeyInMilliseconds(xbox.m_rightStickHorizontalP100Percent, 0);
        xbox.ReleaseKeyInMilliseconds(xbox.m_rightStickHorizontalP100Percent, (int)(seconds * 1000f));
    }

    public void RotateLeftForSeconds(float seconds)
    {
        xbox.PressKeyInMilliseconds(xbox.m_rightStickHorizontalN100Percent, 0);
        xbox.ReleaseKeyInMilliseconds(xbox.m_rightStickHorizontalN100Percent, (int)(seconds * 1000f));
    }

    public void MoveForwardForSeconds(float seconds)
    {
        MoveForSeconds(xbox.m_leftStickVerticalP100Percent, seconds);
    }

    private void MoveLeftForSeconds(float seconds)
    {
        MoveForSeconds(xbox.m_leftStickHorizontalN100Percent, seconds);
    }

    private void MoveRightForSeconds(float seconds)
    {
        MoveForSeconds(xbox.m_leftStickHorizontalP100Percent, seconds);
    }

    public void MoveBackwaredForSeconds(float seconds)
    {
        MoveForSeconds(xbox.m_leftStickVerticalN100Percent, seconds);
    }

    public void JumpForSeconds(float seconds)
    {
        MoveForSeconds(xbox.m_buttonADown, seconds);
    }

    public void ShoulderSwapForSeconds(float seconds)
    {
        MoveForSeconds(xbox.m_buttonRightStick, seconds);
    }

    private void SprintForSeconds(float seconds)
    {
        xbox.PressKeyInMilliseconds(xbox.m_leftStickVerticalP100Percent, 0);
        xbox.PressKeyInMilliseconds(xbox.m_buttonLeftStick, 0);

        xbox.ReleaseKeyInMilliseconds(xbox.m_leftStickVerticalP100Percent, (int)(seconds * 1000f));
        xbox.ReleaseKeyInMilliseconds(xbox.m_buttonLeftStick, (int)(seconds * 1000f));
    }

    public void CrouchForSeconds(float seconds)
    {
        MoveForSeconds(xbox.m_buttonBRight, seconds);
    }

    private void DodgeRoll()
    {
        for (int i = 0; i < 4; i += 2)
        {
            xbox.PressKeyInMilliseconds(xbox.m_buttonBRight, i * 100);
            xbox.ReleaseKeyInMilliseconds(xbox.m_buttonBRight, (i + 1) * 100);
        }
    }

    private void MoveForSeconds(int code, float seconds)
    {
        xbox.PressKeyInMilliseconds(code, 0);
        xbox.ReleaseKeyInMilliseconds(code, (int)(seconds * 1000f));

        xbox.PressKeyInMilliseconds(xbox.m_leftStickNeutral, (int)(seconds * 1000f) + 100);
        xbox.ReleaseKeyInMilliseconds(xbox.m_leftStickNeutral, (int)(seconds * 1000f) + 200);
    }
}
