using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HistoryUnit : MonoBehaviour
{
    [SerializeField] private TMP_Text timeStampText;
    [SerializeField] private TMP_Text tokenNameText;
    [SerializeField] private TMP_Text tokenCountText;

    public void SetUnit(string timeStamp, string tokenName, string tokenCount)
    {
        timeStampText.text = timeStamp;
        tokenNameText.text = tokenName;
        tokenCountText.text = tokenCount;
    }

    public TMP_Text GetTimeStampText() { return timeStampText; }
    public TMP_Text GetNameText() { return tokenNameText; }
    public TMP_Text GetTokenCountText() { return tokenCountText; }
    public GridLayoutGroup GetGridLayout() { return GetComponent<GridLayoutGroup>(); }
    public Image GetUnitImage() { return GetComponent<Image>(); }
}
