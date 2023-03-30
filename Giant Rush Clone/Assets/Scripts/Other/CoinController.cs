using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using BUMGames;



public class CoinController : MonoBehaviour
{
    [SerializeField] private GameObject _earnedCoinParent;

    [SerializeField] private List<RectTransform> _coinList = new List<RectTransform>();

    [SerializeField] private Ease _ease;

    [SerializeField] private Vector3 _endPosition;
    [SerializeField] private Vector3 _endScale;
    private Vector3[] _initialPosition;
    private Quaternion[] _initialRotation;


    [SerializeField] private float _duration;
    [SerializeField] private float _delayMultiplier;
    private float _delay;



    void Start()
    {
        _initialPosition = new Vector3[_coinList.Count];
        _initialRotation = new Quaternion[_coinList.Count];
        GetPositionAndRotations();
    }


    public void EarnedCoin()
    {
        ResetPositionAndRotations();

        _delay = 0;
        _earnedCoinParent.SetActive(true);


        for (int i = 0; i < _coinList.Count; i++)
        {
            _coinList[i].DOScale(_endScale, _duration).SetDelay(_delay).SetEase(_ease);
            _coinList[i].DOAnchorPos(_endPosition, _duration).SetDelay(_delay + 0.5f).SetEase(_ease);
            _coinList[i].DOScale(Vector3.zero, _duration).SetDelay(_delay + 0.8f).SetEase(_ease);

            _delay += _delayMultiplier;
        }
    }




    private void ResetPositionAndRotations()
    {
        for (int i = 0; i < _coinList.Count; i++)
        {
            _coinList[i].GetComponent<RectTransform>().localPosition = Utility.RandomVector(-100, 100, -100, 100, 0, 0);
            _coinList[i].rotation = _initialRotation[i];
        }
    }




    private void GetPositionAndRotations()
    {
        for (int i = 0; i < _coinList.Count; i++)
        {
            _initialPosition[i] = _coinList[i].position;
            _initialRotation[i] = _coinList[i].rotation;
        }
    }
}
