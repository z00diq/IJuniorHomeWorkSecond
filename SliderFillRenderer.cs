using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SliderFillRenderer : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _duration;
    [SerializeField] private float _value;
    private float _currentValue;
    private float _targetValue;
    private float _maxValue;
    private float _normalizedValue;

    private void Start()
    {
        _maxValue = _slider.maxValue;
        _normalizedValue = _maxValue / _value;
    }

    private void RenderFill(bool Increment)
    {
        
        _currentValue = _slider.value;
        _targetValue = Increment ? _currentValue + _normalizedValue : _currentValue - _normalizedValue;
        _slider.DOValue(_targetValue, _duration);
    }

    public void IncreaseFill()
    {
        RenderFill(true);
    }

    public void DecreaseFill()
    {
        RenderFill(false);
    }

}
