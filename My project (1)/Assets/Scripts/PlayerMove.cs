using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float jumpForce;

    public Rigidbody rb;
    public GameObject zemin;
    public bool onGround = true;
    private GameManager gm;
    private GameObject checkPoint;
    private Counter counterClass;
    public AudioClip[]  sounds;
    
    private GameObject Camera;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        zemin = GameObject.FindWithTag("Floor");
        rb = GetComponent<Rigidbody>();
        gm = GameObject.FindObjectOfType<GameManager>();
        checkPoint = GameObject.FindWithTag("checkPoint");

        Camera = GameObject.FindWithTag("MainCamera");
        audio = this.GetComponent<AudioSource>();

    }


    void FixedUpdate()
    {
        heroJump();

    }

    void heroJump()
    {
        
        if ((Input.GetKey(KeyCode.Space) || Input.touchCount> 0)&& onGround )
        {
            
            rb.velocity = Vector3.up * jumpForce;
            onGround = false;            
              
        }

        
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "checkPoint")
        {
            var contt = GameObject.FindWithTag("Counter");
            counterClass = contt.GetComponent<Counter>();
            audio.clip = sounds[1];
            //audio.Play();
            
            Debug.Log(audio.clip);

            //StatikClass.soundIndex = (StatikClass.soundIndex + 1) % 16;

            /*audio.clip = sounds[5];
            audio.Play();
           */
            /* if (counterClass.counter == 2)
             {


                 audio.clip = sounds[1];
                 //audio.Play();
                 audio.PlayOneShot(sounds[1]);
                 Debug.Log(audio.clip);

             }*/

            
            
                lapCounter(0);

            
            

           
        }
    }

    public void lapCounter(int k)
    {
        counterClass.counter++;
        if (counterClass.counter == 1)
        {
            audio.PlayOneShot(sounds[k+1]);
            
        }
        if (counterClass.counter == 2)
        {audio.Stop();
            audio.PlayOneShot(sounds[k+2]);
            
        }



        else if (counterClass.counter == 3)
        {audio.Stop();
            audio.PlayOneShot(sounds[k+3]);
            
            counterClass.counter = 0;
            SceneManager.LoadScene(2);




        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;
        if(collision.gameObject.tag == "Floor")
        {
            onGround = true;
            
        }

       /* if (materialName == "DangerZone (Instance)")
        {
            gm.RestartGame();
        }
       */
       
    }


}
