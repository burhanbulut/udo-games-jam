using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{   [SerializeField]
    public float rotatitonSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        rotatitonSpeed += Time.deltaTime *2f;
        transform.Rotate(new Vector3(0, rotatitonSpeed , 0) * Time.deltaTime);
    }
}
