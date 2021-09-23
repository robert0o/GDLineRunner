using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitWave : MonoBehaviour
{
    [Header("Stamina decrese Value")]
    [Range(10, 100)]
    public int staminaHit = 10;

    [Header("Fill these in!")]
    public StaminaBar stamina;

    public void Start()
    {
        stamina.ResetStamina();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit a wave");
        stamina.DecreaseStamina(staminaHit);
    }
}
