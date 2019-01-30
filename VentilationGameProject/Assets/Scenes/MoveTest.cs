using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour {

    CharacterController ccon;

	// Use this for initialization
	void Start () {
        ccon = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 moveVec = new Vector3(0,0,0);

        if (Input.GetKey(KeyCode.DownArrow)) moveVec += new Vector3(0, 0, -1);
        if (Input.GetKey(KeyCode.UpArrow)) moveVec += new Vector3(0, 0, 1);
        if (Input.GetKey(KeyCode.RightArrow)) moveVec += new Vector3(1, 0, 0);
        if (Input.GetKey(KeyCode.LeftArrow)) moveVec += new Vector3(-1, 0, 0);


        ccon.Move(moveVec);
	}
}
