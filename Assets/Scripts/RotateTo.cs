using DG.Tweening;
using UnityEngine;

public class RotateTo : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _duration;
    [SerializeField] private int _loopsCount;
    [SerializeField] private LoopType _loopType;
    
    private void Start()
    {
        transform.DORotate(_rotation, _duration)
            .SetEase(Ease.Linear)
            .SetLoops(_loopsCount, _loopType);
    }
}