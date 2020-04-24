using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ammo : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rigidBod;

    void Start()
    {
        rigidBod = GetComponent<Rigidbody>();
        rigidBod.velocity = transform.forward * speed;
        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter(Collider hitInfo)
    {
        Destroy(gameObject);
    }
}
