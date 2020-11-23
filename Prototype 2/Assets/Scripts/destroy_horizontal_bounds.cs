using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_horizontal_bounds : MonoBehaviour
{
    public float rightBound = 50;
    public float leftBound = -50;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
            Debug.Log("game_overed");
        }
        else if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
