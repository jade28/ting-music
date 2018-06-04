﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class Myplaylist : UserControl
    {
        private List<Song> songs = new List<Song>();
        public List<Song> Songs { get => songs; }
        private AlbumDetails albumDetails = new AlbumDetails();
        public AlbumDetails fDetails { get { albumDetails.totalSong = songs.Count; return albumDetails; } }

        public Myplaylist()
        {
            InitializeComponent();
        }
        public event EventHandler BtnImage_Click;
        public Image PlaylistImage
        {
            get
            {
                return btnImage.BackgroundImage;
            }
            set
            {
                btnImage.BackgroundImage = value;
            }
        }
        public string PlaylistName
        {
            get
            {
                return labelPlaylistName.Text;
            }
            set
            {
                labelPlaylistName.Text = value;
            }
        }


        public static Myplaylist CreateArtist(Song song)
        {
            Myplaylist artist = new Myplaylist();
            artist.songs.Add(song);
            artist.labelPlaylistName.Text = song.ArtistName;
            artist.btnImage.BackgroundImage = song.ImageSong;
            artist.albumDetails.PlaylistImage = song.ImageSong;
            artist.albumDetails.PlaylistName = song.ArtistName;
            
            return artist;
        }

        public static Myplaylist CreateAlbum(Song song)
        {
            Myplaylist album = new Myplaylist();
            album.songs.Add(song);
            album.labelPlaylistName.Text = song.Album;
            album.btnImage.BackgroundImage = song.ImageSong;
            album.albumDetails.PlaylistImage = song.ImageSong;
            album.albumDetails.PlaylistName = song.ArtistName;
            return album;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            BtnImage_Click?.Invoke(this, e);
        }
    }
}
