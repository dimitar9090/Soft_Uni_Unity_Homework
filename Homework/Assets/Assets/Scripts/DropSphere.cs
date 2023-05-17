using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class DropSphere : MonoBehaviour
{
    public GameObject sphere;
    public float fallSpeed = 115f;

    public Rigidbody rb;
    public float heavyMass = 10f;

    void Update()
    {
        var dropKey = Input.GetKeyDown(KeyCode.Space);

        if (dropKey)
        {
            GameObject clone = Instantiate(sphere, sphere.transform.position, transform.rotation);

            rb = clone.AddComponent<Rigidbody>();
            rb.mass = heavyMass;

            Destroy(clone, 5);

        }

    }

}