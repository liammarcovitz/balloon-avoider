using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static float speed = 15;

    private float horizontalInput;
    private float verticalInput;
    public static float xLimit = 7.7f;
    public static float yLimit = 3.8f;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.down * verticalInput * Time.deltaTime * speed);

        // limit y movement

        if (transform.position.y > yLimit)
        {
            transform.position = new Vector3(transform.position.x, yLimit, transform.position.z);
        }
        else if (transform.position.y < -yLimit)
        {
            transform.position = new Vector3(transform.position.x, -yLimit, transform.position.z);
        }

        // limit x movement

        if (transform.position.x > xLimit)
        {
            transform.position = new Vector3(xLimit, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -xLimit)
        {
            transform.position = new Vector3(-xLimit, transform.position.y, transform.position.z);
        }
    }
}
