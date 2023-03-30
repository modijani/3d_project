using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{


    private CharacterController controller;
    private Rigidbody rb3d;

    private float gravity = -9.81f;

    public float speedOfPlayer = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        rb3d = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = rb3d.velocity.y;


        Vector3 move = new
            Vector3(Input.GetAxis("Vertical"), gravity,
            Input.GetAxis("Horizontal"));

        controller.Move(move * Time.deltaTime * speedOfPlayer);

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colliding");
    }
}
