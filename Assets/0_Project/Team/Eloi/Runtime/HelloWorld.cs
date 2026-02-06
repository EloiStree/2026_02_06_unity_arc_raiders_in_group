using UnityEngine;

namespace Eloi.ArcNES
{
    
    public class HelloWorld : MonoBehaviour
    {
        [SerializeField] XboxMono_XboxWithCode m_xbox;
        public int m_valueA;
        public int m_valueB;
        public int m_resultAdition;
        public int m_resultSubtraction;
        public int m_resultMultiplication;
        public int m_resultDivision;

        public int m_onValidedCount = 0;

        [SerializeField] private float m_gameTime;

        public float GameTime
        {
            get { return m_gameTime; }
           // set { m_gameTime = value; }
        }

        private void FixedUpdate()
        {
            m_gameTime = Time.time;
        }

        private void OnValidate()
        {
            //++m_onvalidedcount;
            //m_onvalidedcount = m_onvalidedcount + 1;
            //m_onvalidedcount += 1;

            m_resultAdition = m_valueA + m_valueB;
            m_resultSubtraction = m_valueA - m_valueB;
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

        void Start()
        {
            Debug.Log("Hello World!");
            if (m_xbox == null)
            {
                m_xbox= GameObject.FindAnyObjectByType<XboxMono_XboxWithCode>();
                if(m_xbox == null)
                    Debug.LogError("No xbox found in scene");
            }

        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
