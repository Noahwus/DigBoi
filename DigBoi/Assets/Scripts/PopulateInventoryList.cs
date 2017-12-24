using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PopulateInventoryList : MonoBehaviour {

	private Inventory inventory;

	//declaring all inventory objects
	public GameObject townScroll;
	public GameObject pickAxe;

	void Start(){
		inventory = FindObjectOfType<Inventory> ();
		print (inventory.inventory.Length);
		PopulateInventory();

	}



	public void PopulateInventory (){
		PopulateInventoryTownScroll ();
		PopulateInventoryPickAxe ();

	}


	public void PopulateInventoryTownScroll(){
		bool isBought = inventory.inventory [0].isBought;

		if (isBought) 
		{
			townScroll.SetActive(true);
			inventory.inventory [0].isBought = true;
			Debug.Log ("TownScroll should show");
		}
		else
		{
			townScroll.SetActive(false);
			inventory.inventory [0].isBought = false;
			Debug.Log ("TownScroll should not show");
		}
	}


	public void PopulateInventoryPickAxe(){
		bool isBought = inventory.inventory [1].isBought;

		if (isBought) {
			pickAxe.SetActive(true);
			inventory.inventory [1].isInInventory = true;
			Debug.Log ("PickAxe should show");
		} else {
			pickAxe.SetActive(false);
			inventory.inventory [1].isInInventory = false;
			Debug.Log ("PickAxe should not show");

			bool isInInventory = inventory.inventory [1].isInInventory;

			if (isInInventory) {
				pickAxe.SetActive (true);
				inventory.inventory [1].isInInventory = true;
				Debug.Log ("TownScroll should show");
			} else {
				pickAxe.SetActive (false);
				inventory.inventory [1].isInInventory = false;
				Debug.Log ("PickAxe should not show");
			}
		}

	}
}