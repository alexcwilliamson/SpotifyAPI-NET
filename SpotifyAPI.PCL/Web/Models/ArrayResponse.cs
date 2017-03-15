namespace SpotifyAPI.PCL.Web.Models
{
    using System.Collections.Generic;

    public class ListResponse<T> : BasicModel
    {
        public List<T> List { get; set; }
    }
}