using UnityEngine;

public class MPBController : MonoBehaviour
{
    [SerializeField] private Renderer _objectRenderer;
    private MaterialPropertyBlock _materialPropertyBlock;

    [SerializeField] private Color _mainColor;


    private void Awake()
    {
        SetPropertyBlock();
    }



    public void SetPropertyBlock()
    {
        _materialPropertyBlock = new MaterialPropertyBlock();
        _materialPropertyBlock.SetColor("_BaseColor", _mainColor);
        _objectRenderer.SetPropertyBlock(_materialPropertyBlock);
    }
}
