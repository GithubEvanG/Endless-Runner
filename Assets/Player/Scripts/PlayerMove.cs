using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{

    public Transform ts;
    public float speed = 20f;
    public float sidespeed = 14f;
    static public bool canMove = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canMove==true)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x < 8)
                {
                    transform.Translate(Vector3.right * sidespeed * Time.deltaTime);
                }
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x > -8)
                {
                    transform.Translate(Vector3.left * sidespeed * Time.deltaTime);
                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            // Get the current scene name
            string currentSceneName = SceneManager.GetActiveScene().name;
            // Reload the current scene
            SceneManager.LoadScene(currentSceneName);
            PlayerMove.canMove = false;
        }
    }
}
