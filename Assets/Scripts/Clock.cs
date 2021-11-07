using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    [SerializeField] Image _clockFace;
    [SerializeField] int _secondsOnCycle;
    private const int _countCicle = 4;
    private int _currentCycle;

    private void Start()
    {
        StartCoroutine(nameof(PassageOfTime));
    }
    private void ShowTime()
    {
        _clockFace.fillAmount = _currentCycle * 0.25f;
        Debug.Log(_currentCycle);
    }
    IEnumerator PassageOfTime()
    {
        while (true)
        {
            if (_currentCycle < _countCicle) _currentCycle++;
            else _currentCycle = 1;
            ShowTime();
            yield return new WaitForSecondsRealtime(_secondsOnCycle);
        }
    }
     
    enum DayCycle
    {
        morning = 1,
        day = 2,
        evening = 3,
        night = 4
    }

    public int CurrentCycle()
    {
        return _currentCycle;
    }
}
