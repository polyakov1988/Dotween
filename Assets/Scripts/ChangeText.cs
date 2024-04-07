using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _delay;
    [SerializeField] private string _replacingText;
    [SerializeField] private string _addingText;
    [SerializeField] private string _scramblingText;
    [SerializeField] private float _duration;
    [SerializeField] private int _loopsCount;
    [SerializeField] private LoopType _loopType;
    
    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        
        sequence.Append(_text.DOText(_replacingText, _duration)
            .SetDelay(_delay));
        
        sequence.Append(_text.DOText(_addingText, _duration)
            .SetDelay(_delay)
            .SetRelative());
        
        sequence.Append(_text.DOText(_scramblingText, _duration, true, ScrambleMode.All)
            .SetDelay(_delay));
        
        sequence.SetLoops(_loopsCount, _loopType);
    }
}
