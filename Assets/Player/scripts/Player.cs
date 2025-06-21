using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    const float PLAYER_SPEED = 1.0f;
    // 自身情報
    Transform m_tfm;
    // 移動予定の座標
    Vector3 m_pos;

    Rigidbody2D  m_rigidbody2D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_tfm  = this.transform;
        m_pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // 上矢印が押された場合
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            m_pos.y += PLAYER_SPEED;
        }

        // 右矢印が押された場合
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            m_pos.x += PLAYER_SPEED;
        }

        // 下矢印が押された場合
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            m_pos.y -= PLAYER_SPEED;
        }

        // 左矢印が押された場合
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            m_pos.x -= PLAYER_SPEED;
        }

        m_tfm.position = m_pos;
    }


    public void FixedUpdate()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    /// 入った瞬間に呼び出しされる 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}// class
