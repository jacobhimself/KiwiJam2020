﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour {

	private bool isInstructions = false;

	public RectTransform instructionsPanel, mainMenuPanel;


	// Use this for initialization
	void Start () {
		if (Time.timeScale == 0) {
			Time.timeScale = 1;
		}

	}
	
	// Update is called once per frame
	void Update() {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (isInstructions) {
				Instructions ();

			} else {
				Application.Quit();
			}
		}


	}




	public void StartGame() {
		SceneManager.LoadScene ("SampleScene");
	}

	public void Instructions() {
		//if instruction panel is open
		if (isInstructions) {
			instructionsPanel.gameObject.SetActive(false);
			mainMenuPanel.gameObject.SetActive(true);
			isInstructions = false;
		} else { //main menu is open
			instructionsPanel.gameObject.SetActive(true);
			mainMenuPanel.gameObject.SetActive(false);
			isInstructions = true;
	 	}
	}

	public void RageQuit()
	{
		SceneManager.LoadScene("MainMenu");
	}

	public void PlayAgain()
	{
		SceneManager.LoadScene("SampleScene");
	}

	public void NextLevel()
	{
		SceneManager.LoadScene("Level2");
	}
}
