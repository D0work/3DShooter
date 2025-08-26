using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class ShieldBehavior : MonoBehaviour
{
    public Health playerHealth;

    void OnDisable()
    {
        playerHealth.isAlwaysInvincible = false;
    }
}
