using UnityEngine;
using System.Collections;

public class LookAtPlayer : MonoBehaviour
{
    // Start is called before the first frame update
	public Transform player;
	
    void Start()
    {
        player = GameObject.FindWithTag ("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
    }
}
