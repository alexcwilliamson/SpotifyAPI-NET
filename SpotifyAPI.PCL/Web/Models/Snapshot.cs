namespace SpotifyAPI.PCL.Web.Models
{
    using Newtonsoft.Json;

    public class Snapshot : BasicModel
    {
        [JsonProperty("snapshot_id")]
        public string SnapshotId { get; set; }
    }
}