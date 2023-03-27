using UnityEngine;

public class PlayerDataTransmitter : MonoBehaviour
{
    [SerializeField] private PlayerLevelController _playerLevelController;
    [SerializeField] private PlayerScaleController _playerScaleController;
    [SerializeField] private PlayerAnimationController _playerAnimationController;






    #region Animation
    public void SetRunAnimation(bool value)
    {
        _playerAnimationController.SetRunAnimation(value);
    }
    #endregion
}
