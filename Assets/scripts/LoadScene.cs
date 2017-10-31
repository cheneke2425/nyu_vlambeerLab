using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	public GameObject pathMakerSpherePrefab;

	// Use this for initialization
	void Start () {

		Pathmaker.globalTileCounter = 0;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.R))
		{
			SceneManager.LoadScene("mainLabScene");
		}

	}
}
