using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using DG.Tweening;

public class PlayerVFXController : MonoBehaviour
{
    [SerializeField] private Volume _volume;
    private Vignette _vignette;


    [SerializeField] private float _maxIntensityValue;
    [SerializeField] private float _duration;
    private float _currentLerp;


    private void Start()
    {
        GetVignetteComponent();
    }



    public void SetVignetteIntensity()
    {
        DOTween.To(() => _currentLerp, x => _currentLerp = x, _maxIntensityValue, _duration).
            OnUpdate(() =>
            {
                _vignette.intensity.value = _currentLerp;
            }).OnComplete(() => OnCompleteIntensity());
    }



    private void OnCompleteIntensity()
    {
        DOTween.To(() => _currentLerp, x => _currentLerp = x, 0, _duration).
            OnUpdate(() =>
            {
                _vignette.intensity.value = _currentLerp;
            });
    }



    private void GetVignetteComponent()
    {
        Vignette _tmp;


        if (_volume.profile.TryGet<Vignette>(out _tmp))
        {
            _vignette = _tmp;
        }
    }
}
