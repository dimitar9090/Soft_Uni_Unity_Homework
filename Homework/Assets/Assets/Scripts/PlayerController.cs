using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2f;
    public float rotationSpeed = 50f;
    public float verticalInput;
    public float horizontalInput;

    
    public void Update()
    {
        
        verticalInput = Input.GetAxis("Vertical");     
        horizontalInput = Input.GetAxis("Horizontal"); 

        
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        
        var up = Input.GetKey(KeyCode.UpArrow);
        var down = Input.GetKey(KeyCode.DownArrow);

        var upRoll = Input.GetKey(KeyCode.Q);
        var downRoll = Input.GetKey(KeyCode.E);

        if (up)
        {
            transform.Rotate(-20 * Time.deltaTime, 0, 0);
        }
        else if (down)
        {
            transform.Rotate(20 * Time.deltaTime, 0, 0);
        }

        if (upRoll)
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
        else if (downRoll)
        {
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
        }

        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * horizontalInput);
    }
}