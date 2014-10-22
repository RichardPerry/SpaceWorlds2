using UnityEngine;

public class PlayerScript : MonoBehaviour
{

	public const int speed = 10;
	private float angle = 0.0f;
	private float dangle = 0.0f;
	private float throttle = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var inputX = Input.GetAxis("Horizontal");
		var inputY = Input.GetAxis("Vertical");

		throttle = speed * inputY;
		dangle = inputX * -2;

		transform.Rotate(0,0,dangle);
		transform.FindChild("Main Camera").gameObject.camera.transform.Rotate(0,0,-dangle);
	}

	void FixedUpdate()
	{
		angle += dangle;
		var x = throttle * -Mathf.Sin(angle * Mathf.Deg2Rad);
		var y = throttle * Mathf.Cos(angle * Mathf.Deg2Rad);
		rigidbody2D.velocity = new Vector2(x,y);
	}
}
