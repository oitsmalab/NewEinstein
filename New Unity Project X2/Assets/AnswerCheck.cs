using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class AnswerCheck : MonoBehaviour {
	public int [,] Answer = new int[3,3]{
		{1,2,3},
		{7,8,9},
		{4,5,6}
	};
	StoreState storestate;
	private GameObject wakuwaku;
	DropMe dropme;
	public Color falseColor = Color.red;
	private Image DragIcons;

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

					//間違っている場合色を変える
				}else{
					Debug.Log ("AAA" + storestate.dragIcons[i,j]);

					if(storestate.posMatrix[i,j] != 0){
						DragIcons = storestate.dragIcons[i,j].GetComponent<Image>();
						DragIcons.color = falseColor;
					}
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
