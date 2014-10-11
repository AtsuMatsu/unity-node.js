using UnityEngine;
using System.Collections;
using SocketIOClient;
using EventItem = System.Collections.Generic.KeyValuePair<string, SimpleJSON.JSONNode>;

[RequireComponent(typeof(Animator))]
public class UnityChan2Controller : MonoBehaviour {

	private Animator animator;
	private int doWalkId;
	private int doLeftId;
	private int doRightId;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		doWalkId = Animator.StringToHash ("Do Run");
		doLeftId = Animator.StringToHash ("Do Left");
		doRightId = Animator.StringToHash ("Do Right");
	}

	// Update is called once per frame
	void OnWebsocketMessage(EventItem msg) {

		switch (msg.Key) {
			case "browser/move":
			switch (msg.Value["x2"]){
				case "run2":
				animator.SetBool(doWalkId, true);
				transform.Translate(Vector3.forward * 0.1f);
				break;
				case "stop2":
				animator.SetBool(doWalkId, false);
				break;
				case "left2":
				animator.SetBool(doLeftId, true);
				transform.Rotate(new Vector3(0, -2, 0));
				break;
				case "right2":
				animator.SetBool(doRightId, true);
				transform.Rotate(new Vector3(0, 2, 0));
				break;
				case "left2stop":
				animator.SetBool(doLeftId, false);
				break;
				case "right2stop":
				animator.SetBool(doRightId, false);
				break;
			}

			switch (msg.Value["player"]){
				case "2p":
					Debug.Log("ok");
				break;
			}
			break;
		}
	}
}
