using System;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
        
    public float velocidadeDoJogador;
    public Animator oAnimador;
    public int quantidadeDeMoedas;
    public Text textoDasMoedasAtuais;
    public GameObject painelDeGameOver;
    
    void Start()
    {
        oAnimador = GetComponent<Animator>();
        quantidadeDeMoedas = 0;
        textoDasMoedasAtuais.text = "X" + quantidadeDeMoedas;
    }

    void Update()
    {
        MovimentarJogador();
    }

    public void MovimentarJogador()
    { 
        float comandosDoTeclado = Input.GetAxisRaw("Horizontal") * velocidadeDoJogador * Time.deltaTime;
        transform.position = new Vector3((transform.position.x + comandosDoTeclado), transform.position.y,
        transform.position.z);

        // Personagem vira para a DIREITA
        if(comandosDoTeclado > 0.01f)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        // Personagem vira para a ESQUERDA
        if(comandosDoTeclado < -0.01f)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        // Ativa/Desativa as Animações "ANDANDO" E "PARADO"
        if(comandosDoTeclado == 0)
        {
            oAnimador.Play("Player_Parado");
        }
        else
        {
            oAnimador.Play("Player_Andando");
        }

    }


    public void AumentarQuantidadeDeMoedas()
    {
        quantidadeDeMoedas =+ 1;
        textoDasMoedasAtuais.text = "X" + quantidadeDeMoedas;
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        painelDeGameOver.SetActive(true);
        Debug.Log("Game Over");
        
    }
}
