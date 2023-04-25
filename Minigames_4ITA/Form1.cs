namespace Minigames_4ITA
{
    public partial class Form1 : Form
    {
        Player player1;
        Player player2;

        Player currentPlayer;

        bool gameEnded = false;

        public Form1() {
            InitializeComponent();
            player1 = new Player() {
                hp = 10,
                image = null,
                jmeno = "Karel",
                hpBar = player1hp,
                nameLabel = player1name,
                hpText = player1hptext
            };

            player2 = new Player() {
                hp = 10,
                image = null,
                jmeno = "Petr",
                hpBar = player2hp,
                nameLabel = player2name,
                hpText = player2hptext
            };

            currentPlayer = player1;

            player1.Init();
            player2.Init();


            player2.OnHpChanged += OnPlayerHpChanged;
            player1.OnHpChanged += OnPlayerHpChanged;

            player2.OnPlayerDied += OnPlayerDied;
            player1.OnPlayerDied += OnPlayerDied;

            LoadRandomMinigame();
        }

        private void OnPlayerHpChanged(Player player) {
            player.UpdateHp();
        }

        private void OnPlayerDied(Player player) {
            minigamePanel.Controls.Clear();
            gameEnded = true;
            if (player == player1) {
                MessageBox.Show($"Poèítaè {player2.jmeno} vyhrál!");
                Application.Restart();
            } else {
                MessageBox.Show($"hráè {player1.jmeno} vyhrál!");
                Application.Restart();
            }
        }

        private void LoadRandomMinigame() {
            Minigame m = null;
            
            switch (new Random().Next(2)) {
                case 0:
                m = new Circler();
                break;
                case 1:
                m = new Letterer();
                break;
                default:
                m = new Letterer();
                break;
            }

            StartMinigame(m);
        }

        private void StartMinigame(Minigame minigame) {

            minigamePanel.Controls.Add(minigame);
            minigame.OnMinigameEnded += () => {
                player2.DoDamage(minigame.Damage);
                SwitchPlayer();
                minigamePanel.Controls.Remove(minigame);
            };
            minigame.StartMinigame();
            minigame.Focus();
        }

        private void SwitchPlayer() {
            if (gameEnded)
                return;

            if (currentPlayer == player1) {
                currentPlayer = player2;
                GenerateRandomDamageToPlayer();
                SwitchPlayer();
            } else {
                currentPlayer = player1;
                LoadRandomMinigame();
            }
        }

        private void GenerateRandomDamageToPlayer() {
            player1.DoDamage(new Random().Next(3, 10));
        }
    }
}