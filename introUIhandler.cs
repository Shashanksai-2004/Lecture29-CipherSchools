using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introUI : MonoBehaviour
{
   public GameObject instructionPanel;

   public void ToggleInstructionPanel(int toggle)
   {
        if(toggle == 1)
        {
            instructionPanel.SetActive(false);
        }
        else
        {
            instructionPanel.SetActive(true);
        }
   }

   public void ChangesCurrentScene()
   {
        Scene CurrentScene = SceneManager.GetActiveScene();

        int nextIndex = CurrentScene.buildIndex +1;

        SceneManager.LoadScene(nextIndex);
   }
}
