using UnityEngine;
using BUMGames;


public class PlayerCollisionController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(Tag.HUMAN))
        {
            Debug.Log("On hit Human");
        }
    }
}
