using UnityEngine;
using DG.Tweening;



namespace BUMGames
{
    public class Utility
    {
        public static void SetRotateObject(Transform transform, Vector3 position, float duration)
        {
            transform.DORotate(position, duration).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear).SetRelative();
        }



        public static void SetScaleSmoothTranstations(Transform transform, Vector3 endScale, float duration, Ease ease)
        {
            var currentScale = transform.localScale;
            transform.DOScale(endScale, duration).SetEase(ease).OnComplete(() => transform.DOScale(currentScale, duration).SetEase(ease));
        }



        public static void SetMaterialColorSmoothTranstations(Material material, Color endColor, float duration, bool isBack)
        {
            if (!isBack)
                material.DOColor(endColor, duration);
            else
            {
                var currentColor = material.color;
                material.DOColor(endColor, duration).OnComplete(() => material.DOColor(currentColor, duration));
            }
        }



        public static Vector3 RandomVector(float minX, float maxX, float minY, float maxY, float minZ, float maxZ)
        {

            float randX = Random.Range(minX, maxX);
            float randY = Random.Range(minY, maxY);
            float randZ = Random.Range(minZ, maxZ);

            return new Vector3(randX, randY, randZ);
        }

    }
}
