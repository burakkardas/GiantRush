using UnityEngine;


public class HumanController : MonoBehaviour
{
    private MPBController _mPBController;
    public ColorData colorData = new ColorData();
    public string currentColor;


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
}
