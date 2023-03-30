using UnityEngine;

public class PlayerDataTransmitter : MonoBehaviour
{
    [SerializeField] private PlayerLevelController _playerLevelController;
    [SerializeField] private PlayerScaleController _playerScaleController;
    [SerializeField] private PlayerAnimationController _playerAnimationController;
    [SerializeField] private PlayerColorController _playerColorController;
    [SerializeField] private PlayerUIController _playerUIController;
    [SerializeField] private PlayerVFXController _playerVFXController;
    [SerializeField] private PlayerMovementController _playerMovementController;



    public void OnHit(Vector3 scaleValue, int levelValue)
    {
        SetPlayerLevel(levelValue);
        SetScale(scaleValue);
    }



    #region Movement
    public void SetMovementValue(float value)
    {
        _playerMovementController.movementSpeed = value;
    }



    public void SetIsLevelEnd(bool value)
    {
        _playerMovementController.isLevelEnd = value;
    }
    #endregion



    #region VFX
    public void SetVignetteIntensity()
    {
        _playerVFXController.SetVignetteIntensity();
    }
    #endregion



    #region UI
    public void SetColorhumanIcon(Color color)
    {
        _playerUIController.SetColorhumanIcon(color);
    }



    public void SetHumanCountText(int value)
    {
        _playerUIController.SetHumanCountText(value);
    }



    public void SetDiamondCountText(int value)
    {
        _playerUIController.SetDiamondCountText(value);
    }
    #endregion



    #region Color
    public string GetCurrentColor()
    {
        return _playerColorController.colorData.currentColorName;
    }



    public void SetPlayerColor(string color)
    {
        _playerColorController.SetPlayerColor(color);
    }
    #endregion



    #region Level
    public void SetPlayerLevel(int value)
    {
        _playerLevelController.SetPlayerLevel(value);
    }
    #endregion



    #region Scale
    public void SetScale(Vector3 value)
    {
        _playerScaleController.SetScale(value);
    }
    #endregion



    #region Animation
    public void SetRunAnimation(bool value)
    {
        _playerAnimationController.SetRunAnimation(value);
    }
    #endregion
}
