using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerControler : MonoBehaviour

{
    public float speed = 10f;
    public float rotationSpeed = 45f;

    private Vector3 input;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        input.z = Input.GetAxis( "Vertical");
        input.x = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * input.z);
        transform.Rotate(input.z * input.x * rotationSpeed * Time.deltaTime * Vector3.up);
    } 
}
