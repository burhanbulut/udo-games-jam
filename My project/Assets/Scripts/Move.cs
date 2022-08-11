using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float forwardSpeed;
    [SerializeField]
    private float turnSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yatayEksen = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        this.transform.Translate(yatayEksen, 0, forwardSpeed*Time.deltaTime);
    }
}
