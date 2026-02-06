using UnityEngine;

namespace Simon.ArcNES
{
    public class HelloWorld : MonoBehaviour
    {
        [SerializeField] private XboxMono_XboxWithCode m_Xbox;
        void Start()
        {
            if (m_Xbox == null)
            {
                m_Xbox = GameObject.FindAnyObjectByType<XboxMono_XboxWithCode>();
                if (m_Xbox == null)
                    Debug.LogWarning("No Xbox");
            }
               
        }

        void Update()
        {
        
        }
    }
}
