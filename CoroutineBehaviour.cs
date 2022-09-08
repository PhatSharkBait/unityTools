using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour {
    private bool canRun;
    public float repeatTime, delayTime, countDownTime = 1.0f;
    public IntDataSO counterDown;
    public UnityEvent delayEvent, beginRepeatEvent, repeatEvent, endRepeatEvent, repeatUntilFalseEvent;

    private WaitForSeconds _waitForSecondsDelay, _waitForSecondsCountDown, _waitForSecondsUntilFalse;

    public bool CanRun
    {
        get => canRun;
        set => canRun = value;
    }

    private void Awake() {
        _waitForSecondsDelay = new WaitForSeconds(delayTime);
        _waitForSecondsCountDown = new WaitForSeconds(countDownTime);
        _waitForSecondsUntilFalse = new WaitForSeconds(repeatTime);
    }

    private IEnumerator AfterDelayEvent() {
        yield return _waitForSecondsDelay;
        delayEvent.Invoke();
    }
    
    private IEnumerator BeginCountdown() {
        beginRepeatEvent.Invoke();
        while (counterDown.value > 0) {
            repeatEvent.Invoke();
            counterDown.value --;
            yield return _waitForSecondsCountDown;
        }
        endRepeatEvent.Invoke();
    }

    private IEnumerator RepeatUntilFalse() {
        while (CanRun) {
            repeatUntilFalseEvent.Invoke();
            yield return _waitForSecondsUntilFalse;
        }
    }
    
    public void BeginDelayCoroutine() {
        StartCoroutine(AfterDelayEvent());
    }

    public void BeginCountDownCoroutine() {
        StartCoroutine(BeginCountdown());
    }
    public void BeginRepeatUntilFalseCoroutine() {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }
    
}
