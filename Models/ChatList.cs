namespace WhatsAppClone.Models
{
    public class ChatList
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? LastMessage { get; set; }
        public DateTime? DateSent { get; set; }
        public string? ProfilePicture { get; set; }
        public int? UnreadCount { get; set; }
    }
}
