using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointAdder : MonoBehaviour
{

    public GameObject winningCondition;
    public string pointsLabel;
    private int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        refresh();
    }

    public void addPoint() {
        this.points += 1;
        winningCondition.GetComponent<WinningCondition>().addPoint();
        refresh();
    }

    private void refresh() {
        this.GetComponent<TextMeshProUGUI>().text = pointsLabel + points;
    }
}
