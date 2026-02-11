using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 25.0f;
    private float turnSpeed = 55.0f;
    private float horizontalInput;
    private float forwardInput;
    public Camera FPCamera;
    public Camera SPCamera;
    public KeyCode switchKey;
    public KeyCode fixKey;
    public GameObject car;
    private Vector2 fixedPosition = new Vector3(0, 5,0);
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward based on verttical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the vehicle based on horizontal input
        transform.Rotate(Vector3.up *turnSpeed * horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(switchKey))
        {
            FPCamera.enabled = !FPCamera.enabled;
            SPCamera.enabled = !SPCamera.enabled;
        }
        if (Input.GetKeyDown(fixKey))
        {
            transform.position = fixedPosition;
            
        }
        
    }
}
