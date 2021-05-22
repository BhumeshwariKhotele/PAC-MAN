using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PacDots : MonoBehaviour
{
    CountPacDots countPacdots;
    ScoreBoard scoreboard;
    AudioSource PacDotSound;

    void Start()
    {
        countPacdots = FindObjectOfType<CountPacDots>();
        scoreboard = FindObjectOfType<ScoreBoard>();
        PacDotSound = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
        {
        if (collision.gameObject.name == "Player")
        {
            if(countPacdots.count==188)
            {
                SceneManager.LoadScene(3);
            }
            PacDotSound.Play();
            Destroy(this.gameObject);
            scoreboard.IncrementScore();
            countPacdots.IncrementCount();
        }

    }
}
