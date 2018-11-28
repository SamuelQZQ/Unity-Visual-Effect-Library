using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public GameObject hitPrefab;

	private GameObject hitVFX;

    private void OnCollisionEnter(Collision collision)
    {
		ContactPoint contact = collision.contacts[0];
		hitVFX = Instantiate(hitPrefab, contact.point, Quaternion.identity);
		hitVFX.transform.LookAt(collision.contacts[0].normal);
        Destroy(gameObject);
    }
}
