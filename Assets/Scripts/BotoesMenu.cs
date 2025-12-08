using UnityEngine;
using UnityEngine.SceneManagement;
public class BotoesMenu : MonoBehaviour
{
    public string nomeDoFilho = "Config";
   public void IniciarJogo()

    {
        SceneManager.LoadScene("jogo(0)");
    }

 void Start()
    {
        FecharConfig();
    }

   public void VoltarAoMenu()
    {
        SceneManager.LoadScene("menu(1)");
    }
  
     public void IrConfig()
    {
        SceneManager.LoadScene("Config");
    }
     public void MostrarConfig()
    {
       Transform filho = transform.Find(nomeDoFilho);
        filho.gameObject.SetActive(true);
    }
    public void FecharConfig()
    {
         Transform filho = transform.Find(nomeDoFilho);
        filho.gameObject.SetActive(false);
    }
   public void SairDoJogo()
    {
        Application.Quit();
    }







}
