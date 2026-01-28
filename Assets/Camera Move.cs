using UnityEngine;
using UnityEngine.UI; // Required for UI components like Image

public class CameraMove : MonoBehaviour
{
    public Transform character;
    public float heightOffset = 2f;
    public float backOffset = 0.5f;
    public float mouseSensitivity = 2f;
    
    private float verticalRotation = 0f;
    public float maxLookAngle = 80f;

    // Laser parameters
    public float laserRange = 100f; // Maximum range of the laser (100 meters)
    public Color laserColor = Color.red; // Color of the laser
    public Image cursor; // Reference to the UI Image for the cursor
    private LineRenderer laserLine;
    private bool grabbed = false;

    void Start()
    {
        // Set up the LineRenderer for the laser
        laserLine = gameObject.AddComponent<LineRenderer>();
        laserLine.material = new Material(Shader.Find("Sprites/Default"));
        laserLine.startColor = laserColor;
        laserLine.endColor = laserColor;
        laserLine.startWidth = 0.1f;
        laserLine.endWidth = 0.1f;
        laserLine.positionCount = 2;

        // Set the cursor's initial color
        if (cursor != null)
        {
            cursor.color = Color.red;
        }
    }

    void Update()
    {
        if (character != null)
        {
            // Existing camera movement code
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
            verticalRotation -= mouseY;
            verticalRotation = Mathf.Clamp(verticalRotation, -maxLookAngle, maxLookAngle);

            Vector3 targetPosition = character.position 
                                   - character.forward * backOffset
                                   + Vector3.up * heightOffset;

            transform.position = targetPosition;
            transform.rotation = Quaternion.Euler(verticalRotation, character.eulerAngles.y, 0f);

            // Update laser
            UpdateLaser();
        }
    }

    void UpdateLaser()
    {
        // Set the start position of the laser (camera position)
        laserLine.SetPosition(0, transform.position);

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, laserRange))
        {
            // If we hit something, set the end position to the hit point
            laserLine.SetPosition(1, hit.point);

            if (hit.collider.gameObject.tag == "Movable")
            {
                GameObject movable = hit.collider.gameObject;

                if (!grabbed && Input.GetMouseButtonDown(0))
                {
                    grabbed = true;
                    Debug.Log(movable.name) ;
                    movable.GetComponent<Rigidbody>().isKinematic = true;
                    movable.transform.SetParent(transform);

                    if (cursor != null)
                    {
                        cursor.color = Color.green;
                    }
                }
                else if (grabbed && Input.GetMouseButtonDown(0))
                {
                    grabbed = false;
                    movable.GetComponent<Rigidbody>().isKinematic = false;
                    movable.transform.parent = null;

                    if (cursor != null)
                    {
                        cursor.color = Color.red;
                    }
                }
            }
            else if(hit.collider.gameObject.tag == "BoxHand"){
                GameObject hand = hit.collider.gameObject;
                if (Input.GetMouseButtonDown(0))
                {
                    Destroy(hand);
                }
            }
        }
        else
        {
            // If we didn't hit anything, extend the laser to maximum range
            laserLine.SetPosition(1, transform.position + transform.forward * laserRange);
        }
    }
}
