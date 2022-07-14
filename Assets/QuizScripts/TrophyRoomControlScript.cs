using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyRoomControlScript : MonoBehaviour {

	// References to trophies game objects to control
	public GameObject cup1, cup2, cup3, cup4, cup5, cup6, cup7, cup8, cup9, cup10;

	// Variables to contain Player Prefs values
	int cup1Got, cup2Got, cup3Got, cup4Got,  cup5Got, cup6Got, cup7Got, cup8Got, cup9Got, cup10Got;

	// Use this for initialization
	void Start () {

		// Getting Player Prefs values to make sure you got
		// particular trophy
		cup1Got = PlayerPrefs.GetInt ("Cup1Got");
		cup2Got = PlayerPrefs.GetInt ("Cup2Got");
		cup3Got = PlayerPrefs.GetInt ("Cup3Got");
        cup4Got = PlayerPrefs.GetInt ("Cup4Got");
        cup5Got = PlayerPrefs.GetInt ("Cup5Got");
        cup6Got = PlayerPrefs.GetInt ("Cup6Got");
        cup7Got = PlayerPrefs.GetInt ("Cup7Got");
        cup8Got = PlayerPrefs.GetInt ("Cup8Got");
        cup9Got = PlayerPrefs.GetInt ("Cup9Got");
        cup10Got = PlayerPrefs.GetInt("Cup10Got");

        // If you got trophy 1
        if (cup1Got == 1)
			// then it is shown on the shelf
			cup1.SetActive (true);
		// if you don't get it
		else
			// then it is not shown
			cup1.SetActive (false);

		// Same for trophy 2 and 3
		if (cup2Got == 1)
			cup2.SetActive (true);
		else
			cup2.SetActive (false);
		
		if (cup3Got == 1)
			cup3.SetActive (true);
		else
			cup3.SetActive (false);

        if (cup4Got == 1)
            cup4.SetActive(true);
        else
            cup4.SetActive(false);

        if (cup5Got == 1)
            cup5.SetActive(true);
        else
            cup5.SetActive(false);

        if (cup6Got == 1)
            cup6.SetActive(true);
        else
            cup6.SetActive(false);

        if (cup7Got == 1)
            cup7.SetActive(true);
        else
            cup7.SetActive(false);

        if (cup8Got == 1)
            cup8.SetActive(true);
        else
            cup8.SetActive(false);

        if (cup9Got == 1)
            cup9.SetActive(true);
        else
            cup9.SetActive(false);

        if (cup10Got == 1)
            cup10.SetActive(true);
        else
            cup10.SetActive(false);


    }

}
