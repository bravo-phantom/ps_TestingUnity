using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PillarMove : MonoBehaviour
{
    public Vector3 firstPos;
    public Vector3 secondPos;
    public float duration;
    public bool canRotate;
    public bool canMove;
    public float timeToStartRotate;
    public float timeToStartMoving;
    
    private void Start()
    {
        Invoke(nameof(Move) , timeToStartMoving);
    }

    private void Move()
    {
        if(canMove)
        transform.DOMove(secondPos, duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }

    private void Update()
    {
        Invoke(nameof(Rotate) , timeToStartRotate);
    }

    private void Rotate()
    {
        if (canRotate)
        {
            transform.Rotate(new Vector3(0, 0.3f, 0));
        }
    }
}
