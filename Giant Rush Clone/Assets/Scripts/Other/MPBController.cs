using UnityEngine;

public class MPBController : MonoBehaviour
{
    [SerializeField] private Renderer _objectRenderer;
    private MaterialPropertyBlock _materialPropertyBlock;

    public Color mainColor;


    private void Start()
    {
        SetPropertyBlock();
    }



    public void SetPropertyBlock()
    {
        _materialPropertyBlock = new MaterialPropertyBlock();
        _materialPropertyBlock.SetColor("_BaseColor", mainColor);
        _objectRenderer.SetPropertyBlock(_materialPropertyBlock);
    }
}
