﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public Text gameOverText;
    private bool gameOver;


    void Start(){
        gameOver = false;
        
    }

    // Update is called once per frame
    void Update(){
    if (gameOver) {
     if (Input.GetKeyDown(KeyCode.Alpha1)) {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	 }
     if (Input.GetKeyDown(KeyCode.Alpha2)) {
      PlayerPrefs.SetInt(ScorePrefs.SCORE, 0);
      PlayerPrefs.SetInt(ScorePrefs.PREVIOUS_SCORE, 0);
      SceneManager.LoadScene("Menu");
	 }
	}
        
    }

    public void GameOver() {
        gameOverText.text = "GAME OVER - press 1 to reset";
        gameOver = true;
        PlayerPrefs.SetInt(ScorePrefs.SCORE, PlayerPrefs.GetInt(ScorePrefs.PREVIOUS_SCORE));
	}
}

