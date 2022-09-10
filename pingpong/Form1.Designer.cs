
//////////////////////////////////////////////////////////////////////////////////////////
// CODIGO ADAPTADO POR FLÁVIO NEVES - GITHUB https://github.com/F7AV10                  ///
// JOGO PONG CLASSICO FEITO DE FORMA SIMPLES EM WINFORM E C# COMO PARTE DE UM EXERCICIO ///
// https://www.youtube.com/watch?v=cC7Oo9kHn_Y&ab_channel=ShaunHalverson                ///
//////////////////////////////////////////////////////////////////////////////////////////
namespace pingpong
{
    partial class PONG
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.PictureBox();
            this.cpuPlayer = new System.Windows.Forms.PictureBox();
            this.campoMarca = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.cpuScoreLabel = new System.Windows.Forms.Label();
            this.pongTimer = new System.Windows.Forms.Timer(this.components);
            this.winLabel = new System.Windows.Forms.Label();
            this.INFOlABEL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campoMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.White;
            this.player.Location = new System.Drawing.Point(12, 169);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(10, 88);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // cpuPlayer
            // 
            this.cpuPlayer.BackColor = System.Drawing.Color.White;
            this.cpuPlayer.Location = new System.Drawing.Point(778, 169);
            this.cpuPlayer.Name = "cpuPlayer";
            this.cpuPlayer.Size = new System.Drawing.Size(10, 88);
            this.cpuPlayer.TabIndex = 1;
            this.cpuPlayer.TabStop = false;
            // 
            // campoMarca
            // 
            this.campoMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.campoMarca.Location = new System.Drawing.Point(394, 12);
            this.campoMarca.Name = "campoMarca";
            this.campoMarca.Size = new System.Drawing.Size(5, 426);
            this.campoMarca.TabIndex = 2;
            this.campoMarca.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(388, 207);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(16, 16);
            this.ball.TabIndex = 3;
            this.ball.TabStop = false;
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerScoreLabel.Font = new System.Drawing.Font("Lucida Console", 50F);
            this.playerScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.playerScoreLabel.Location = new System.Drawing.Point(222, 23);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(124, 85);
            this.playerScoreLabel.TabIndex = 4;
            this.playerScoreLabel.Text = "0";
            this.playerScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuScoreLabel
            // 
            this.cpuScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpuScoreLabel.Font = new System.Drawing.Font("Lucida Console", 50F);
            this.cpuScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cpuScoreLabel.Location = new System.Drawing.Point(451, 23);
            this.cpuScoreLabel.Name = "cpuScoreLabel";
            this.cpuScoreLabel.Size = new System.Drawing.Size(124, 85);
            this.cpuScoreLabel.TabIndex = 5;
            this.cpuScoreLabel.Text = "0";
            this.cpuScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pongTimer
            // 
            this.pongTimer.Enabled = true;
            this.pongTimer.Interval = 15;
            this.pongTimer.Tick += new System.EventHandler(this.pongTimer_Tick);
            // 
            // winLabel
            // 
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.winLabel.ForeColor = System.Drawing.Color.White;
            this.winLabel.Location = new System.Drawing.Point(214, 274);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(364, 82);
            this.winLabel.TabIndex = 6;
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winLabel.Visible = false;
            // 
            // INFOlABEL
            // 
            this.INFOlABEL.BackColor = System.Drawing.Color.Transparent;
            this.INFOlABEL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.INFOlABEL.Location = new System.Drawing.Point(485, 429);
            this.INFOlABEL.Name = "INFOlABEL";
            this.INFOlABEL.Size = new System.Drawing.Size(351, 23);
            this.INFOlABEL.TabIndex = 7;
            this.INFOlABEL.Text = "PRECIONE \"ESPAÇO\" PARA PAUSAR E RESUMIR O GAME";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(527, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "SETAS \"CIMA\" E \"BAIXO\" CONTROLAM O PLAYER";
            // 
            // PONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.cpuPlayer);
            this.Controls.Add(this.player);
            this.Controls.Add(this.campoMarca);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.cpuScoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.INFOlABEL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(816, 488);
            this.MinimumSize = new System.Drawing.Size(816, 488);
            this.Name = "PONG";
            this.Text = "PONG";
            this.Load += new System.EventHandler(this.PONG_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PONG_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PONG_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campoMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox cpuPlayer;
        private System.Windows.Forms.PictureBox campoMarca;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label cpuScoreLabel;
        private System.Windows.Forms.Timer pongTimer;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label INFOlABEL;
        private System.Windows.Forms.Label label1;
    }
}

