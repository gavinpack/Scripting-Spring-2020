using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidBodyForces : MonoBehaviour
{
    private Rigidbody _rigidBodyObj;
    public float force = 100;
    private Vector3 _forceVector;

    private void Start()
    {
        _rigidBodyObj = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        _forceVector.y = force;
        _rigidBodyObj.AddForce(_forceVector);
    }
}
