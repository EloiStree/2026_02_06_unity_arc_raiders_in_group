using UnityEngine;

namespace ArcNes.Eloi
{
    public class Example_XboxArcRaidersAimingWrapper : MonoBehaviour
    {
        public XboxMono_XboxWithCode m_xbox;
        public float m_timeToAimUpToDown = 1;
        public float m_estimateDegreeHorizontalPerSecond = 90;
        public float m_estimateDegreeVerticalPerSecond = 90;

        public void AimUp()
            => m_xbox.StrokeKeyForSeconds(m_xbox.m_arrowDown, m_timeToAimUpToDown);
        public void AimDown()
            => m_xbox.StrokeKeyForSeconds(m_xbox.m_arrowUp, m_timeToAimUpToDown);

        public void AimUpForDegree(float degree)
        {
            throw new System.NotImplementedException();
        }
        public void AimDownForDegree(float degree)
        {
            throw new System.NotImplementedException();
        }
        public void AimDownThenOfDegreeUp(float degree)
        {
            throw new System.NotImplementedException();
        }
        public void AimUpThenOfDegreeDown(float degree)
        {
            throw new System.NotImplementedException();
        }
        public void TurnLeftForDegree(float degree)
        {
            throw new System.NotImplementedException();
        }
        public void TurnRightForDegree(float degree)
        {
            throw new System.NotImplementedException();
        }

    }
}
