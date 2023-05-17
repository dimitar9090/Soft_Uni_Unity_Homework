using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject plane;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;

    public float height = 4;
    public float distanceFromObject = 10f;

    
    void FixedUpdate()
    {
        Vector3 desiredPosition = plane.transform.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.LookAt(plane.transform.position);

        transform.position = plane.transform.position - plane.transform.forward * distanceFromObject;
        transform.position = new Vector3(transform.position.x, transform.position.y + height, transform.position.z);
    }
}