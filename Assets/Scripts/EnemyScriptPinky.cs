using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScriptPinky : MonoBehaviour
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

        if (collision.gameObject.CompareTag("up"))
        {
            PlayerSprite.flipY = false;
            Speedamt3 = -5.0f;
        }

        if (collision.gameObject.CompareTag("down"))
        {
            PlayerSprite.flipY = true;
            Speedamt3 = 5.0f;
        }

    }

    void Update()
    {
        transform.Translate(0, Speedamt3 * Time.deltaTime,0);
    }

}
