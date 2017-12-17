using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public Button Play_Button;
	public Button Quit_Button;

	public void Play_Game () {
		SceneManager.LoadScene(1);
	}

	public void Quit_Game() {
		
		UnityEditor.EditorApplication.isPlaying = false;
	}
}
