using Unity.VisualScripting;
using UnityEngine;

namespace gs
{ 
    public class Map_M : MonoBehaviour
    {
        // テストクラス
        class Test
        {
            private GameObject m_mapObj;
    
            public Test(GameObject mapObj)
            {
                m_mapObj = mapObj;
            }
    
            public void Move()
            {
                var pos  = m_mapObj.transform.position;
                pos.x += 0.01f;
                m_mapObj.transform.position = pos;
            }
        }//class
    
    
    
    
    
        [SerializeField]
        // こち見える
        private GameObject m_mapObj;
    
        Test m_test;
    
    
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
           var obj =  GameObject.Instantiate(m_mapObj);
            obj.transform.position = Vector3.zero;
            m_test = new Test(obj);
        }
    
        // Update is called once per frame
        void Update()
        {
            m_test.Move();
        }
        public void TestUpdate()
        {
            m_test.Move();
        }
    }// class
}// namespace
