using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UnlockCursor : MonoBehaviour
{
	
	private Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();

		if(scene.name == "Start Scene"){
			Cursor.visible = true;
		}
    }

   
}
