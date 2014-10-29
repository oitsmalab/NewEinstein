using UnityEngine;
using System.Collections;



public class AnswerCheck : MonoBehaviour {
	public int [,] Answer = new int[3,3]{
		{1,7,4},
		{2,8,5},
		{3,9,6}
	};
	StoreState storestate;
	private GameObject wakuwaku;


	// Use this for initialization
	public void OnClick () {
		wakuwaku = GameObject.Find("wakuwakusan");
		storestate = wakuwaku.GetComponent<StoreState>();

		Debug.Log ("Clicked");

		int correct = 0;
		for (int i=0; i<3; i++) {
			for(int j=0; j<3; j++){
			//	Debug.Log("Answer = "+Answer[i,j]);
				Debug.Log (Answer[i,j]+" vs " + storestate.posMatrix[i,j]);
				if(Answer[i,j] == storestate.posMatrix[i,j]){
					correct++;
				}
			}
		}
		if (correct == 9) {
						Debug.Log ("!!!!");
				}
		Debug.Log (correct);

	}
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
