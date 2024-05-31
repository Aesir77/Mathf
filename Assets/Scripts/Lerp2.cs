using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp2 : MonoBehaviour
{
    public Transform A, B;
    public float mean;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(A.position, B.position, mean);
    }
}
