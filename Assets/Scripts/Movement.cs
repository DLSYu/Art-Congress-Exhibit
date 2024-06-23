using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotateSpeed;
    // Update is called once per frame
    void Update()
    {
        MoveKeys();

        MoveHead();
    }

    void FixedUpdate(){
        MoveKeys();
    }

    void MoveKeys(){
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * this.moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * this.moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * this.moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * this.moveSpeed * Time.deltaTime;
        }
    }

    void MoveHead(){
        //Move head with mouse
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        transform.Rotate(new Vector3(0, mouseX * this.rotateSpeed , 0));
        Camera.main.transform.Rotate(new Vector3(-mouseY  * this.rotateSpeed , 0, 0));
    }
}
