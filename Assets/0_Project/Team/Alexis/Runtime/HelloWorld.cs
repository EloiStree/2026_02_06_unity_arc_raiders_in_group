using UnityEngine;

namespace Alexis.ArcNES
{
    public class HelloWorld : MonoBehaviour
    {
        [SerializeField] XboxMono_XboxWithCode m_xbox;
        public int m_valueA;
        public int m_valueB;
        public int m_resultAdition;
        public int m_resultSubstraction;
        public int m_resultMultiplication;
        public int m_resultDivision;

        public int m_onValidadedCount = 0;
        private void OnValidate()
        {
            m_onValidadedCount++;
            m_resultAdition = m_valueA + m_valueB;
            m_resultSubstraction = m_valueA - m_valueB;
            m_resultMultiplication = m_valueA * m_valueB;
            if (m_valueB != 0)
            {
                m_resultDivision = m_valueA / m_valueB;
            }
            else
            {
                m_resultDivision = 0;
            }
        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log("Hello World!");
            if (m_xbox == null)
            {
                m_xbox = GameObject.FindAnyObjectByType<XboxMono_XboxWithCode>();
                if (m_xbox == null)
                {
                    Debug.Log("No xbox found in scene");
                }


            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
