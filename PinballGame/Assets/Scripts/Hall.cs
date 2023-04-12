using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hall : MonoBehaviour
{
    public GameObject ball;
    Vector3 pos =  new Vector3(10,1,-2);
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            ScoreManager.score_num += 100;
            ball.transform.position = pos;
        }
    }
}
