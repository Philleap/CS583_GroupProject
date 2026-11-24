using UnityEngine;

[RequireComponent(typeof(Light))]
public sealed class LightFlicker : MonoBehaviour
{
    private Light _light;
    private float _normalIntensity;
    private float _nextFlickerTime;

    private void Awake()
    {
        _light = GetComponent<Light>();
        _normalIntensity = _light.intensity;
    }

    private void Update()
    {
        if (!_light.enabled || Time.time < _nextFlickerTime)
        {
            return;
        }

        _light.intensity = _normalIntensity * Random.Range(0.3f, 1f);
        _nextFlickerTime = Time.time + Random.Range(0.05f, 0.2f);
    }

    private void OnDisable()
    {
        _light.intensity = _normalIntensity;
    }
}