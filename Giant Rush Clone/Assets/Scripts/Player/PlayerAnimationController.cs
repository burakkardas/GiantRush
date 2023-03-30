using UnityEngine;


public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private Animator _animator;


    public void SetRunAnimation(bool value)
    {
        _animator.SetBool(AnimationParameters.RUN, value);
    }


    public void PlayPunchAnimation()
    {
        _animator.SetTrigger(AnimationParameters.PUNCH);
    }
}



struct AnimationParameters
{
    public const string RUN = "Run";
    public const string PUNCH = "Punch";
}
