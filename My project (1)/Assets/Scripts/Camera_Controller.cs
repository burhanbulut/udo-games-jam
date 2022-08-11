using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform hero;
    private Vector3 offset;
    public float smoothSpeed;
    void Start()
    {
        offset = transform.position - hero.position;

         
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, offset + hero.position, smoothSpeed);
        transform.position = newPos;

    }
}
