using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minigames_4ITA
{
    public class Minigame : UserControl
    {
        public event Action OnMinigameEnded;

        protected int score;

        public int Damage => score;

        public Minigame() : base() {
            DoubleBuffered = true;
        }

        public virtual void StartMinigame() {

        }

        public virtual void EndMinigame() {
            OnMinigameEnded?.Invoke();
        }
    }
}
