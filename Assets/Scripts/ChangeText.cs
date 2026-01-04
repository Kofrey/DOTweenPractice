using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _delay = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText("Новый текст", _delay));
        sequence.Append(_text.DOText($" И ещё текст", _delay).SetRelative());
        sequence.Append(_text.DOText("бац-бабах, шмыргли-бом", _delay, true, ScrambleMode.All));
        sequence.SetLoops(-1, LoopType.Yoyo);
    }
}
