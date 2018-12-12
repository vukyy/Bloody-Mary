using UnityEngine;

public class PlayerTargetFinder : MonoBehaviour
{
    [Tooltip("Maximum distance from which the player can interact with objects")]
    [Range(0f, 20f)]
    [SerializeField] private float m_maxDistance;

    private GameObject m_target;                      // Private field to store what the raycast returns

    public PlayerTargetManager playerTargetManager;   // Reference to the PlayerTargetManager game object

    void Update()
    {
        PlayerCast();
        SetPlayerTarget();
    }

    // Method to determine what the player is looking at and set target appropriately
    void PlayerCast()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, m_maxDistance))
        {
            Debug.Log("Looking at " + hit.collider.name + ". Distance is " + hit.distance);
            m_target = hit.collider.gameObject;
        }
        else
        {
            m_target = null;
        }
    }

    // Method to take what the player is looking at (target) and inject into the PlayerTargetManager's playertarget variable
    void SetPlayerTarget()
    {
        if (m_target != null)
        {
            playerTargetManager.PlayerTarget = m_target.gameObject;
        }
        else
        {
            playerTargetManager.PlayerTarget = null;
        }
    }
}
