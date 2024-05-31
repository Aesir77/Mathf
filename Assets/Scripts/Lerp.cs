using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    public Transform A, B;
    public float speed;
   
   
    
    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
       A.position = Vector3.Lerp(transform.position, B.position, speed * Time.deltaTime);
        float distance = Vector3.Distance(transform.position, B.position);
      
    }

  
}
