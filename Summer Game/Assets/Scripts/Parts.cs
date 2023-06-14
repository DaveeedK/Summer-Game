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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && (gameObject.tag == "cube"))
        {
            Destroy(gameObject);
            PartsCounter.instance.IncreaseCubes(value);
        }

        if (other.gameObject.CompareTag("Player") && (gameObject.tag == "sphere"))
        {
            Destroy(gameObject);
            PartsCounter.instance.IncreaseSpheres(value);
        }
    }

}
