using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUIController : MonoBehaviour
{
    [SerializeField] private Image _humanIcon;


    [SerializeField] private TMP_Text _humanCountText;
    [SerializeField] private TMP_Text _diamondCountText;


    public void SetHumanCountText(int value)
    {
        _humanCountText.text = value.ToString();
    }


    public void SetDiamondCountText(int value)
    {
        _diamondCountText.text = value.ToString();
    }



    public void SetColorhumanIcon(Color color)
    {
        _humanIcon.color = color;
    }
}
