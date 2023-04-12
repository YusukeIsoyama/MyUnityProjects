using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public float g;
    public float accelerateRatio;
    public static float spring_bounce;
    public float limit;
    private Rigidbody myRigid;
    public GameManager myManager;
    public GameObject leftarm;
    public GameObject rightarm;
    private float ballV = 0;
    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        myRigid=this.GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 force = new Vector3(0,0,g);
        this.GetComponent<Rigidbody>().AddForce(force,ForceMode.Force);
        if(myRigid.velocity.magnitude > ballV)
        {
            ballV=myRigid.velocity.magnitude;
            Debug.Log(ballV);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
            myManager.GameOver();
        }
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "Bumper")
        {
            myRigid.velocity *= accelerateRatio;
        }
        if(collision.gameObject.tag == "Player")
        {
            audioSource.PlayOneShot(sound1);
        }
        if(collision.gameObject.tag == "Spring")
        {
            Vector3 force = new Vector3(0,0,-spring_bounce);
            this.GetComponent<Rigidbody>().AddForce(force,ForceMode.Force);

        }
    }

}
