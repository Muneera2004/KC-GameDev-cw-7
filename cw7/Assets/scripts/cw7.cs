using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cw7 : MonoBehaviour
{
    public AudioSource hitSfx;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //If the player pressed A 
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x != -3f)
        {
            transform.position = new Vector3(transform.position.x-3f, transform.position.y, transform.position.z);
        }
        //If the player pressed D
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x != 3f)
        {
            //print("Player has preesed D");
            transform.position = new Vector3(transform.position.x + 3f, transform.position.y, transform.position.z);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        string name = collision.gameObject.name;
        if (name == "fence")
        {
            hitSfx.Play();
            SceneManager.LoadScene(0);
        }
    }
}