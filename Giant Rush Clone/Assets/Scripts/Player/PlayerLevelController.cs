using UnityEngine;
using TMPro;

public class PlayerLevelController : MonoBehaviour
{
    [SerializeField] private TMP_Text _levelText;

    private int _level = 1;



    private void Start()
    {
        UpdateLevelText();
    }



    private void SetPlayerLevel(int value)
    {
        if (_level > 0)
        {
            _level += value;
        }


        UpdateLevelText();
    }



    private void UpdateLevelText()
    {
        _levelText.text = "LV. " + _level.ToString();
    }
}
