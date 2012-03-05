using RepositoryModel;

namespace MvcMusicStore.Models
{
    public class Artist : IArtist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
    }
}