using System.Collections;
using UnityEngine;

public class SpeedBoostPowerup : MonoBehaviour, IPowerup
{
    public float boostMultiplier = 1.5f;
    public float duration = 5f;

    public void Activate(GameObject player)
    {
        var movement = player.GetComponent<PlayerMovement>();
        if (movement != null)
        {
            movement.StartCoroutine(TemporarySpeedBoost(movement));
        }
    }

    private IEnumerator TemporarySpeedBoost(PlayerMovement movement)
    {
        movement.ModifySpeed(boostMultiplier);
        yield return new WaitForSeconds(duration);
        movement.ModifySpeed(1f);
    }
}
