using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;


    private bool _isStart;
    public bool IsStart
    {
        get { return _isStart; }
        set { _isStart = value; }
    }


    private bool _firstTouch;


    private int _humanCount = 0;
    public int HumanCount
    {
        get { return _humanCount; }
        set { _humanCount = value; }
    }



    private int _diamondCount = 0;
    public int DiamondCount
    {
        get { return _diamondCount; }
        set { _diamondCount = value; }
    }



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



    private void Update()
    {
        HandleGameInputs();
    }



    private void HandleGameInputs()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!_firstTouch)
            {
                _firstTouch = true;
                _isStart = true;
                UIManager.Instance.MoveDownStartPanel();
            }
        }

    }
}
