using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProblemGenerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public string[] GetRandomProblem()
    {
        string[,][] problems = new string[,][]
        {
            { new string[] { "Problem 1", "Description 1", "Dialogue 1.1", "Dialogue 1.2" } },
            { new string[] { "Problem 2", "Description 2", "Dialogue 2.1", "Dialogue 2.2" } },
            { new string[] { "Problem 3", "Description 3", "Dialogue 3.1", "Dialogue 3.2" } }
        };

        // Generate a random problem
        int randomIndex = Random.Range(0, problems.GetLength(0));
        string[] selectedProblem = problems[randomIndex, 0];

        return selectedProblem;
    }
}
