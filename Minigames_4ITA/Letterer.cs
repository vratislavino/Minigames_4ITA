using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minigames_4ITA
{
    public partial class Letterer : Minigame
    {
        private Random random = new Random();
        bool first = true;

        static string letters = "awertzuiopasdfghjklyxcvbnm";

        char generatedChar;

        public Letterer() {
            InitializeComponent();
        }
        public override void StartMinigame() {
            GenerateRandomLetter();
        }

        private void GenerateRandomLetter() {
            generatedChar = letters[random.Next(letters.Length)];
            label1.Text = generatedChar.ToString().ToUpper();
        }

        private void Letterer_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode.ToString() == generatedChar.ToString().ToUpper()) {
                score++;
                GenerateRandomLetter();
                first = false;
                timer1.Stop();
                timer1.Start();
            } else {
                EndMinigame();
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            
            if (!first) {
                EndMinigame();
                timer1.Stop();
            }
        }
    }
}
