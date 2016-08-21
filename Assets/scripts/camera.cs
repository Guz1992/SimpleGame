using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

    public GameObject personagem;
    public Transform referenciapos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () { 
        transform.position = Vector3.Slerp(transform.position, referenciapos.position, Time.deltaTime * 10);
        transform.LookAt(personagem.transform);
    }
}
