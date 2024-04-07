using DG.Tweening;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Material _material;
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private int _loopsCount;
    [SerializeField] private LoopType _loopType;
    
    private void Start()
    {
        _material.DOColor(_color, _duration)
            .SetEase(Ease.Linear)
            .SetLoops(_loopsCount, _loopType);
    }
}
