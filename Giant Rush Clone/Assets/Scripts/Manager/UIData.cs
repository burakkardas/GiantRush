using UnityEngine;

public class UIData : MonoBehaviour
{
    public RectTransform startPanelTransform;
    public RectTransform gamePanelTransform;
    public RectTransform gameWonPanelTransform;


    private void Awake()
    {
        UIManager.Instance.startPanelTransform = startPanelTransform;
        UIManager.Instance.gamePanelTransform = gamePanelTransform;
        UIManager.Instance.gameWonPanelTransform = gameWonPanelTransform;
    }
}
