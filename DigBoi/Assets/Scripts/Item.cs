using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/ Item")]

public class Item : ScriptableObject {

	public int itemNumber = 0;
	public string title = "New Item";
	public Sprite icon = null;
	public Sprite fullIcon = null;
	public string flavorText = "boo I'm new";
	public float cost = 110;
	public bool isInInventory = false;
	public bool isBought = false;
	public bool isWearing = false;
	public bool wearable = false;




}