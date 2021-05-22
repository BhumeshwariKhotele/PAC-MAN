using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScriptBlinky : MonoBehaviour
{
    float Speedamt3 = 5.0f;
    SpriteRenderer PlayerSprite;

    void Start()
    {
        PlayerSprite = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //print(z.gameObject.name);

        if (collision.gameObject.CompareTag("right"))
        {
            PlayerSprite.flipX = false;
            Speedamt3 = -5.0f;
        }

        if (collision.gameObject.CompareTag("left"))
        {
            PlayerSprite.flipX = true;
            Speedamt3 = 5.0f;
        }

    }

    void Update()
    {
        transform.Translate(Speedamt3 * Time.deltaTime,0, 0);
    }
}
