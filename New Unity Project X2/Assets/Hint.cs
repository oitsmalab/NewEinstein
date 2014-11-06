using UnityEngine;
using System.Collections;
using System.Reflection;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Hint : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {
	public int HintID = 0;
	public GameObject Text;
	
	public void OnClick(){
		if(HintID == 1){
			Debug.Log("XXX");

			GameObject Hint1Text = Instantiate (Text, new Vector3(1, -251, 0), transform.rotation) as GameObject;

			var canvas = FindInParents<Canvas>(gameObject);
			Hint1Text.transform.SetParent (canvas.transform, false);
			Hint1Text.transform.SetAsLastSibling();
			Hint1Text.GetComponent<RectTransform> ().position = GetComponent<RectTransform> ().position;

			/*
			Instantiate (Hint1Text, new Vector3(1, -251, 0), transform.rotation) ;
			var canvas = FindInParents<Canvas>(gameObject);
			Hint1Text.transform.SetParent (canvas.transform, false);*/

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
