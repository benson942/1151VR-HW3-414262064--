using UnityEngine;

public class WheelController : MonoBehaviour
{
    private float currentSpeed = 0f;         
    public float maxSpeed = 500f;        
    public float acceleration = 200f;      
    public float friction = 150f;             
    private bool isSpinning = false;          

    // private AudioSource audioSource;

    void Start()
    {
        // audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isSpinning)
        {
            isSpinning = true;
            
            // if (audioSource != null) audioSource.Play();
        }

        if (isSpinning)
        {
            if (currentSpeed < maxSpeed)
            {
                currentSpeed += acceleration * Time.deltaTime;
            }
            
            transform.Rotate(0, 0, -currentSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.DownArrow))
            {
                currentSpeed -= friction * Time.deltaTime;
            }

            if (currentSpeed <= 0)
            {
                currentSpeed = 0;
                isSpinning = false;
                
                // if (audioSource != null) audioSource.Stop();
            }
        }
    }
}