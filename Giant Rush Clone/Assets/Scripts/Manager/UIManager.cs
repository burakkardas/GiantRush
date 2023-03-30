using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [HideInInspector] public RectTransform startPanelTransform;
    [HideInInspector] public RectTransform gamePanelTransform;
    [HideInInspector] public RectTransform gameWonPanelTransform;


    [SerializeField] private Ease _ease;


    [SerializeField] private float _startPanelEndYValue;
    [SerializeField] private float _duration;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }




    public void MoveDownStartPanel()
    {
        startPanelTransform.DOLocalMoveY(_startPanelEndYValue, _duration).SetEase(_ease).OnComplete(() => MoveDownGamePanel());
    }



    public void MoveDownGamePanel()
    {
        gamePanelTransform.DOLocalMoveY(0, _duration);
    }



    public void MoveUpGameEndPanel()
    {
        gameWonPanelTransform.DOLocalMoveY(0, _duration);
    }
}
