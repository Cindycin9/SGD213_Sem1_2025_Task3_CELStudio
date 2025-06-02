using UnityEngine;

public class DoubleJumpPowerup : MonoBehaviour, IPowerup
{
    [SerializeField]
    private float duration = 5f;
    public void Activate(GameObject player)
    {
        var movement = player.GetComponent<PlayerMovement>();
        if (movement != null)
        {
            movement.EnableDoubleJump(duration);
        }
    }
}
