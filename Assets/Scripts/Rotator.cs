using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _angle;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;


    private void Start()
    {
        transform.DORotate(_angle, _duration).SetLoops(_repeats, _loopType);
    }
}
