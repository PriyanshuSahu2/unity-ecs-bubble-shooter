
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace Game.Ecs.Systems
{
    
    public class Score : MonoBehaviour
    {
        [SerializeField] TMP_Text scoreShow;
        public int score = 0;
        private void Update()
        {
            score = PlayerPrefs.GetInt("Score");
            scoreShow.SetText(score.ToString());
        }

        static void Quit()
        {
            PlayerPrefs.DeleteKey("Score");
        }

        [RuntimeInitializeOnLoadMethod]
        static void RunOnStart()
        {
            Application.quitting += Quit;
        }
        
    }
    
}