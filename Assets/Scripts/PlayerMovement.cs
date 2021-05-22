using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D rb2d;
    public float speed = 5.0f;
    SpriteRenderer PacManSprite;
   

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        PacManSprite = GetComponent<SpriteRenderer>();
        
    }




    void    FixedUpdate()
    {
        if (Input.GetAxis("Horizontal")<0)
        {
            PacManSprite.flipX = true;
            rb2d.velocity = Vector2.left * speed;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            PacManSprite.flipX = false;
            rb2d.velocity = Vector2.right * speed;
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            PacManSprite.flipY = true;
            rb2d.velocity = Vector2.down * speed;
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            PacManSprite.flipY = false;
            rb2d.velocity = Vector2.up * speed;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ghost"))
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(1);

        }

    }
}
