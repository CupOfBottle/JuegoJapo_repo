using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectorpadre : MonoBehaviour
{
    public class EnemyAI : MonoBehaviour
    {
        private Animator animator;

        private void Start()
        {
            animator = GetComponent<Animator>();
        }

        public void StartAttack()
        {
            // Asumiendo que en tu Animator tienes un Trigger "Attack"
            animator.SetTrigger("Attack_Kappa");
        }

        public void StopAttack()
        {
            animator.SetTrigger("Idle_Kappa");
        }
    }
}
