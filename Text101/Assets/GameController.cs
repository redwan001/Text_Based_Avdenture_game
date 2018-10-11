using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameController : MonoBehaviour {
private InputField input;

void Awake() {

input = GameObject.Find ("InputField").GetComponent<InputField> ();
}
	// Use this for initialization
public void GetInput(string guess) {
Debug.Log ("You Entered " +guess);
input.text = "";
}
}
