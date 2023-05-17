using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2f;
    public float rotationSpeed = 50f;
    public float verticalInput;
    public float horizontalInput;

    // Update is called once per frame
    public void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");     //forwardInput
        horizontalInput = Input.GetAxis("Horizontal"); //sideInput

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
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