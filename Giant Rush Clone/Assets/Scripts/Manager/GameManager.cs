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
        if (!_firstTouch)
        {
            _firstTouch = true;
            _isStart = true;
        }
    }
}
