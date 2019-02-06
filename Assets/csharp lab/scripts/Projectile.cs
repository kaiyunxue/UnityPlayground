using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
    [HideInInspector]
    public float damageRadius = 1;
    public new Rigidbody rigidbody;
    void Reset()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
}
