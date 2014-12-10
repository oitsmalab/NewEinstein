using UnityEngine;
using System.Collections;

public class clickmove : MonoBehaviour {

	public int ID;
	public static int star1=0;
	public static int star2=0;

	public void OnClick () {

		if (ID == 1) {
			Application.LoadLevel ("ain_12_03");
		} else if (ID == 2) {
			Application.LoadLevel("ain_11_26");
		} else if (ID == 0) {
			Application.LoadLevel("title");
		}
		}

	// Use this for initialization
	void Start () {

		if (star1 == 1) {
						Debug.Log ("star1");
				}
		if (star2 == 1) {
						Debug.Log ("star2");
				}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
