using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{

    private float topOfScene = 20.0f;
    private float bottomOfScene = -15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topOfScene)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomOfScene)
        {
            Destroy(gameObject);
        }
    }
}