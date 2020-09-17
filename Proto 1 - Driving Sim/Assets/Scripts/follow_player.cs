using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_player : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 3, -7);
    
    // Update is called once per frame
    void Update()
    {
        //Makes the camera match the player's movement / position
        transform.position = player.transform.position + offset;
    }
}
