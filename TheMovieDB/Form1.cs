using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheMovieDB
{
    public partial class Form1 : Form
    {
        List<Genre> genreList;
        List<TrendingMovies> moviesList;

        //decide which objects & lists are global to the app

        public Form1()
        {
            InitializeComponent();
        }

        // first Load when app is opened
        private void Form1_Load(object sender, EventArgs e)
        {
            //parameter set up to build list
            var client = new RestSharp.RestClient("https://api.themoviedb.org/3/genre/movie/list");
            var request = new RestRequest();
            string myKey = "781046521a0eff736f9333fc2e29adc2";
            request.AddParameter("api_key", myKey);
            //service call
            var response = client.Execute(request);
            JsonDeserializer deserializer = new JsonDeserializer();
            var temp = new GenreObject();
            temp = deserializer.Deserialize<GenreObject>(response);
            genreList = temp.Genres;
            // GenreBox.Items.Add(temp);
            //MessageBox.Show(response.Content);
            GenreBox.Items.Add("GENRES");
            GenreBox.Items.Add("");
            foreach (Genre gr in genreList)
            {
                GenreBox.Items.Add(gr.name);
            }
        }


        // button function when a client clicks on Home icon
        private void HomeButton_Click(object sender, EventArgs e)
        {
            var client = new RestSharp.RestClient("https://api.themoviedb.org/3/trending/all/day");
            var request = new RestRequest();
            string myKey = "781046521a0eff736f9333fc2e29adc2";
            request.AddParameter("api_key", myKey);
            var response = client.Execute(request);
            JsonDeserializer deserializer = new JsonDeserializer();
            MessageBox.Show(response.Content);
        }


        //get genres
        private void GenreBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("Movies of this genre");
            var select_genre = GenreBox.SelectedIndex;
            var select_name = GenreBox.SelectedItem.ToString();
            int genre_id = 0;

            var client2 = new RestSharp.RestClient("https://api.themoviedb.org/3/genre/movie/list");
            var request2 = new RestRequest();

            string myKey2 = "781046521a0eff736f9333fc2e29adc2";
            request2.AddParameter("api_key", myKey2);
            //service call
            var response2 = client2.Execute(request2);
            JsonDeserializer deserializer2 = new JsonDeserializer();
            var temp2 = new GenreObject();
            temp2 = deserializer2.Deserialize<GenreObject>(response2);
            var genreList2 = temp2.Genres;

            foreach (Genre gr in genreList2)
            {
                if (select_name == gr.name)
                {
                    genre_id = gr.id;
                }
                //GenreBox.Items.Add(gr.name);
            }
            string myKey = "781046521a0eff736f9333fc2e29adc2";
            var genre_url = "https://api.themoviedb.org/3/discover/movie?api_key=" + myKey;
            var client = new RestClient(genre_url + "&language=en-US&sort_by=popularity.desc&include_adult=false&include_video=false&page=1&with_genres=" + genre_id);
            var request = new RestRequest();
            //service call
            var response = client.Execute(request);
            JsonDeserializer deserializer = new JsonDeserializer();
            var temp = new TrendingMoviesObject();
            temp = deserializer.Deserialize<TrendingMoviesObject>(response);
            moviesList = temp.results;

            // label1.Text = moviesList[0].original_title;
            //string path = "https://image.tmdb.org/t/p/w500_and_h282_face" + moviesList[0].poster_path;
            //pictureBox1.Load(path);
            listBox1.Items.Clear();
            foreach (TrendingMovies gr in moviesList)
            {
                // listView1.Items.Add(gr.title);

                listBox1.Items.Add(gr.original_title);

                //string path = "https://image.tmdb.org/t/p/w500_and_h282_face" + moviesList + gr.poster_path;
               
      
            }

           // pictureBox1.Load(moviesList[0].poster_path);

        }

       
        //select each movies 
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var select_movie = listBox1.SelectedIndex;
            string path = "https://image.tmdb.org/t/p/w500_and_h282_face/";
            MoviePic.Load(path + moviesList[select_movie].poster_path);
            MovieTitle.Text = moviesList[select_movie].title;
            DescriptionBox.Text = moviesList[select_movie].overview;
        }

        //search for movies 
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            
         
        }

        private void search_button1_Click(object sender, EventArgs e)
        {
            //parameter set up to build list
            var search_client = new RestSharp.RestClient("http://www.omdbapi.com/");
            var search_request = new RestRequest();
            string myKey = "7560307d bv";
            search_request.AddParameter("t", myKey);

            //service call
            var search_response = search_client.Execute(search_request);
            JsonDeserializer deserializer = new JsonDeserializer();
            var search_temp = new SearchObject();
            search_temp = deserializer.Deserialize<SearchObject>(search_response);
            SearchTitle.Text = search_temp.Actors + "";
            SearchView.Items.Add(search_temp.Plot);
        }
    }
}
