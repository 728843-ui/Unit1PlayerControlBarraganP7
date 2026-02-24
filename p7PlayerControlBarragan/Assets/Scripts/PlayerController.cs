using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed;
    public float speed;
    public float verticalInput;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    

    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("VerticaL");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        //tilt this plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
