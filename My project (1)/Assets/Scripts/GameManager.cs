using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Transform hero;
    public float ringDistance;
    public GameObject ring;   
    public float ringRange;
    public GameObject ring1;
    [SerializeField]
    private GameObject cylinder;
    private int rand;  
    private GameObject createRing;
    [SerializeField]
    public Material dangerZone;
    [SerializeField]
    private TextMeshProUGUI scoreTxt;
    [SerializeField]
    private Material Floor2;
    [SerializeField]
    public Material Floor3;
    [SerializeField]
    public Material Floor4;
    [SerializeField]
    public Material Floor5;
    [SerializeField]
    public Material Floor6;
    void Start()
    {
        
       /* Camera = GameObject.FindWithTag("MainCamera");
        audio = Camera.GetComponent<AudioSource>();*/
    }
    void Update()
    {
        ring = GameObject.FindWithTag("Ring");
        DestroyAndCreateRing();
        scoreTxt.text = RingActive.score.ToString();
             
       
    }

    void level()
    {

        createRing = Instantiate(ring1, new Vector3(0, ring.transform.position.y + ringRange * 5, 0), Quaternion.identity, cylinder.transform);
        rand = Random.Range(0, 8);
        int rand2 = Random.Range(0, 8);
        
        createRing.transform.GetChild(rand).gameObject.SetActive(false);

       while(rand2 == rand)
        {
            rand2 = Random.Range(0, 8);
        }
       
        while (true)
        {
            if (RingActive.score %250 >= 10 && RingActive.score %250<= 60) {
                
                for (int i = 0; i < 8; i++)
                {
                    createRing.transform.GetChild(i).gameObject.GetComponent<MeshRenderer>().material = Floor2;
                    
                }            
                }

           else if(RingActive.score %250 >=70 && RingActive.score %250 < 120)
            {
                for (int i = 0; i < 8; i++)
                {
                    createRing.transform.GetChild(i).gameObject.GetComponent<MeshRenderer>().material = Floor3;

                }
            }
            else if (RingActive.score % 250 >= 120 && RingActive.score % 250 < 170)
            {
                for (int i = 0; i < 8; i++)
                {
                    createRing.transform.GetChild(i).gameObject.GetComponent<MeshRenderer>().material = Floor4;

                }
            }
            else if (RingActive.score % 250 >= 170 && RingActive.score % 250 < 220)
            {
                for (int i = 0; i < 8; i++)
                {
                    createRing.transform.GetChild(i).gameObject.GetComponent<MeshRenderer>().material = Floor5;

                }
            }
            else// if (RingActive.score % 250 >= 220  || RingActive.score % 250 == 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    createRing.transform.GetChild(i).gameObject.GetComponent<MeshRenderer>().material = Floor6;

                }
            }

            break;

        }
     
        createRing.transform.GetChild(rand2).gameObject.GetComponent<MeshRenderer>().material = dangerZone;
    }

    void DestroyAndCreateRing()
    {

        if (hero.transform.position.y > ring.transform.position.y + ringDistance * 2)
        {

            level();
            Destroy(ring);
                       
        }
    }
      

   
}
