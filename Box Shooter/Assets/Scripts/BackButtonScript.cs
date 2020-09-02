using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButtonScript : MonoBehaviour
{
	public GameObject canvasObject;
    
	public void MakedeActive(){
		canvasObject.SetActive(false);
	}

}

