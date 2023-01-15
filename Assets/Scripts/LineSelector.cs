using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineSelector : MonoBehaviour
{
    public List<Line> LinesList;

    public void SelectLine(string selectedLineName)
    {

        foreach (Line line in LinesList)
        {
            if(line.name == selectedLineName)
            {
                line.selected = true;
            }

            else
            {
                line.selected = false;
            }
        }
    }

}
