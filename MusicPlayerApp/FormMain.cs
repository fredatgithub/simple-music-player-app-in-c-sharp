using System;
using System.Windows.Forms;

namespace MusicPlayerApp
{
  public partial class MusicPlayerApp : Form
  {
    public MusicPlayerApp()
    {
      InitializeComponent();
    }

    //Create Global Variables of String Type Array to save the titles or name of the Tracks and path of the track
    string[] paths;
    string[] files;

    private void BtnSelectSongs_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog
      {
        Multiselect = true
      };

      if (ofd.ShowDialog() == DialogResult.OK)
      {
        files = ofd.SafeFileNames; //Save the names of the track in files array
        paths = ofd.FileNames; //Save the paths of the tracks in path array
                               //Display the music titles in listbox
        for (int i = 0; i < files.Length; i++)
        {
          listBoxSongs.Items.Add(files[i]); //Display Songs in Listbox
        }
      }
    }

    private void ListBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
    {
      //Write a code to play music
      axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
    }

    private void PictureBox1_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
