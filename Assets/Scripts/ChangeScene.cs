﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public void loadSceneByName(string name) {
		SceneManager.LoadScene (name);
	}
}
