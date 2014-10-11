using UnityEngine;
using System;
using System.Collections;
using SocketIOClient;
using EventItem = System.Collections.Generic.KeyValuePair<string, SimpleJSON.JSONNode>;
[RequireComponent(typeof(Animator))]

public class SocketIoTest : MonoBehaviour
{
	protected Animator animator;


    void Start () {

    }

	void OnWebsocketMessage(EventItem msg)
	{
		
		switch (msg.Key) {
			//case "browser/move":
				//transform.position = new Vector3(msg.Value["x"].AsFloat, msg.Value["y"].AsFloat) * 10.0f;
				//break;
			case "browser/move":
				//if(msg.Value["x"] == "left"){
					//animator.SetBool("PlantNTurnLeft", true);
					//transform.Rotate(0, -10, 0);
				//} else if(msg.Value["x"] == "right"){
					//animator.SetBool("PlantNTurnRight", true);
					//transform.Rotate(0, 10, 0);
				//}
				switch (msg.Value["x"]){
					case "1":
						//animator.SetBool(doWalkId, true);
						//transform.Rotate(0, -10, 0);
					break;
					case "2":
						//animator.SetBool(left, false);
						//transform.Rotate(0, 10, 0);
					break;
					default:
						//animator.SetBool(doWalkId, false);
					break;
				}
				
			break;
		}
	}
}
