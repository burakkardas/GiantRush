using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private PlayerDataTransmitter _playerDataTransmitter;


    public float movementSpeed;
    [SerializeField] private float _limitValue;
    private float _halfScreen;
    private float _xPosition;
    private float _endXPosition;

    public bool isLevelEnd;



    private void Update()
    {
        HandleHorizontalInput();
    }



    private void FixedUpdate()
    {
        SetPlayerMovement();
    }



    private void HandleHorizontalInput()
    {
        if (!isLevelEnd)
        {
            if (Input.GetMouseButton(0))
            {
                _halfScreen = Screen.width / 2;
                _xPosition = (Input.mousePosition.x - _halfScreen) / _halfScreen;
                _endXPosition = Mathf.Clamp(_xPosition * _limitValue, -_limitValue, _limitValue);
                _playerDataTransmitter.SetRunAnimation(true);
            }
        }
    }




    private void SetPlayerMovement()
    {
        if (GameManager.Instance.IsStart)
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.fixedDeltaTime);
            transform.position = new Vector3(_endXPosition, transform.position.y, transform.position.z);
        }
    }
}
