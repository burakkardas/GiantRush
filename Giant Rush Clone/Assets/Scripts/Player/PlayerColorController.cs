using System.Collections.Generic;
using UnityEngine;
using BUMGames;

public class PlayerColorController : MonoBehaviour
{
    private Dictionary<int, string> colors = new Dictionary<int, string>();
    [SerializeField] private List<Color> colorList = new List<Color>();

    [SerializeField] private Material _playerMaterial;

    [SerializeField] private float _duration;

    public string currentColor;
    public int currentIndex;


    private void Awake()
    {
        AddColorsDictionaryItem();
    }



    private void Start()
    {
        CheckPlayerColor();
        Utility.SetMaterialColorSmoothTranstations(_playerMaterial, colorList[currentIndex], 0.5f, false);
    }



    private void CheckPlayerColor()
    {
        if (currentColor == "")
            SetRandomPlayerColor();
        else
        {
            for (int i = 0; i < colors.Count; i++)
            {
                if (currentColor == colors[i])
                {
                    currentIndex = i;
                }
            }
        }
    }



    private void SetRandomPlayerColor()
    {
        currentIndex = Random.Range(0, colors.Count);

        currentColor = colors[currentIndex];
    }





    private void AddColorsDictionaryItem()
    {
        colors.Add(0, GameColors.YELLOW);
        colors.Add(1, GameColors.ORANGE);
        colors.Add(2, GameColors.BLUE);
    }
}
