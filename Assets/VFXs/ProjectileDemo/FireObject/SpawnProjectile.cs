using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour {

    public GameObject firePoint;
    public GameObject projectilePrefab;
	public GameObject muzzlePrefab;
	[Range(0.1f, 1.0f)]public float shootGapTime = 0.5f;
	[Range(100,2000)]public float force = 100;

	private GameObject muzzle;
	private float coolDownRemian;

	void Start () {
		coolDownRemian = 0;
	}
	
	void Update () {
		coolDownRemian -= Time.deltaTime;
        if(Input.GetMouseButton(0) && firePoint && projectilePrefab && coolDownRemian <= 0)
        {
			coolDownRemian = shootGapTime;

			GameObject projectile = Instantiate(projectilePrefab, firePoint.transform.position, transform.rotation);
			projectile.GetComponent<Rigidbody>().AddForce(force * transform.forward);

			if (muzzle) Destroy(muzzle);
			muzzle = Instantiate(muzzlePrefab, firePoint.transform.position, transform.rotation);
        }
		
	}
}
