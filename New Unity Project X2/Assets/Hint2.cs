﻿using UnityEngine;
using System.Collections;
using System.Reflection;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Hint2 : MonoBehaviour{
	public int HintID = 0;
	public GameObject Text;
	private GameObject hinttext;
	
	public void OnClick(){
		
/*		GameObject Hint1Text = Instantiate (Text) as GameObject;
		var canvas = FindInParents<Canvas>(gameObject);*/
		hinttext = GameObject.Find("HT");

/*		hinttext.transform.SetParent (canvas.transform, false);
		Hint1Text.transform.SetAsLastSibling();			
		Hint1Text.GetComponent<RectTransform> ().position = hinttext.GetComponent<RectTransform> ().position;
		hinttext.SetActiveRecursively(false);*/
		
		
		
		if(HintID == 1){
			hinttext.GetComponent<Text>().text = "きりんがすきなひとは、ひだり";
						
		}else if(HintID == 2){
			hinttext.GetComponent<Text>().text = "まさきのみぎは、やすまさ";

		}else if(HintID == 3){
			hinttext.GetComponent<Text>().text = "たけしのとなりは、ねこがすき";

		}else if(HintID == 4){
			hinttext.GetComponent<Text>().text = "いぬがすきなひとは、きいろがすき";

		}else if(HintID == 5){
			hinttext.GetComponent<Text>().text = "あかいろがすきなのは、まさき";



		}
	}
	
	
	
	static public T FindInParents<T>(GameObject go) where T : Component
		//GameObjectの親であり、型がTであるものを探しにいく
	{
		if (go == null) return null;
		var comp = go.GetComponent<T>();
		
		if (comp != null)
			return comp;
		
		Transform t = go.transform.parent;
		while (t != null && comp == null)
		{
			comp = t.gameObject.GetComponent<T>();
			t = t.parent;
		}
		return comp;
	}
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
