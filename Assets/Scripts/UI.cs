using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UI : MonoBehaviour {

    public void changeScene(string name)
    {
        SceneManager.LoadScene(name);
    }

	void Start () {
		
	}
	
    public void closeGame()
    {
        Application.Quit();
    }

	void Update () {
		
	}
}
