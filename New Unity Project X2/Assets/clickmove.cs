using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class clickmove : MonoBehaviour {

	public int ID;
	public static int star1=0;
	public static int star2=0;
	public static int star3=0;
	public static int star4=0;
	public static int star5=0;
	public static int star6=0;

	private Image Lv1B;
	private Image Lv2B;
	private Image Lv3B;
	private Image Lv4B;
	private Image Lv5B;
	private Image Lv6B;

	public Color clearcolor = Color.yellow;

	public GameObject Text;
	private GameObject modetext;
	private GameObject maincamera;
	HintTextBox hinttextbox;

	public GameObject thisObject;

	public void OnClick () {

		if (ID == 1) {
			Application.LoadLevel("Lv1");//レベル1の問題
		} else if (ID == 2) {
			Application.LoadLevel("Lv2");
		} else if (ID == 3) {
			Application.LoadLevel("Lv3");
		} else if (ID == 4) {
			Application.LoadLevel("Lv4");//レベル4の問題
		} else if (ID == 5) {
			Application.LoadLevel("Lv5");
		} else if (ID == 6) {
			Application.LoadLevel("Lv6");
		} else if (ID == 0) {
			Application.LoadLevel("title");//タイトルに戻る
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
			if (star3 == 1) {
				Lv3B = GameObject.Find ("Lv3Button").GetComponent<Image>();
				Lv3B.color = clearcolor;
			}
			if (star4 == 1) {
				Lv4B = GameObject.Find ("Lv4Button").GetComponent<Image>();
				Lv4B.color = clearcolor;
			}
			if (star5 == 1) {
				Lv5B = GameObject.Find ("Lv5Button").GetComponent<Image>();
				Lv5B.color = clearcolor;
			}
			if (star6 == 1) {
				Lv6B = GameObject.Find ("Lv6Button").GetComponent<Image>();
				Lv6B.color = clearcolor;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
