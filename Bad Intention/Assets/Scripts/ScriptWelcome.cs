using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptWelcome : MonoBehaviour
{
	public void ButtonMoveScene(string level)
    {
    	SceneManager.LoadScene(level);
    }

    void Update()
    {
    	if (Input.GetKeyDown (KeyCode.Escape))
    		Application.Quit();
    }
}
