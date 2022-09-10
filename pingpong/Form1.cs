using System;
using System.Media;
using System.Windows.Forms;
//////////////////////////////////////////////////////////////////////////////////////////
// CODIGO ADAPTADO POR FLÁVIO NEVES - GITHUB https://github.com/F7AV10                  ///
// JOGO PONG CLASSICO FEITO DE FORMA SIMPLES EM WINFORM E C# COMO PARTE DE UM EXERCICIO ///
// https://www.youtube.com/watch?v=cC7Oo9kHn_Y&ab_channel=ShaunHalverson                ///
//////////////////////////////////////////////////////////////////////////////////////////
namespace pingpong
{
    public partial class PONG : Form
    {
        // VARIAVEIS LOCAIS
        int cpuDirection = 5;
        int ballXCoordinate = 5;
        int ballYCoordinate = 5;
        // SCORE VARIAVEIS
        int playerScore = 0;
        int cpuScore = 0;
        // VARIAVES CONTROLE DE TAMANHO
        int bottomBoundary;
        //int centerPoint;
        int xMidPoint;
        int yMidPoint;
        // VARIAVEIS DE DETECÇÃO
        bool playerDetectedUp;
        bool playerDetectedDown;
        // KEYS ADICIONAIS
        int spaceBarClicked = 0;

        public PONG()
        {
            InitializeComponent();
            //DEFINIR INICIALMENTE O FIM DA PARTE DE BAIXO DO CAMPO (TAMANHO DA JANELA DO JOGO - TAMANHO DO JOGADOR)
            bottomBoundary = ClientSize.Height - player.Height;
            //DEFINIR MEIO DA TELA (TAMANHO DA JANELA DO JOGO DIVIDIDO POR 2)
            xMidPoint = ClientSize.Width / 2;//COMPRIMENTO
            yMidPoint = ClientSize.Height / 2;//ALTURA

        }

        private void PONG_Load(object sender, EventArgs e)
        {
            pongTimer.Stop();
        }

        private void pongTimer_Tick(object sender, EventArgs e)
        {
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);

            //AJUSTAR ONDE A BOLA ESTÁ
            ball.Top -= ballYCoordinate;
            ball.Left -= ballXCoordinate;
            //FAZ O MOVIMENTO DO CPU
            cpuPlayer.Top += cpuDirection;
            
            //CHECA SE O cpuPlayer CHEGOU AO LIMITE DO TOPO OU DE BAIXO DA JANELA DO GAME
            if (cpuPlayer.Top < 0 || cpuPlayer.Top > bottomBoundary)
            {
                cpuDirection = -cpuDirection;
            }
            //CHECA SE A BOLA SAIU PELA LATERAL DA JANELA DO JOGO
            if (ball.Left < 0)
            {
                ball.Left = xMidPoint;
                ball.Top = newSpot;
                ballXCoordinate = -ballXCoordinate;
                cpuScore++;
                SystemSounds.Hand.Play();
                cpuScoreLabel.Text = cpuScore.ToString();
            }
            //CHECA SE A BOLA SAIU PELA LATERAL DA JANELA DO JOGO
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = xMidPoint;
                ball.Top = newSpot;
                ballXCoordinate = -ballXCoordinate;
                playerScore++;
                //PARA CADA PONTO FEITO O JOGADOR DIMINUI O TAMANHO DIFICULTANDO
                player.Height = (player.Height - 5);
                SystemSounds.Exclamation.Play();
                playerScoreLabel.Text = playerScore.ToString();
            }
            //CHECA SE A BOLA QUICA EM ALGUMA DAS ESTREMIDADES E MUDA TAMBEM A DIREÇÃO DO CPUPLAYER
            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height) { ballYCoordinate = -ballYCoordinate; SystemSounds.Beep.Play(); cpuDirection = -cpuDirection; }

            //CHECA QUE A BOLA REBATE NO player OU cpuPlayer
            if (ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpuPlayer.Bounds))
            {
                ballXCoordinate = -ballXCoordinate;
                SystemSounds.Beep.Play();
                
            }

            //CONTROLES DO JOGADOR
            //MOVER player PARA CIMA
            if (playerDetectedUp == true && player.Top > 0) { player.Top -= 10; }
            //MOVER player PARA BAIXO
            if (playerDetectedDown == true && player.Top < bottomBoundary) { player.Top += 10; }

            //CONDIÇÕES DE VITORIA
            if (playerScore >= 10) { pongTimer.Stop(); winLabel.Visible = true; winLabel.Text = "Player Venceu!"; }//player
            if (cpuScore >= 10) { pongTimer.Stop(); winLabel.Visible = true; winLabel.Text = "CPU Venceu!"; }//CPU


        }
        private void PONG_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { playerDetectedUp = false; }
            if (e.KeyCode == Keys.Down) { playerDetectedDown = false; }
        }

        private void PONG_KeyDown(object sender, KeyEventArgs e)
        {
            //SE O JOGADOR APERTAR O BOTAO PARA CIMA, MOVE O JOGADOR PARA CIMA
            if (e.KeyCode == Keys.Up) { playerDetectedUp = true;}
            //SE O JOGADOR APERTAR O BOTAO PARA BAIXO, MOVE O JOGADOR PARA CIMA
            if (e.KeyCode == Keys.Down) { playerDetectedDown = true;}
            
            //SE O JOGADOR APERTAR ESPAÇO PAUSA O JOGO, CASÓ NÃO ESTEJA NO FIM DO JOGO (LABEL DE VITORIA VISIVEL)
            if (e.KeyCode == Keys.Space && winLabel.Visible == false)
                {
                    if (spaceBarClicked % 2 == 0)
                    {
                        pongTimer.Stop();
                    }
                    else
                    {
                        pongTimer.Start();
                    }
                }
                spaceBarClicked++;
            }

    }
}
