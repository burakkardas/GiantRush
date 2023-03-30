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



    public void SetPlayerLevel(int value)
    {
        if (_level >= 1)
        {
            _level += value;

            if (_level <= 0)
            {
                _level = 1;
            }
        }


        UpdateLevelText();
    }



    private void UpdateLevelText()
    {
        _levelText.text = "LV. " + _level.ToString();
    }
}
