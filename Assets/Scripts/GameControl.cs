﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

	public static GameControl control;

	public float health;
	public float experience;


	void Awake() 
	{
		if (control == null) 
		{
			DontDestroyOnLoad (gameObject);
			control = this;
		} 
		else if (control != this) 
		{
			Destroy (gameObject);
		}
	}

	void OnGUI()
	{
		GUI.Label (new Rect(10, 10, 100, 30), "Health:" + health);
		GUI.Label (new Rect(10, 40, 150, 30), "Experience:" + experience);
	}

	public void loadScene(string sceneName) {
		SceneManager.LoadScene (sceneName);
	}
}
