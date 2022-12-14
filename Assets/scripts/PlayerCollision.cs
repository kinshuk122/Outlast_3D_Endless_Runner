using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private const string Obstacle = "Obstacle";

        void OnCollisionEnter(Collision collisionInfo)
        {
            if (collisionInfo.collider.CompareTag(Obstacle))
            {
                playerMovement.enabled = false;
                SfxManager.Instance.Audio.PlayOneShot(SfxManager.Instance.Click);
                GameManager.Instance.EndGame();
                GameManager.Instance.DisableRotation();
            }
        }
}
