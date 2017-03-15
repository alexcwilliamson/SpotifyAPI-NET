namespace SpotifyAPI.PCL.Web.Enums
{
    using System;

    [Flags]
    public enum FollowType
    {
        [String("artist")]
        Artist = 1,

        [String("user")]
        User = 2
    }
}