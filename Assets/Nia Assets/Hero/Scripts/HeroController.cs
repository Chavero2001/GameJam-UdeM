using UnityEngine;

public class HeroController : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Transform[] waypoints; // Array de puntos de movimiento
    private int currentWaypointIndex = 0;
    private bool isMoving = false;
    //public float rotationSpeed = 5f; // Velocidad de rotación
    public GameObject dialogueBox; // Referencia al diálogo
    public Transform shopPoint; // Punto de la tienda
    public HeroDialogueUI dialogueUI; // Referencia al script de diálogo

    private bool isAtShop = false;

    private void Start()
    {
        transform.position = waypoints[0].position; // Iniciar en el primer punto
        dialogueBox.SetActive(false); // Asegurar que el diálogo esté desactivado al inicio

    }

    private void Update()
    {
        if (isMoving)
        {
            MoveAlongPath();
        }
    }

    private void MoveAlongPath()
    {
        if (currentWaypointIndex >= waypoints.Length) return;

        Transform targetWaypoint = waypoints[currentWaypointIndex];
        transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, moveSpeed * Time.deltaTime);

        // Suavizar la rotación hacia el siguiente punto
        Vector3 direction = (targetWaypoint.position - transform.position).normalized;
        if (direction != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 5f);
        }

        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
        {
            if (targetWaypoint == shopPoint && !isAtShop)
            {
                isMoving = false; // Detener movimiento
                isAtShop = true;
                dialogueBox.SetActive(true); // Activar diálogo
                dialogueUI.StartDialogue(this); // Iniciar el diálogo
                return;
            }
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                isMoving = false;
                return;
            }
        }
    }

    public void MoveToExit()
    {
        isMoving = true;
    }

    public void StartMoving()
    {
        isMoving = true;
    }

    public void ResetHero()
    {
        isMoving = false;
        isAtShop = false;
        currentWaypointIndex = 0;
        transform.position = waypoints[0].position; // Reiniciar posición
        transform.rotation = Quaternion.identity; // Resetear la rotación
        dialogueBox.SetActive(false); // Ocultar el diálogo
    }

    public void OnReadyButtonPressed()
    {
        ResetHero();
        StartMoving();
    }

    public void LeaveShop()
    {
        isAtShop = false;
        currentWaypointIndex++;
        isMoving = true;
    }
}
