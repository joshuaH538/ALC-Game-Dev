using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public Vector3 offset = new Vector3(0, 3, -7);

    // Update is called once per frame
    void Update()
    {
        //makes camera follow plane
        transform.position = plane.transform.position + offset;
    }
}
