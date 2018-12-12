using UnityEngine;

public class PickupObject : MonoBehaviour
{
    public PlayerTargetManager playerTargetManager;  // Reference to PlayerTargetManager

    private void Update()
    {
        Pickup();
    }

    // Quick and dirty method to pick up object
    private void Pickup()
    {
        if (playerTargetManager.PlayerTarget != null && playerTargetManager.PlayerTarget.gameObject.CompareTag("Pickupable") && Input.GetMouseButtonDown(0))
        {
            // Pickup logic
            Debug.Log("You picked up " + playerTargetManager.PlayerTarget.gameObject.name);
            DestroyImmediate(playerTargetManager.PlayerTarget.gameObject);
        }
    }
}
