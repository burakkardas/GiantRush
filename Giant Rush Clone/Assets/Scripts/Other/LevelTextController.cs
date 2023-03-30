using UnityEngine;
using DG.Tweening;



public class LevelTextController : MonoBehaviour
{
    [SerializeField] private RectTransform _rectTransform;


    [SerializeField] private float _endYValue;
    private float _currentYValue;
    [SerializeField] private float _duration;


    private void Start()
    {
        _currentYValue = _rectTransform.localPosition.y;
    }


    private void OnEnable()
    {
        _rectTransform.DOLocalMoveY(_rectTransform.localPosition.y + _endYValue, _duration).OnComplete(() => ObjectPooler.Instance.DeSpawnObject(PoolType.LevelText, gameObject));
    }


    private void OnDisable()
    {
        _rectTransform.localPosition = new Vector3(_rectTransform.localPosition.x, _currentYValue, _rectTransform.localPosition.z);
    }
}
