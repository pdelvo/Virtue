using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace Virtue.GitHub
{
    [JsonObject]
    public class AuthenticatedUser
    {
        // http://developer.github.com/v3/users/#get-the-authenticated-user
        [JsonProperty(PropertyName = "login")]
        public string Username { get; set; }
        public int Id { get; set; }
        [JsonProperty(PropertyName = "avatar_url")]
        public string AvatarUrl { get; set; }
        [JsonProperty(PropertyName = "gravatar_id")]
        public string GravatarId { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Blog { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        [JsonProperty(PropertyName = "hireable")]
        public bool ForHire { get; set; }
        [JsonProperty(PropertyName = "bio")]
        public string Biography { get; set; }
        [JsonProperty(PropertyName = "public_repos")]
        public int PublicRepositories { get; set; }
        [JsonProperty(PropertyName = "private_repos")]
        public int PrivateRepositories { get; set; }
        public int Followers { get; set; }
        public int Following { get; set; }
        [JsonProperty(PropertyName = "html_url")]
        public string HtmlUrl { get; set; }
        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; set; }
        public string Type { get; set; }
        [JsonProperty(PropertyName = "total_private_repos")]
        public int TotalPrivateRepositories { get; set; }
        [JsonProperty(PropertyName = "owned_private_repos")]
        public int OwnedPrivateRepositories { get; set; }
        [JsonProperty(PropertyName = "private_gists")]
        public int PrivateGists { get; set; }
        [JsonProperty(PropertyName = "disk_usage")]
        public int DiskUsage { get; set; }
        public int Collaborators { get; set; }
        // TODO: GitHub Plan
    }
}
