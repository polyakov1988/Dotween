using DG.Tweening;
using UnityEngine;

public class ScaleTo : MonoBehaviour
{
    [SerializeField] private Vector3 _scale;
    [SerializeField] private float _duration;
    [SerializeField] private int _loopsCount;
    [SerializeField] private LoopType _loopType;
    
    private void Start()
    {
        transform.DOScale(_scale, _duration)
            .SetEase(Ease.InOutQuad)
            .SetLoops(_loopsCount, _loopType);
    }
}
