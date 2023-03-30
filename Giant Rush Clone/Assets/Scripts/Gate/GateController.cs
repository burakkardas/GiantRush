using UnityEngine;
using DG.Tweening;

public class GateController : MonoBehaviour
{
    private MPBController _mPBController;
    public ColorData colorData = new ColorData();
    public string currentColor;
    [SerializeField] private float _endYValue;
    [SerializeField] private float _duration;


    private void Awake()
    {
        _mPBController = GetComponent<MPBController>();
    }


    private void Start()
    {
        colorData.SetCurrentColor();
        _mPBController.mainColor = colorData.currentColor;
        _mPBController.SetPropertyBlock();
        currentColor = colorData.currentColorName;
    }



    public void MoveToDown()
    {
        transform.DOMoveY(_endYValue, _duration);
    }
}
