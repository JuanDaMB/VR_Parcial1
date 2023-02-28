using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    private bool _isParticleOn = false;

    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private Gradient colorGradient;
    public void ParticleState()
    {
        _isParticleOn = !_isParticleOn;
        if (_isParticleOn)
        {
            _particleSystem.Play();
        }
        else
        {
            _particleSystem.Stop();
        }
    }

    public void ParticleDirection(float value)
    {
        float newValue = value * 2 - 1f;
        var main = _particleSystem.velocityOverLifetime;
        main.orbitalY = new ParticleSystem.MinMaxCurve(newValue*5f);
    }

    public void ParticleColor(float value)
    {
        var main = _particleSystem.main;
        main.startColor = new ParticleSystem.MinMaxGradient(colorGradient.Evaluate(value));
    }
}
