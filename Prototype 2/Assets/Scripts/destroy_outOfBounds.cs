using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_outOfBounds : MonoBehaviour
{
    public float topBound = 50;
    public float lowerBound = -15;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("G A M E   O V E R E D");
            Destroy(gameObject);
        }
    }
}
