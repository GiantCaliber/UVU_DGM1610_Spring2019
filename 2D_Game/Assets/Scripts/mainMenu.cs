using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {
    // Indexed level to load 
    public int levelToLoad;

	// loads level stored in levelToLoad variable
	public void LoadLevel() {
        SceneManager.LoadScene(levelToLoad);
    }
    
    // This function quits game when activated
    public void LevelExit() {
        Application.Quit();
    }
}
