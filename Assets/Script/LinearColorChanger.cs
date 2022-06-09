using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearColorChanger : MonoBehaviour
{
    [HideInInspector] public SpriteRenderer Target;

    [SerializeField] private float _duration;
    private float _runningTime;
    private Color _startColor;
    
    [SerializeField] private Color _targetColor;
    private void Start()
    {
        Target = GetComponent<SpriteRenderer>();
        _startColor = Target.color;
    }
    // Update is called once per frame
    void Update()
    {
        if (_runningTime <= _duration)
        {
            _runningTime += Time.deltaTime;
            float normalizeRunningTime = _runningTime / _duration;
            Target.color = Color.Lerp(_startColor, _targetColor, normalizeRunningTime);
            /*Color newColor = new Color(_targetColor.r * normalizeRunningTime, _targetColor.g * normalizeRunningTime, _targetColor.b *normalizeRunningTime);
            Target.color = newColor;*/
        }
    }
}

