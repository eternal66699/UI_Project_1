using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Alarm_UI;
    public Vector3 TargetSize;
    public Vector3 TargetPosition;
    public float TargetTime;
    public float MoveSpeed;

    public void ResizeDown()
    {
        Alarm_UI.transform.DOScale(TargetSize, TargetTime).SetEase(Ease.InOutElastic).OnComplete(() => Destroy(Alarm_UI));
    }
    public void ChangePosition()
    {
        Alarm_UI.transform.DOLocalMove(TargetPosition, MoveSpeed).SetEase(Ease.InOutBounce).OnComplete(()=>ResizeDown());
    }
}
