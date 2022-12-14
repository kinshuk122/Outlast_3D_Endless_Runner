using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class DeBuff : MonoBehaviour
{
    public Rigidbody rb;
    private float _debuffMass = 0.6f;
    private float _mass = 1f;
    private const string PlayerTag = "Player";

    IEnumerator OnTriggerEnter(Collider other)
    {
        if (CompareTag(PlayerTag))
        {
            rb.freezeRotation = false;
            rb.mass = _debuffMass;

            yield return new WaitForSeconds(3);

            rb.freezeRotation = true;
            rb.mass = _mass;
        }
    }
}
