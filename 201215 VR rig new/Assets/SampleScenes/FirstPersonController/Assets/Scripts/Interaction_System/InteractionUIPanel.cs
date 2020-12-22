﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace VHS
{        
    public class InteractionUIPanel : MonoBehaviour
    {
        [SerializeField] private Image progressBar;

        public InteractionUIPanel(TextMeshProUGUI tooltipText) => this.tooltipText = tooltipText != null ? tooltipText : throw new System.ArgumentNullException(nameof(tooltipText));

        [SerializeField] private TextMeshProUGUI tooltipText;

        public void SetTooltip(string tooltip)
        {
            NewMethod(tooltip);
        }

        private void NewMethod(string tooltip)
        {
            tooltipText.SetText(tooltip);
        }

        public void UpdateProgressBar(float fillAmount)
        {
            progressBar.fillAmount = fillAmount;
        }

        public void ResetUI()
        {
            progressBar.fillAmount = 0f;
            tooltipText.SetText("");
        }
    }
}
