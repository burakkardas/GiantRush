using UnityEngine;
using DG.Tweening;

public class PlayerScaleController : MonoBehaviour
{
    [SerializeField] private Vector3 _currentScale;
    [SerializeField] private float _duration;


    private void Start()
    {
        _currentScale = transform.localScale;
    }



    public void SetScale(Vector3 value)
    {
        if (_currentScale.x >= 1)
        {
            _currentScale += value;

            if (_currentScale.x < 1)
            {
                _currentScale = Vector3.one;
            }
        }



        transform.DOScale(_currentScale, _duration);
    }
}
