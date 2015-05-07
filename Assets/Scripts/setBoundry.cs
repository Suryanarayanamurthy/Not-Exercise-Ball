using UnityEngine;
using System.Collections;

public class setBoundry : MonoBehaviour {
	private GameController gamecontr;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("player entered the coloder ");
		if(other.gameObject.tag == "Player")	
		{
			GameObject gamecontrollerObject = GameObject.FindWithTag("GameController");
			if (gamecontrollerObject != null) {
				//Debug.Log ("not null");
				gamecontr = gamecontrollerObject.GetComponent<GameController>();
				gamecontr.GameOver();
				Debug.Log ("gameover called");
			}
		}
	}
}
