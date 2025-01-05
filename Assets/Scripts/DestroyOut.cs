using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class DestroyOut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 30)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < -10)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -30)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > 30) 
        {
            Destroy(gameObject);
        }
    }
}
