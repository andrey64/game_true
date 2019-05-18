using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float hight = 5f;
    Rigidbody2D m_Rigidbody;
    readonly Vector2 force = new Vector2(0, 50);
    bool inAir;
    public float speed = 0.25f;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && !inAir)
        {
            inAir = true;
            m_Rigidbody.AddForce(force * hight);
        }

        float deltaX = Input.GetAxis("Horizontal") * speed; // зайди в Unity: Edit->Project Settings->Input ; в Inspector появится вкладка, где можно понять откуда я брал обозначения "Horizontal", "Vertical", "Mouse X","Mouse Y".

        transform.Translate(deltaX, 0, 0);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
            inAir = false;
    }
    
}
