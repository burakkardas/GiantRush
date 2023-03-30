using UnityEngine;
using BUMGames;


public class PlayerCollisionController : MonoBehaviour
{
    [SerializeField] private PlayerDataTransmitter _playerDataTransmitter;
    private HumanController _human;




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(Tag.HUMAN))
        {
            _human = other.gameObject.GetComponent<HumanController>();

            if (_playerDataTransmitter.GetCurrentColor() == _human.currentColor)
            {
                GameManager.Instance.HumanCount++;
                _playerDataTransmitter.SetHumanCountText(GameManager.Instance.HumanCount);
                _playerDataTransmitter.OnHit(new Vector3(0.1f, 0.1f, 0.1f), 1);
                ObjectPooler.Instance.SpawnObject(PoolType.LevelText, transform.position, Quaternion.identity);
            }
            else
            {
                _playerDataTransmitter.OnHit(new Vector3(-0.1f, -0.1f, -0.1f), -1);
                _playerDataTransmitter.SetVignetteIntensity();
            }



            Destroy(other.gameObject);
        }




        if (other.gameObject.CompareTag(Tag.DIAMOND))
        {
            GameManager.Instance.DiamondCount++;
            _playerDataTransmitter.SetDiamondCountText(GameManager.Instance.DiamondCount);

            Destroy(other.gameObject);
        }



        if (other.gameObject.CompareTag(Tag.GATE))
        {
            _playerDataTransmitter.SetPlayerColor(other.gameObject.GetComponent<GateController>().currentColor);
            other.gameObject.GetComponent<GateController>().MoveToDown();
        }
    }



    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(Tag.LEVEL_END))
        {
            _playerDataTransmitter.SetMovementValue(0);
            _playerDataTransmitter.SetIsLevelEnd(true);
            _playerDataTransmitter.SetRunAnimation(false);
            UIManager.Instance.MoveUpGameEndPanel();
        }
    }
}