﻿namespace SpotifyAPI.PCL.Web.Models
{
    using System;

    using Newtonsoft.Json;

    public class Token
    {
        public Token()
        {
            this.CreateDate = DateTime.Now;
        }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }

        public DateTime CreateDate { get; set; }

        /// <summary>
        ///     Checks if the token has expired
        /// </summary>
        /// <returns></returns>
        public Boolean IsExpired()
        {
            return this.CreateDate.Add(TimeSpan.FromSeconds(this.ExpiresIn)) <= DateTime.Now;
        }
    }
}