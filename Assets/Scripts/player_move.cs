using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{

    float moveSpeed = 8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            newPos.y += Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            newPos.y -= Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            newPos.x += Time.deltaTime * moveSpeed;
            gameObject.transform.localScale = new Vector3(6, 6, 6);
        }
        if (Input.GetKey(KeyCode.A))
        {
            newPos.x -= Time.deltaTime * moveSpeed;
            gameObject.transform.localScale = new Vector3(-6, 6, 6);
        }

        transform.position = newPos;
    }
}
