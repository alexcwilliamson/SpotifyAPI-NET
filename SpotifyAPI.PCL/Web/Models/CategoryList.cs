namespace SpotifyAPI.PCL.Web.Models
{
    using Newtonsoft.Json;

    public class CategoryList : BasicModel
    {
        [JsonProperty("categories")]
        public Paging<Category> Categories { get; set; }
    }
}