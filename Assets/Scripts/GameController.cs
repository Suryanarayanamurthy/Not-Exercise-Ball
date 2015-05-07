using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private bool IsLost;
	private bool IsWon;
	public GUIText MessageText;

	//private CameraController CameraControllerObj;
	// Use this for initialization
	void Start () {
		IsLost = false;
		IsWon = false;
		MessageText.text = string.Empty;
	}
	
	// Update is called once per frame
	void Update () {


		if (IsLost || IsWon) {
			if (Input.GetKeyDown(KeyCode.R))
			{
				Application.LoadLevel("Scene0");
			}
		}
	
	}

	public void GameOver()
	{
		MessageText.text = "Game over :-( .... \n press R to restart :-)";
		//getCamera().SetToOrigin ();
		IsLost = true;

	}

	public void GameWon()
	{
		MessageText.text = "You Won!!! \n press R to restart :-)";
		//getCamera().SetToOrigin ();
		IsWon = true;
		// text changes when u win and then fall off.
		IsLost = false;
	}

//	private CameraController getCamera()
//	{
//		if (CameraControllerObj == null) {
//			GameObject CameraObject = GameObject.FindWithTag ("MainCamera");
//			if (CameraObject != null) {
//				//Debug.Log ("not null");
//				CameraControllerObj = CameraObject.GetComponent<CameraController> ();
//			}
//			return CameraControllerObj;
//		} else
//			return CameraControllerObj;
//	}
}
