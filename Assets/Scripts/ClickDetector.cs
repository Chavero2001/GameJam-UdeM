using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    void Update()
    {
        // Check for left mouse button click
        if (Input.GetMouseButtonDown(0))
        {
            // Create a ray from the camera through the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Cast the ray and check if it hits something
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Clicked on object: " + hit.collider.name);
                StaticVariableManager.clickedObject = hit.collider.name;
                // Optional: If you want to do something with the object
                // You can access it like this:
                GameObject clickedObject = hit.collider.gameObject;
            }
        }
    }
}
