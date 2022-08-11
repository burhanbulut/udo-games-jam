using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takipKamera : MonoBehaviour
{
    public GameObject Target;
    public Vector3 Range;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, Target.transform.position + Range, Time.deltaTime);
    }
}
