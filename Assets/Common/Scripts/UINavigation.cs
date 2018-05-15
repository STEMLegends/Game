using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UINavigation : MonoBehaviour {

    protected int currentState = 0;
    protected int currentCharacter = 0;

    public Text yourButtonText;

    // Use this for initialization
    void Awake()
    {

    }

    // Use this for initialization
    void Start()
    {
        yourButtonText = GameObject.Find("character_Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TaskOnClick()
    {
        currentState++;

        if (currentState == 1)
        {
            // Hide objects
            GameObject.Find("start_Button").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("bg_start").transform.localScale = new Vector3(0, 0, 0);

            // Show objects
            GameObject.Find("bg_select_character").transform.localScale = new Vector3(0.93f, 0.93f, 0.93f);
            GameObject.Find("play_Button").transform.localScale = new Vector3(1, 1, 1);
            GameObject.Find("left_Button").transform.localScale = new Vector3(1, 1, 1);
            GameObject.Find("right_Button").transform.localScale = new Vector3(1, 1, 1);
            GameObject.Find("character_Text").transform.localScale = new Vector3(1, 1, 1);
            GameObject.Find("character_wangari").transform.localScale = new Vector3(0.37f, 0.37f, 0.37f);
        }
        else
        if (currentState == 2)
        {
            // Hide objects
            GameObject.Find("bg_select_character").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("play_Button").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("left_Button").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("right_Button").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("character_Text").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("character_joanna").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("character_ada").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("character_wangari").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("character_noether").transform.localScale = new Vector3(0, 0, 0);

            // Show objects
            GameObject.Find("bg_intro_joanna").transform.localScale = new Vector3(0.94f, 0.94f, 0.94f);
            GameObject.Find("enter_Button").transform.localScale = new Vector3(1, 1, 1);
        }
        else
        if (currentState == 3)
        {
            Application.LoadLevel("stem4girls");
        }
    }

    public void SelectCharacterLeft()
    {
        if (currentCharacter == 0)
        {
            currentCharacter = 3;
        }
        else
        {
            currentCharacter--;
        }

        GameObject.Find("character_joanna").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("character_ada").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("character_wangari").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("character_noether").transform.localScale = new Vector3(0, 0, 0);

        switch (currentCharacter)
        {
            case 0:
                yourButtonText.text = "¡Mambo! A mí ante todo me preocupan las personas y el medioambiente, estudié ciencias y biología con lo que procuré mejorar la situación de Kenya, mi país.\r\n\r\nEn 2004, fue todo un honor recibir el premio Nobel de la paz.\r\n\r\n¡Ven conmigo a ayudarme!";
                GameObject.Find("character_wangari").transform.localScale = new Vector3(0.37f, 0.37f, 0.37f);
                break;
            case 1:
                yourButtonText.text = "Mi nombre es Ada, hija de Lord Byron. Nací en el siglo XIX, se me considera la primera programadora de la historia.\r\n\r\nTambién me encantan la escritura y en especial la poesía, por ello me gané el sobrenombre de la científica poetisa, soy muy creativa.\r\n\r\n¡Vamos a divertirnos!";
                GameObject.Find("character_ada").transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
                break;
            case 2:
                yourButtonText.text = "¡Hola! Soy de Varsovia y desde pequeña me ha fascinado la informática.\r\n\r\nMe siento orgullosa de crear sistemas de seguridad que protejan nuestros ordenadores, soy hacker.\r\n\r\n¡Acompáñame en mi misión!";
                GameObject.Find("character_joanna").transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
                break;
            case 3:
                yourButtonText.text = "¡Dame cualquier problema y buscaré como resolverlo!\r\n\r\nEsta pasión me llevó a importantes descubrimientos en álgebra abstracta y física teórica.\r\n\r\nPor lo que muchos, entre ellos Einstein, me han considerado la matemática más importante.";
                GameObject.Find("character_noether").transform.localScale = new Vector3(0.39f, 0.39f, 0.39f);
                break;
            default:
                break;
        }
    }

    public void SelectCharacterRight()
    {
        if (currentCharacter == 3)
        {
            currentCharacter = 0;
        }
        else
        {
            currentCharacter++;
        }

        GameObject.Find("character_joanna").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("character_ada").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("character_wangari").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("character_noether").transform.localScale = new Vector3(0, 0, 0);

        switch (currentCharacter)
        {
            case 0:
                yourButtonText.text = "¡Mambo! A mí ante todo me preocupan las personas y el medioambiente, estudié ciencias y biología con lo que procuré mejorar la situación de Kenya, mi país.\r\n\r\nEn 2004, fue todo un honor recibir el premio Nobel de la paz.\r\n\r\n¡Ven conmigo a ayudarme!";
                GameObject.Find("character_wangari").transform.localScale = new Vector3(0.37f, 0.37f, 0.37f);
                break;
            case 1:
                yourButtonText.text = "Mi nombre es Ada, hija de Lord Byron. Nací en el siglo XIX, se me considera la primera programadora de la historia.\r\n\r\nTambién me encantan la escritura y en especial la poesía, por ello me gané el sobrenombre de la científica poetisa, soy muy creativa.\r\n\r\n¡Vamos a divertirnos!";
                GameObject.Find("character_ada").transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
                break;
            case 2:
                yourButtonText.text = "¡Hola! Soy de Varsovia y desde pequeña me ha fascinado la informática.\r\n\r\nMe siento orgullosa de crear sistemas de seguridad que protejan nuestros ordenadores, soy hacker.\r\n\r\n¡Acompáñame en mi misión!";
                GameObject.Find("character_joanna").transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
                break;
            case 3:
                yourButtonText.text = "¡Dame cualquier problema y buscaré como resolverlo!\r\n\r\nEsta pasión me llevó a importantes descubrimientos en álgebra abstracta y física teórica.\r\n\r\nPor lo que muchos, entre ellos Einstein, me han considerado la matemática más importante.";
                GameObject.Find("character_noether").transform.localScale = new Vector3(0.39f, 0.39f, 0.39f);
                break;
            default:
                break;
        }
    }
}
