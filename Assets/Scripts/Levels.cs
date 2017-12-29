using UnityEngine.SceneManagement;
using UnityEngine;

public class Levels : MonoBehaviour {
	
    public void Lvl1c(string name)
    {
        PlayerPrefs.SetInt("unlocks", 2);
        PlayerPrefs.Save();
        SceneManager.LoadScene(name);
    }

    public void Lvl2c(string name)
    {
        PlayerPrefs.SetInt("unlocks", 3);
        PlayerPrefs.Save();
        SceneManager.LoadScene(name);
    }

    public void Lvl3c(string name)
    {        
        PlayerPrefs.Save();
        SceneManager.LoadScene(name);
    }

}
