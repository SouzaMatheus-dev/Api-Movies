﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ManagementOfWatchedFilms.Infrastructure.CrossCutting.IMDb.Models.Response
{
    public class Rating
    {
        [JsonPropertyName("Source")]
        public string Source { get; set; }

        [JsonPropertyName("Value")]
        public string Value { get; set; }
    }

    public class MovieResponse
    {
        [JsonPropertyName("Title")]
        public string Title { get; set; }

        [JsonPropertyName("Year")]
        public string Year { get; set; }

        [JsonPropertyName("Rated")]
        public string Rated { get; set; }

        [JsonPropertyName("Released")]
        public string Released { get; set; }

        [JsonPropertyName("Runtime")]
        public string Runtime { get; set; }

        [JsonPropertyName("Genre")]
        public string Genre { get; set; }

        [JsonPropertyName("Director")]
        public string Director { get; set; }

        [JsonPropertyName("Writer")]
        public string Writer { get; set; }

        [JsonPropertyName("Actors")]
        public string Actors { get; set; }

        [JsonPropertyName("Plot")]
        public string Plot { get; set; }

        [JsonPropertyName("Language")]
        public string Language { get; set; }

        [JsonPropertyName("Country")]
        public string Country { get; set; }

        [JsonPropertyName("Awards")]
        public string Awards { get; set; }

        [JsonPropertyName("Poster")]
        public string Poster { get; set; }

        [JsonPropertyName("Ratings")]
        public List<Rating> Ratings { get; set; }

        [JsonPropertyName("Metascore")]
        public string Metascore { get; set; }

        [JsonPropertyName("imdbRating")]
        public string ImdbRating { get; set; }

        [JsonPropertyName("imdbVotes")]
        public string ImdbVotes { get; set; }

        [JsonPropertyName("imdbID")]
        public string ImdbID { get; set; }

        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonPropertyName("totalSeasons")]
        public string TotalSeasons { get; set; }

        [JsonPropertyName("Response")]
        public string Response { get; set; }
    }
}