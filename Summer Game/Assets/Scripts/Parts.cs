using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parts : MonoBehaviour
{

    public int value;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && (gameObject.tag == "Cube"))
        {
            Destroy(gameObject);
            PartsCounter.instance.IncreaseCubes(value);
        }

        if (collision.gameObject.CompareTag("Player") && (gameObject.tag == "Sphere"))
        {
            Destroy(gameObject);
            PartsCounter.instance.IncreaseSpheres(value);
        }
    }

}
