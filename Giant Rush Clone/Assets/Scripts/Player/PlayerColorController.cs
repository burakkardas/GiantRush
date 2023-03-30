using System.Collections.Generic;
using UnityEngine;
using BUMGames;



public class PlayerColorController : MonoBehaviour
{
    [SerializeField] private PlayerDataTransmitter _playerDataTransmitter;

    public ColorData colorData = new ColorData();

    [SerializeField] private Material _playerMaterial;
    [SerializeField] private float _duration;


    private void Awake()
    {
        colorData.SetCurrentColor();
        Utility.SetMaterialColorSmoothTranstations(_playerMaterial, colorData.currentColor, 0.25f, false);
        _playerDataTransmitter.SetColorhumanIcon(colorData.currentColor);
    }



    public void SetPlayerColor(string color)
    {
        colorData.ChangeCurrentColor(color);
        Utility.SetMaterialColorSmoothTranstations(_playerMaterial, colorData.currentColor, 0.25f, false);
    }
}



[System.Serializable]
public class ColorData
{
    private Dictionary<string, Color> colors = new Dictionary<string, Color>() {
        {GameColors.YELLOW, new Color32(255, 164, 0, 255)},
        {GameColors.ORANGE, new Color32(253, 129, 70, 255)},
        {GameColors.BLUE, new Color32(0, 159, 255, 255)},
    };


    public enum ColorType
    {
        Yellow,
        Orange,
        Blue
    }

    public ColorType colorType;

    [HideInInspector] public Color currentColor;
    [HideInInspector] public string currentColorName;



    public void SetCurrentColor()
    {
        currentColorName = colorType.ToString();
        currentColor = colors[currentColorName];
    }



    public void ChangeCurrentColor(string color)
    {
        currentColorName = color;
        currentColor = colors[currentColorName];
    }
}
