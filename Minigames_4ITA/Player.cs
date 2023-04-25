using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minigames_4ITA
{
    internal class Player
    {
        public event Action<Player> OnHpChanged;
        public event Action<Player> OnPlayerDied;

        public int hp;
        public Image image;
        public string jmeno;

        public Label nameLabel;
        public ProgressBar hpBar;
        public Label hpText;

        public void Init() {
            nameLabel.Text = jmeno;
            UpdateHp();
        }

        public void UpdateHp() {
            hpBar.Value = Math.Max(hp, 0);
            hpText.Text = $"{hp}/100";
        }

        public void DoDamage(int damage) {
            hp -= damage;
            OnHpChanged?.Invoke(this);

            if(hp <= 0) {
                OnPlayerDied?.Invoke(this);
            }
        }
    }
}
