using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class MouseOverInventoryItems : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public GameObject itemPopup;

	public void OnPointerEnter(PointerEventData eventData){
		itemPopup.SetActive(true);
		UseItemToPopulateFields popField = gameObject.GetComponent<UseItemToPopulateFields> ();
		popField.PopulateInfo ();
	}


	public void OnPointerExit(PointerEventData eventData){
		itemPopup.SetActive(false);

	}


}
