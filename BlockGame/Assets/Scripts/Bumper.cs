using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    public GameObject ball;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            audioSource.PlayOneShot(sound1);
            ScoreManager.score_num += 10;
        }
    }
}
