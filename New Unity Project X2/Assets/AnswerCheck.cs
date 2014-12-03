using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AnswerCheck : MonoBehaviour {
	public int [,] Answer = new int[3,3]{
		{3,2,1},
		{8,7,9},
		{6,4,5}
	};
	StoreState storestate;
	private GameObject wakuwaku;
	DropMe dropme;
	DragMe dragme;
	public Color falseColor = Color.red;
	private Image DragIcons;
	
	int hp = 3;
	int misscount = 0;
	private GameObject HP1;
	private GameObject HP2;
	private GameObject HP3;
	private GameObject BT;


	// Use this for initialization
	public void OnClick () {
		wakuwaku = GameObject.Find("wakuwakusan");
		storestate = wakuwaku.GetComponent<StoreState>();

		Debug.Log ("-----------------------------------------");

		int correct = 0;
		int miss = 0;

		for (int i=0; i<3; i++) {
			for(int j=0; j<3; j++){
			//	Debug.Log("Answer = "+Answer[i,j]);
				Debug.Log (Answer[i,j]+" vs " + storestate.posMatrix[i,j]);



				if(Answer[i,j] == storestate.posMatrix[i,j]){

					//DragIcons = storestate.dragIcons[i,j].GetComponent<Image>();
					//DragIcons.color = dragme.originColor;

					correct++;


					//間違っている場合色を変える
				}else{
					//Debug.Log ("AAA" + storestate.dragIcons[i,j]);

						if(storestate.posMatrix[i,j] != 0){
						DragIcons = storestate.dragIcons[i,j].GetComponent<Image>();
						DragIcons.color = falseColor;
						miss=1;
					}
				}
			}
		}

		if (miss == 1) {
						hp = hp - 1;
			misscount++;
				}

		if (hp < 0) {
						Debug.Log ("失敗");
			BT = GameObject.Find ("Button");
			GameObject.Destroy (BT);	
				}

		if (correct == 9) {
						Debug.Log ("!!!!");
				}
		Debug.Log (correct);
		Debug.Log (hp);


		if (misscount == 1) {
			HP1 = GameObject.Find ("hp1");
			GameObject.Destroy (HP1);	
		} else if (misscount == 2) {
			HP2 = GameObject.Find ("hp2");
						Destroy (HP2);	
		} else if (misscount == 3) {
			HP3 = GameObject.Find ("hp3");
						Destroy (HP3);

				}

	}


	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
