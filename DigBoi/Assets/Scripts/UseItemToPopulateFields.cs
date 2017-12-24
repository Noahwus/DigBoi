using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class UseItemToPopulateFields : MonoBehaviour {

	public int itemNumber;
	public Text title;
	public Text title2;
	public Text flavorText;
	public Text cost;
	public Image icon;
	public Image fullIcon;
	public Text buttonText;
	private Inventory inventory;

	void Start(){
		inventory = FindObjectOfType<Inventory> ();
		print (inventory.inventory.Length);
		PopulateInfo();
	}


	public void PopulateInfo()
	{
		print (itemNumber);
		title.text = inventory.inventory [itemNumber].title;
		title2.text = inventory.inventory [itemNumber].title;
		flavorText.text = inventory.inventory [itemNumber].flavorText;
		icon.sprite = inventory.inventory [itemNumber].icon;
		fullIcon.sprite = inventory.inventory [itemNumber].fullIcon;

		if(true == inventory.inventory [itemNumber].wearable){
			if (true == inventory.inventory [itemNumber].isWearing) {
				buttonText.text = "TAKE OFF";
			}

			else if (false == inventory.inventory [itemNumber].isWearing) {
				buttonText.text = "PUT ON";
			}
		}

	}
}
