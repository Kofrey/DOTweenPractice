using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _delay = 3f;
    [SerializeField] private string _newText = "Новый текст";
    [SerializeField] private string _addText = " И ещё текст";
    [SerializeField] private string _cryptedText = "бац-бабах, шмыргли-бом";

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText(_newText, _delay));
        sequence.Append(_text.DOText(_addText, _delay).SetRelative());
        sequence.Append(_text.DOText(_cryptedText, _delay, true, ScrambleMode.All));
        sequence.SetLoops(-1, LoopType.Yoyo);
    }
}
