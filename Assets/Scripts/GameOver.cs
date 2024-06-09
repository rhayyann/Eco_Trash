using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    float timer = 0;
    // Use this for initialization
    //public AudioClip GameOverMusic;
    //private  AudioSource MediaGameOverMusic;
    void Start () {
        //MediaGameOverMusic = gameObject.AddComponent<AudioSource>();
        //MediaGameOverMusic.clip = GameOverMusic;
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            Data.score = 0;
            SceneManager.LoadScene("MENU");
            //MediaGameOverMusic.Play();
        }
	}
}
