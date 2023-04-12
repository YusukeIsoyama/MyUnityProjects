using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed ;
    public float rotate_speed;
    public float spring_speed1;
    public float spring_speed2;
    public GameObject left;
    public GameObject right;
    public GameObject spring;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (left.transform.rotation.y >-0.4)
            {
                left.transform.Rotate(0,-rotate_speed,0);
            }
        } else {
            if (left.transform.rotation.y < 0.3)
            {
                left.transform.Rotate(0,rotate_speed,0);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (right.transform.rotation.y < 0.4)
            {
                right.transform.Rotate(0,rotate_speed,0);
            }

        } else {
            if (right.transform.rotation.y > -0.3)
            {
                right.transform.Rotate(0,-rotate_speed,0);
            }

        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (spring.transform.localScale.z > 0.5)
            {
                Vector3 springScale;
                springScale = spring.transform.localScale;
                springScale.z -= spring_speed1;
                spring.transform.localScale = springScale;
            } 
        } else if (spring.transform.localScale.z < 1)
        {
                Vector3 springScale;
                springScale = spring.transform.localScale;
                springScale.z += spring_speed2;
                spring.transform.localScale = springScale;
        }
        
        
    }    
    
}
