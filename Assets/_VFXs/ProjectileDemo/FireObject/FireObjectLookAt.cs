using UnityEngine;

public class FireObjectLookAt : MonoBehaviour 
{
	public Camera cam;
    void Start () 
    {

    }

    void Update () 
    {
		if(cam)
		{
			Ray rayMouse = cam.ScreenPointToRay(Input.mousePosition);

			RaycastHit hitInfo;
			if(Physics.Raycast(rayMouse, out hitInfo))
			{
				this.transform.LookAt(hitInfo.point);
			}
				
		}
		else
		{
			Debug.LogError("cam not exsist");
		}
		
	}
}
