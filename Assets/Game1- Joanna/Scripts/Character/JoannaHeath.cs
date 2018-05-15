using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoannaHeath : MonoBehaviour {

    [SerializeField]  int lives = 8;
    [SerializeField] int maxLives = 10;
    [SerializeField]  int enemies = 0;
    [SerializeField] Text HeahtText;

    //Event on health Change
    public delegate void Change(int live);
    public static event Change OnChange;

    public bool inmunity;

    public void AddLife(int lifeAmount)
    {
        lives = Mathf.Min(lifeAmount + lives, maxLives);
        UpdateHUD();
        OnChange(lives);

    }

    public void AddDamage(int damageAmount)
    {
        if (!inmunity) // tiempo de inmunidad para escapar del peligro
        {
            lives -= damageAmount;
            UpdateHUD();
            OnChange(lives);
        }
        inmunity = true;
        StartCoroutine(TemporalInmunity());
    }
    //Inmunidad temporal;

    IEnumerator TemporalInmunity()
    {
        yield return new WaitForSeconds(2f);
        inmunity = false;
        yield break;
    }

	private void UpdateHUD()
	{
        HeahtText.text = lives.ToString();
	}

}
