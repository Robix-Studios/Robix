using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class MovimentPlayer : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) rigidBody.AddForce(new Vector2(3*speed, 0));
        if (Input.GetKey(KeyCode.A)) rigidBody.AddForce(new Vector2(-3 * speed, 0));
        if (Input.GetKey(KeyCode.Space)) rigidBody.AddForce(new Vector2(0, 5 * speed));
    }
}
