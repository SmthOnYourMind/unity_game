using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    public float offset;
    public float offset_smoothing;
    private Vector3 player_position;

    // Update is called once per frame
    void Update()
    {
        player_position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    
        if (player.transform.localScale.x > 0)
        {
            player_position = new Vector3(player_position.x + offset, player_position.y, player_position.z);
        }
        else
        {
            player_position = new Vector3(player_position.x - offset, player_position.y, player_position.z);
        }

        transform.position = Vector3.Lerp(transform.position, player_position, offset_smoothing * Time.deltaTime);
    }
}
