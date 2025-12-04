using UnityEngine;
using UnityEngine.SceneManagement;
public class BotoesMenu : MonoBehaviour
{
   public void IniciarJogo()
    {
        SceneManager.LoadScene("jogo(0)");
    }

   public void VoltarAoMenu()
    {
        SceneManager.LoadScene("menu(1)");
    }
  
     public void IrConfig()
    {
        SceneManager.LoadScene("Config");
    }

   public void SairDoJogo()
    {
        Application.Quit();
    }







}
