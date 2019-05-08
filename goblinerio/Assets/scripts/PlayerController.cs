using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.25f;
    public float strong = 10.0f;
    Rigidbody2D m_Rigidbody;
    readonly Vector2 force = new Vector2(0, 50);
    bool inAir;

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        float deltaX = Input.GetAxis("Horizontal") * speed; // зайди в Unity: Edit->Project Settings->Input ; в Inspector появится вкладка, где можно понять откуда я брал обозначения "Horizontal", "Vertical", "Mouse X","Mouse Y".
        float deltaZ = Input.GetAxis("Vertical") * speed;
        transform.Translate(deltaX, 0, deltaZ); // Translate - метод для перемещения персонажа. В данном случае в плоскости X0Z.
        if (Input.GetKey(KeyCode.Space) && !inAir)
        {
            inAir = true;
            m_Rigidbody.AddForce(force * strong);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
            inAir = false;
    }       
    
}
