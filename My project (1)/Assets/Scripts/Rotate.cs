using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{   [SerializeField]
    private float rotatitonSpeed;
    

    void Update()
    {
        rotatitonSpeed += Time.deltaTime *2f;
        transform.Rotate(new Vector3(0, rotatitonSpeed , 0) * Time.deltaTime);
    }
}
