using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{
    public GameObject explosionFX;
    public float explosionRadius;
    public float force;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision col)
    {
        Instantiate(explosionFX, transform.position, Quaternion.identity);
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, explosionRadius);
            }

        }

        Destroy(gameObject);
    }
}
