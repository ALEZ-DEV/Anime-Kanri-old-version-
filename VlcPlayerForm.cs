using LibVLCSharp.Shared;
using LibVLCSharp.WPF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeManager
{
    public partial class VlcPlayerForm : Form
    {
        MediaPlayer player;

        public VlcPlayerForm(string videoPath)
        {
            InitializeComponent();

            LibVLCSharp.Shared.Core.Initialize();

            LibVLC libVlc = new LibVLC();
            Media media = new Media(libVlc, videoPath);

            player = new MediaPlayer(media);

            player.Play();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (!player.IsPlaying)
            {
                player.Play();
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (player.IsPlaying)
            {
                player.Pause();
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            player.Dispose();
            this.Dispose();
        }

        void VlcPlayerForm_Closing(object sender, CancelEventArgs e)
        {

            player.Dispose();
            Close();

        }
    }
}
