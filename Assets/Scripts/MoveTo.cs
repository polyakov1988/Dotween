using DG.Tweening;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;
    [SerializeField] private int _loopsCount;
    [SerializeField] private LoopType _loopType;
    
    private void Start()
    {
        transform.DOMove(_position, _duration)
            .SetEase(Ease.InOutQuad)
            .SetLoops(_loopsCount, _loopType);
    }
}
