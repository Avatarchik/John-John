﻿using UnityEngine;
using System.Collections;

public class QuitLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		Application.LoadLevel(0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}