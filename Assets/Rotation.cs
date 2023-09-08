using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Rotation : MonoBehaviour
{
    public Image Image_1;
    public float dur;
    public float fadeDur;
    public float MoveSpeed;
    public Vector3 targetRotation;
    public Vector3 TargetPosition;
    // Start is called before the first frame update
    void Start()
    {
        Sequence sequence = DOTween.Sequence();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Rotate()
    {
        Image_1.transform.DOLocalRotate(targetRotation, dur).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
    }

    public void Fade()
    {
        Image_1.DOFade(0, fadeDur);
    }

    public void Transitions()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(Image_1.transform.DOLocalMove(TargetPosition, MoveSpeed));

        sequence.AppendInterval(1);

        sequence.Append(Image_1.transform.DOLocalRotate(targetRotation, dur));

        sequence.AppendInterval(1);

        sequence.Append(Image_1.DOFade(0, fadeDur));
    }
}
