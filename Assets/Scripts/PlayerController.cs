using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	private int count;
	public GUIText countText;
	public GUIText winText;
	private GameController gamecontr;
	
	void Start()
	{
		
		count=0;
		if(speed == 0f)
		{
		speed = 1;	
		}
		SetCountText();
		winText.text = "";
		
	}
	
	void SetCountText()
	{
		countText.text = "Count:" + count.ToString();
	}
	
	void FixedUpdate () 
	{
		
	float moveHorizontal=Input.GetAxis("Horizontal");
	float moveVertical = Input.GetAxis("Vertical");
	
	Vector3 movement = new Vector3(moveHorizontal,0.0f, moveVertical);
	
	rigidbody.AddForce(movement * speed * Time.deltaTime);
	}
	void OnTriggerEnter(Collider other)
	{
	if(other.gameObject.tag == "PickUP")	
	{
		other.gameObject.SetActive(false);
		count++;
		SetCountText();
		if(count >=15)
		{
				GameObject gamecontrollerObject = GameObject.FindWithTag("GameController");
				if (gamecontrollerObject != null) {
					//Debug.Log ("not null");
					gamecontr = gamecontrollerObject.GetComponent<GameController>();
					gamecontr.GameWon();
				}
			//winText.text = "You Win";
		}
	}
	}
	
}
//Destroy(other.gameObject);