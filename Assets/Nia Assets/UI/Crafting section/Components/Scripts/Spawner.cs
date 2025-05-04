using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectPrefab; // Assign the prefab of the object to clone

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && objectPrefab != null)
        {
            // Cast a ray from the mouse position into the 3D world
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits this GameObject's collider
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                Instantiate(objectPrefab, transform.position, transform.rotation);
            }
        }
    }
}
