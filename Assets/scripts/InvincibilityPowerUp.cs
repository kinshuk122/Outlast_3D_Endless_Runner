using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class InvincibilityPowerUp : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public float timer = 0;
    private const string PlayerTag = "Player";
    public Material material;

    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(PlayerTag))
        {
            Pickup(other);
            other.GetComponent<Collider>().enabled = false;
            other.GetComponent<Rigidbody>().useGravity = false;
            material.color = Color.green;

            yield return new WaitForSeconds(4.0f);

            other.GetComponent<Collider>().enabled = true;
            other.GetComponent<Rigidbody>().useGravity = true;
            material.color = Color.red;
        }
    }

    void Pickup(Collider player)
    {
        meshRenderer.enabled = false;
    }
}
