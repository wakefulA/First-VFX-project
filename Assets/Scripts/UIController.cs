﻿using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class UIController : MonoBehaviour
    {
        [SerializeField] private AutomaticRotator _automaticRotator;
        [SerializeField] private ManuallyRotator _manuallyRotator;
    
        [Header("Buttons")]
        [SerializeField] private Button _buttonAutomatic;
        [SerializeField] private Button _buttonManually;

        private void Awake()
        {
            _buttonAutomatic.onClick.AddListener(AutomaticModeActive);
            _buttonManually.onClick.AddListener(ManuallyModeActive);
        }

        private void ManuallyModeActive()
        {
            _automaticRotator.StopDOTween();
        }

        private void AutomaticModeActive()
        {
            _automaticRotator.StartDOTween();
        }
    }
}