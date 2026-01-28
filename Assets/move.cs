using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float mouseSensitivity = 2f;
    [SerializeField] private float jumpForce = 5f;
    private float horizontalRotation = 0f;
    
    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        Cursor.lockState = UnityEngine.CursorLockMode.Locked;
        Cursor.visible = false;
        
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Handle horizontal rotation
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        horizontalRotation += mouseX;
        transform.rotation = Quaternion.Euler(0f, horizontalRotation, 0f);

        // Handle movement
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        
        Vector3 movement = transform.right * horizontalInput + transform.forward * verticalInput;
        movement = movement.normalized;
        
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);

        // Handle jumping
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        // Cursor toggle
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            bool isLocked = Cursor.lockState == UnityEngine.CursorLockMode.Locked;
            Cursor.lockState = isLocked ? UnityEngine.CursorLockMode.None : UnityEngine.CursorLockMode.Locked;
            Cursor.visible = isLocked;
        }
    }

    void OnCollisionStay(Collision collision)
    {
        // Check if any of the contact points are roughly below us
        foreach (ContactPoint contact in collision.contacts)
        {
            if (contact.normal.y > 0.7f)
            {
                isGrounded = true;
                return;
            }
        }
    }

    void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}