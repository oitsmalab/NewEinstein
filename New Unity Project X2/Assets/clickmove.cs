using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class clickmove : MonoBehaviour {

	public int ID;
	public static int star1=0;
	public static int star2=0;

	private Image Lv1B;
	private Image Lv2B;
	public Color clearcolor = Color.yellow;

	public void OnClick () {

		if (ID == 1) {
			Application.LoadLevel ("ain_11_26");
		} else if (ID == 2) {
			Application.LoadLevel("ain_12_03");
		} else if (ID == 0) {
			Application.LoadLevel("title");
		}
		}

	// Use this for initialization
	void Start () {
		if(Application.loadedLevelName == "title"){
		if (star1 == 1) {
			Lv1B = GameObject.Find ("Lv1Button").GetComponent<Image>();
			Lv1B.color = clearcolor;

		}
		if (star2 == 1) {
				Lv2B = GameObject.Find ("Lv2Button").GetComponent<Image>();
				Lv2B.color = clearcolor;
				}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
