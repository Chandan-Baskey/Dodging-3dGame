using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    float xInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");   
        transform.Translate(xInput*moveSpeed*Time.deltaTime,0,0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Store")
        {
            Debug.Log("Player hit an enemy!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}
