using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbit_movement : MonoBehaviour
{
    public float speed_x = .5f;
    public float speed_y = .5f;
    float start_x;
    public float distance = 5;
    float add_x;

    float start_y;
    float add_y;

    // Start is called before the first frame update
    void Start()
    {
        start_x = transform.position.x;
        start_y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //move planet using Mathf.PingPong

        add_x = Mathf.PingPong(Time.time * speed_x, distance) - distance/2f;
        add_y = Mathf.PingPong(Time.time * speed_y, distance) - distance/2f;
        transform.position = new Vector3(start_x + add_x, transform.position.y, transform.position.z);
        transform.position = new Vector3(transform.position.x, start_y + add_y, transform.position.z);

        if (start_y >= -16.2)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
        else if (start_y <= -16.2)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -9);
        }
    }
}
