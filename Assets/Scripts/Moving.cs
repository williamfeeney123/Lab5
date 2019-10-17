using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{


    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movePosition = new Vector2(transform.position.x, transform.position.y);
        transform.position = movePosition;


      if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(movePosition.x + speed, movePosition.y);
        }

    }
}
