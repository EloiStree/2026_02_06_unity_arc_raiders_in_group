using System.Collections;
using UnityEngine;

namespace ArcNes.Eloi
{
    public class Example_CoroutineMove : MonoBehaviour
    {
        public XboxMono_XboxWithCode m_xbox;

        [ContextMenu("Move Front Rotate Right Then Go Backward")]
        public void MoveFrontRotateRightThenGoBackward()
        {
            StartCoroutine(Coroutine_FullTestFrontRightBack());
        }
        public IEnumerator Coroutine_FullTestFrontRightBack() {
            yield return Coroutine_MoveForwardForSeconds(10);
            yield return Coroutine_TurnRightForSeconds(10);
            yield return Coroutine_MoveBackwardForSeconds(10);
        }
        public void MoveForwardsForSeconds(float seconds)
        {
            StartCoroutine(Coroutine_MoveForwardForSeconds(seconds));
        }
        public void MoveForwardsForOneSecond()
        {
            StartCoroutine(Coroutine_MoveForwardForSeconds(1));
        }
        [ContextMenu("Move Forward for ten Seconds")]
        public void MoveForwardsForTenSeconds()
        {
            StartCoroutine(Coroutine_MoveForwardForSeconds(10));
        }
        public void MoveBackardsForOneSecond()
        {
            StartCoroutine(Coroutine_MoveBackwardForSeconds(1));
        }
        [ContextMenu("Move Backward for ten Seconds")]
        public void MoveBackardsForTenSecondS()
        {
            StartCoroutine(Coroutine_MoveBackwardForSeconds(10));
        }
        public void TurnRightForOneSecond()
        {
            StartCoroutine(Coroutine_TurnRightForSeconds(1));
        }
        [ContextMenu("Turn Right for ten Seconds")]
        public void TurnRightForTenSeconds()
        {
            StartCoroutine(Coroutine_TurnRightForSeconds(10));
        }

        public IEnumerator Coroutine_MoveForwardForSeconds(float seconds)
        {
            m_xbox.SetJoystickLeftWithPercent11(0, 1);
            yield return new WaitForSeconds(seconds);
            m_xbox.SetJoystickLeftWithPercent11(0, 0);
        }
        public IEnumerator Coroutine_TurnRightForSeconds(float seconds)
        {
            m_xbox.SetJoystickRightWithPercent11(1, 0);
            yield return new WaitForSeconds(seconds);
            m_xbox.SetJoystickRightWithPercent11(0, 0);
        }
        public IEnumerator Coroutine_MoveBackwardForSeconds(float seconds)
        {
            m_xbox.SetJoystickLeftWithPercent11(-1, 0);
            yield return new WaitForSeconds(seconds);
            m_xbox.SetJoystickLeftWithPercent11(0, 0);
        }
    }
}
