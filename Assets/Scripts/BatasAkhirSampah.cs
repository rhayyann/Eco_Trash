﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BatasAkhirSampah : MonoBehaviour {

	// Use this for initialization
  
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
      
        SceneManager.LoadScene("GameOver"); // Baris Ini Akan digunakan pada submodul GameOvers
    }
}
