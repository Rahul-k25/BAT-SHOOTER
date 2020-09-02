using System.Collections;
using UnityEngine;

public class BasicMover : MonoBehaviour
{
    public float spinSpeed = 180.0f;
    public float magnitudeMotion = 0.1f;
	
	public enum motionState {Spin, Horizontal, Vertical};
	public motionState motion = motionState.Vertical;
	
    // Update is called once per frame
    void Update()
    {
		switch(motion){
			case motionState.Spin:
				gameObject.transform.Rotate(Vector3.up*spinSpeed*Time.deltaTime);
				break;
			case motionState.Horizontal:
				gameObject.transform.Translate(Vector3.right*Mathf.Cos(Time.timeSinceLevelLoad)*magnitudeMotion);
				break;
			case motionState.Vertical:
				gameObject.transform.Translate(Vector3.up*Mathf.Cos(Time.timeSinceLevelLoad)*magnitudeMotion);
				break;
		}
	}
}
