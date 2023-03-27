using UnityEngine;


public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private Animator _animator;


    public void SetRunAnimation(bool value)
    {
        _animator.SetBool(AnimationParameters.RUN, value);
    }
}



struct AnimationParameters
{
    public const string RUN = "Run";
}
