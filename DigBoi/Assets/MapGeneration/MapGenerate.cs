using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerate : MonoBehaviour {

	public GameObject Wall;
	public GameObject Gems;
	public GameObject Rope;
	public GameObject Post;
	enum inst {VOID, WALL, GEMS, ROPE, POST};

	//public GameObject player;

	public int[,] map;
	private int mapRow = -50;
	private int mapCol = -300;
	private int mapCull; 		//How many times to repeat iterative work


	// Use this for initialization
	void Start () {
		iniResources ();
		iniMap ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void iniResources(){				// ARRAY work
		//itialize 2d Array
		map = new int[mapRow,mapCol];

		//variable used to corrode the map, make caverns. iteration is based on map size
		mapCull = (mapRow * mapCol) / 2;
	}

	void iniMap(){ 						// Populate map?
		for (int i = 0; i > mapRow; i--) {
			for (int j = 0; j > mapCol; j--) {
				map [mapRow, mapCol] = (int)inst.WALL;
			}
		}


	}
}
