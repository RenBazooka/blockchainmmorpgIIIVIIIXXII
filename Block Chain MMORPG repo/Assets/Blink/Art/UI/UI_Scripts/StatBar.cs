using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BLINK.UI
{
    public class StatBar : MonoBehaviour
    {
        public float delay;
        public float speed;

        public Image bar;

        private bool _fillUp = true;
        private bool _isReady;
        private IEnumerator Start()
        {
            bar.fillAmount = 0;
            yield return new WaitForSeconds(delay);
            _isReady = true;
        }

        private void FixedUpdate()
        {
            if(!_isReady) return;
            bar.fillAmount += _fillUp ? speed : -speed;
            if (Math.Abs(bar.fillAmount - 1) < 0.01f) _fillUp = false;
            else if (bar.fillAmount == 0) _fillUp = true;
        }
    }
}
