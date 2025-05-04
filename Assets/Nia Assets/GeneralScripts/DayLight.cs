using UnityEngine;

public class DayLight : MonoBehaviour
{
    public Light directionalLight;  // Reference to the Directional Light (Sun)
    public float dayDuration = 60f; // Duration for a full day (in seconds)
    public float intensityDay = 1f; // Maximum intensity during the day
    public float intensityNight = 0.2f; // Minimum intensity at night

    private float timeOfDay = 0f;  // Keeps track of the current time of day (0 - 1)

    void Update()
    {
        // Update the time of day
        timeOfDay += Time.deltaTime / dayDuration;

        // Loop timeOfDay between 0 and 1
        if (timeOfDay >= 1f)
            timeOfDay = 0f;

        // Rotate the light (sun) to simulate the movement
        float angle = timeOfDay * 360f; // Full rotation (360 degrees) for a day cycle
        directionalLight.transform.rotation = Quaternion.Euler(angle+45, 170, 0);  // Adjust for proper sunrise/sunset angle

        // Adjust light intensity for day/night
        directionalLight.intensity = Mathf.Lerp(intensityNight, intensityDay, Mathf.Cos(timeOfDay * 2 * Mathf.PI) * 0.5f + 0.5f); // Smooth intensity change
    }
}
