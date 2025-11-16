using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public static float Speed = 1.5f;
    public static float RotationSpeed = 1.0f;
    public static Rigidbody Physics;
    public static float JumbFloat = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        Physics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0, vertical) * Speed * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(0, mouseX * RotationSpeed, 0);             
        Camera.main.transform.Rotate(-mouseY * RotationSpeed, 0, 0);
        
        /**************************************************************************************************/

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Physics.AddForce(new Vector3(0, JumbFloat,0), ForceMode.Impulse);
        }


    }

}
