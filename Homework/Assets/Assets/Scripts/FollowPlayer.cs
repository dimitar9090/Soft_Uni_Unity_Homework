using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject plane;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;

    public float height = 4;
    public float distanceFromObject = 10f;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPosition = plane.transform.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        //transform.position = smoothPosition;

        transform.LookAt(plane.transform.position);

        //I have my own task too :D camera to be always behind object, but it cannot work if code above is active too

        transform.position = plane.transform.position - plane.transform.forward * distanceFromObject;
        transform.position = new Vector3(transform.position.x, transform.position.y + height, transform.position.z);
    }
}