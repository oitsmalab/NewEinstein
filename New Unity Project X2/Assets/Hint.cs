using UnityEngine;
using System.Collections;

public class Hint : MonoBehaviour {
	public int HintID = 0;
	
	public void OnClick(){
		if(HintID == 1){
			Debug.Log("XXX");
		//	GUI.Label (new Rect (-268, -100, 400, 100), "ABCABC!!");
		}else if(HintID == 2){
			Debug.Log("ZZZ");
		}
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
