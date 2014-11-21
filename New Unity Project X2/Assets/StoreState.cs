using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StoreState : MonoBehaviour {

	public int[,] posMatrix =new int[3,3];
	public GameObject[,] dragIcons = new GameObject[3,3];
	public int[,] myposX = new int[3,3];
	public int[,] myposY = new int[3,3];

	public Color ncolor;
	public Image cnImage;

	// Use this for initialization
	void Start () {
		//
		ncolor = cnImage.color;
		//
	}
	
	// Update is called once per frame
	void Update () {


	}
}
