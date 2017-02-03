﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject paredGO;
	public Pared paredScript;

	// Use this for initialization
	void Start () {
		paredGO = GameObject.Find ("Pared");
		paredScript = paredGO.GetComponent <Pared>();
	}
	
	// Update is called once per frame
	void Update () {
		if (paredScript.paredActiva == false) {
			paredGO.SetActive (false); //Le decimos que se desactive el Game Object "Pared"
		} else {
			paredGO.SetActive (true); //Le decimos que se active el Game Object "Pared"
		}
	}
}
