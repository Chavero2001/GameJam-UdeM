using UnityEngine;
using UnityEngine.InputSystem;  

public class CloneScript : MonoBehaviour
{
    void Update()
    {
        // Get mouse position in world space
        Vector3 mousePosition = Mouse.current.position.ReadValue();
        mousePosition.z = Camera.main.WorldToScreenPoint(transform.position).z; // Maintain object's Z position
        Vector3 targetPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Move the object smoothly towards the mouse position
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 10);

        // Destroy on mouse release
        if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            Destroy(gameObject);
        }
    }
}
