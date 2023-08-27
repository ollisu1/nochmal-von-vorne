using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
        public void PlayAgain()
        {
            SceneManager.LoadScene(2);
        }

         public void ExitGame()
        {
            Application.Quit();
        }
}
