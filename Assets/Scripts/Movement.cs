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

    void MoveKeys(){
        if  (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 1f * this.moveSpeed );
        }
        if  (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -1f * this.moveSpeed );
        }
        if  (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1f * this.moveSpeed , 0, 0);
        }
        if  (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1f * this.moveSpeed , 0, 0);
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
