using UnityEngine;
using System.Collections;

public class personagem : MonoBehaviour {

    // Use this for initialization
    float velocidade;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        velocidade = Time.deltaTime*40;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(new Vector3(0, 0, velocidade));
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, 0, -velocidade));
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
            transform.Rotate(Vector3.up * -45);
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y - 45, transform.rotation.z));
            transform.Rotate(Vector3.up * 45);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "objeto") {
            print(collision.transform.name);
        }    
    }

    }
