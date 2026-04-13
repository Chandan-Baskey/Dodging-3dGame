using UnityEngine;

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
}
