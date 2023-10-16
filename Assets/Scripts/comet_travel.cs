using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comet_travel : MonoBehaviour
{
    [SerializeField] private Vector3 target = new Vector3(175, 1, 0);
    [SerializeField] private float speed = 1;

    float start_x;
    float start_y;

    // Start is called before the first frame update
    void Start()
    {
        start_x = transform.position.x;
        start_y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        // Moves the object to target position
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
    }
}
