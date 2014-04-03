using UnityEngine;
using System.Collections;

public class cubemove: MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
		void FixedUpdate () {
			
			if ( Input.GetKey (KeyCode.UpArrow) )
			{
				rigidbody.AddForce ( transform.up * 20f );
			}

		if ( Input.GetKey (KeyCode.DownArrow) )
		{
			rigidbody.AddForce ( -transform.up * 20f );
		}

		if ( Input.GetKey (KeyCode.RightArrow) )
		{
			rigidbody.AddForce ( transform.right * 20f );
		}
			
			if ( Input.GetKey (KeyCode.LeftArrow) )
			{
				rigidbody.AddForce ( -transform.right * 20f );
			}
			// rigidbody.AddForce( new Vector3(0f, 10f, 0f) );
		}
		
}
