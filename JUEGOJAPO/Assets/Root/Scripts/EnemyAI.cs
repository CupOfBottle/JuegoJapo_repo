using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{
    public class EnemyDetector2D : MonoBehaviour
    {
        [SerializeField] private Animator parentAI;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                // Cuando el jugador entra al área de detección, llama a la función de ataque
                parentAI.SetTrigger ("Attack");
            }
        }

    }
}
