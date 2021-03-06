using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class DropMe : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
		public Image containerImage;
		public Image receivingImage;
		private Color normalColor;
		public Color highlightColor = Color.yellow;
		public GameObject dragObject;//DropされるべきGameObject
		public GameObject thisObject;
		
		DragMe dragme;
		StoreState storestate;

		private GameObject wakuwaku;

		public int posX = 0;
		public int posY = 0;



		public void OnEnable ()
		{
			if (containerImage != null)
				normalColor = containerImage.color;
		}
		
		public void OnDrop(PointerEventData data)
		{
		//Debug.Log(data.pointerDrag.tag);

			if(data.pointerDrag.tag == thisObject.tag){
				containerImage.color = normalColor;
				
				if (receivingImage == null)
					return;


			GameObject dragIcon = Instantiate (data.pointerDrag) as GameObject;
			var canvas = FindInParents<Canvas>(gameObject);
			dragIcon.transform.SetParent (canvas.transform, false);
			dragIcon.transform.SetAsLastSibling();
			dragIcon.GetComponent<RectTransform> ().position = GetComponent<RectTransform> ().position;

			dragme = dragIcon.GetComponent<DragMe>(); 
			dragme.flag = 1;

			wakuwaku = GameObject.Find("wakuwakusan");
			storestate = wakuwaku.GetComponent<StoreState>();


			/*storestate.posMatrix[posX, posY] = dragme.ID;*/
			storestate.posMatrix[posY, posX] = dragme.ID;
			storestate.dragIcons[posY,posX] = dragIcon;

			/*Debug.Log("posX  = "+posX);
			Debug.Log("posY = "+posY);
			Debug.Log("ID = "+dragme.ID);
			Debug.Log("posMatrixs(ID) = "+storestate.posMatrix[posX,posY]);
			Debug.Log(dragIcon);*/

			}
		}

		public void OnPointerEnter(PointerEventData data)
		{
					/*Debug.Log ("OnPointerEnter");*/
			if (containerImage == null)
				return;
			

		Sprite dropSprite = GetDropSprite (data);
		//変更点：if(~&&~)→下記２重文へ
		   if(dropSprite != null)
			if (data.pointerDrag.tag == thisObject.tag) 
				containerImage.color = highlightColor;
		}

		public void OnPointerExit(PointerEventData data)
		{
			if (containerImage == null)
				return;

			containerImage.color = normalColor;
		}
		
	private Sprite GetDropSprite(PointerEventData data)
	{
			
			var originalObj = data.pointerDrag;
			if (originalObj == null)
				return null;
			
			var srcImage = originalObj.GetComponent<Image>();
			if (srcImage == null)
				return null;
			
			return srcImage.sprite;
	

		
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
}
