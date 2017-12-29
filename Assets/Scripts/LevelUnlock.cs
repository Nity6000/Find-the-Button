using UnityEngine;
using UnityEngine.UI;

public class LevelUnlock : MonoBehaviour
{
    public Button lvl1;
    public Button lvl2;
    public Button lvl3;    

	void Start ()
    {
        int unlocks = PlayerPrefs.GetInt("unlocks");

        if (unlocks != 2 && unlocks != 3)
        {
            PlayerPrefs.SetInt("unlocks", 1);
            Debug.Log("First");
        }       

		if (PlayerPrefs.GetInt("unlocks") == 1)
        {
            lvl1.enabled = true;
        }

        if (PlayerPrefs.GetInt("unlocks") == 2)
        {
            lvl1.enabled = true;
            lvl2.enabled = true;
        }

        if (PlayerPrefs.GetInt("unlocks") == 3)
        {
            lvl1.enabled = true;
            lvl2.enabled = true;
            lvl3.enabled = true;
        }
    }
}
