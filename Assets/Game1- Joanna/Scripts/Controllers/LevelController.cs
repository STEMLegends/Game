using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public int enemiesDefeated, enemiesDefeatedToWin = 10;

    public void CheckConditions(int live)
    {
        if (enemiesDefeated >= enemiesDefeatedToWin)
        {
            //Win the game cause you defeated the required number of enemies.
            SceneManager.LoadScene("win_scene");
        }
        if (live <=0)
        {
            SceneManager.LoadScene("lose_scene");
        }
    }

	private void Start()
	{
        JoannaHeath.OnChange += CheckConditions;
	}

	private void OnEnable()
	{
        JoannaHeath.OnChange += CheckConditions;
	}

    private void OnDisable()
    {
        JoannaHeath.OnChange -= CheckConditions;

    }
	private void OnDestroy()
	{
        JoannaHeath.OnChange -= CheckConditions;

	}

}
