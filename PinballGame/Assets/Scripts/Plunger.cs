using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunger : MonoBehaviour
{
    public GameObject ball;
    private Rigidbody ballrb;
    private Rigidbody rb;
    private BoxCollider collider;
    [SerializeField] private PhysicMaterial pm1;
    [SerializeField] private PhysicMaterial pm2;
    private bool plungerStart;
    public float plungerEmit;
    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        collider = GetComponent<BoxCollider>();
        collider.material = pm1;
        plungerStart = false;
        ballrb=ball.GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            plungerStart = true;
        }
        if(plungerStart)
        {
            if(Input.GetKeyUp(KeyCode.Space))
            {
                if(ball.transform.position.x > 8)
                {
                SwitchColider();
                audioSource.PlayOneShot(sound1);
                
                Vector3 force = new Vector3(0,0,plungerEmit);
                ball.GetComponent<Rigidbody>().AddForce(force,ForceMode.Force);
                
                Invoke("SwitchColider",3f);
                }
            }
        }
        
    }
    private void SwitchColider()
    {
        collider.enabled = !collider.enabled;
    }
}
