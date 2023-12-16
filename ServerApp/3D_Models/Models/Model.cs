using ServerApp.Secret;

namespace ServerApp._3D_Models.Models

{
    public class Model
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Path { get; set; } 
    }
}
