using UnityEngine;
using System.Collections;

public class SetRenderQueue : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<MeshRenderer>().material.renderQueue = 10000000;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
