using UnityEngine;

public class DelayDestroy : MonoBehaviour 
{
	public float delay = 1;
	
    void Update () 
    {
		delay -= Time.deltaTime;
		if (delay <= 0) Destroy(gameObject);
    }
}
