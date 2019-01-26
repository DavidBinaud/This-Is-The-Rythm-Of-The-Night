using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Animator anim;
    public float maxSpeed = 5f;
    bool facingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        if (moveX != 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * maxSpeed * Time.deltaTime * 40, 0);
            anim.SetFloat("Speed", moveX);
        }

        if (moveY != 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, moveY * maxSpeed * Time.deltaTime * 40);
            
        }

        if (moveX > 0 && !facingRight)
        {
            Flip();
        }
        else if (moveX < 0 && facingRight)
        {
            Flip();
        }
    }
    

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
