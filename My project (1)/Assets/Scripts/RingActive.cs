using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingActive : MonoBehaviour
{
   
    public GameObject silindir;
    public GameObject player;
    public float ringDistance;
    public static int score;
    public static int highScore;
    private Counter counterClass;

    void Update()
    {

        

        for (int i = 0; i < silindir.transform.childCount; i++)
        {   
            for(int k=0; k < 8; k++) { 
            if (player.transform.position.y >= silindir.transform.GetChild(i).position.y - ringDistance) 
                {                 
                    silindir.transform.GetChild(i).GetChild(k).gameObject.SetActive(true);
                }
            }
           
        }
        var contt = GameObject.FindWithTag("Counter");
        counterClass = contt.GetComponent<Counter>();
        
        if(player.transform.position.y >= counterClass.playerY + 1.2)
        {
            score+=10;    
            if(score > highScore)
            {
                highScore = score;
            }
            counterClass.playerY += 1.2f;
            counterClass.counter = 0;

        }


    }

 
}
