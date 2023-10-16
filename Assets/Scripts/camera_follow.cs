using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour
{
    public Transform target;
    public float speed_smooth = 7f;
    public Vector3 offset;

      // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 desired_position = target.position + offset;
        Vector3 smoothed_position = Vector3.Lerp(transform.position, desired_position, speed_smooth * Time.deltaTime);

        transform.position = smoothed_position;   
    }
}