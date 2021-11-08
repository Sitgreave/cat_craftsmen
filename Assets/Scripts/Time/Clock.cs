
using System.Collections;

using UnityEngine;

using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    [SerializeField] Image _clockFace;
    [SerializeField] int _secondsOnCycle;
    private const int _countCicle = 4;
    private static int _currentCycle;

    public static Clock instance = null;
    public delegate void OnCycleChanged();
    public static event OnCycleChanged CycleChanged;
    

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
            StartCoroutine(nameof(PassageOfTime));
        }
        else if (instance == this)
        {
            Destroy(gameObject);

        }
    }

    private void DelegateAssign()
    {
        switch (_currentCycle)
        {
            case (int)DayCycle.morning:
                
                    break;
                
        }
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
          if(CycleChanged != null) CycleChanged();
            ShowTime();
            yield return new WaitForSecondsRealtime(_secondsOnCycle);
        }
    }
     
   public enum DayCycle
    {
        morning = 1,
        day = 2,
        evening = 3,
        night = 4
    }

    public static int CurrentCycle()
    {
        return _currentCycle;
    }
}
