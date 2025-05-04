using UnityEngine;

public class IntroCamera : MonoBehaviour
{
    public Transform targetTransform; // Assign the target position & rotation in the Inspector
    public float positionSpeed = 2.0f; // Speed for moving the camera
    public float rotationSpeed = 2.0f; // Speed for rotating the camera
    private bool shouldMove = false; // Flag to start moving
    public GameObject startUI;
    public GameObject gameUI;
    void Update()
    {
        if (shouldMove && targetTransform != null)
        {
            // Smoothly interpolate position
            transform.position = Vector3.Lerp(transform.position, targetTransform.position, Time.deltaTime * positionSpeed);

            // Smoothly interpolate rotation
            transform.rotation = Quaternion.Slerp(transform.rotation, targetTransform.rotation, Time.deltaTime * rotationSpeed);

            // Stop moving if close enough
            if (Vector3.Distance(transform.position, targetTransform.position) < 0.01f &&
                Quaternion.Angle(transform.rotation, targetTransform.rotation) < 0.5f)
            {
                gameUI.SetActive(true);
                shouldMove = false;
            }
        }
    }

    // Call this function to start gliding the camera
    public void StartGlide()
    {
        shouldMove = true;
        startUI.SetActive(false);
    }
}
