using UnityEngine;
using BUMGames;


public class DiamondController : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _duration;


    private void Start()
    {
        Utility.SetRotateObject(transform, _direction, _duration);
    }
}
