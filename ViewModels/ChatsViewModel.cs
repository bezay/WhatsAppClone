using WhatsAppClone.Models;

namespace WhatsAppClone.ViewModels;

public partial class ChatsViewModel: ObservableObject
{
    [ObservableProperty]
    public ObservableCollection<ChatList> _recentChats;
    public ChatsViewModel()
    {
        RecentChats = GetChats();
    }

    private ObservableCollection<ChatList> GetChats()
    {
        var recentChats = new ObservableCollection<ChatList> { 
            new ChatList { Id = 1, Name = "Alice", LastMessage = "Hey, how are you?", DateSent = DateTime.Now.AddMinutes(-5), ProfilePicture = "pimage.png", UnreadCount = 2 },
            new ChatList { Id = 2, Name = "Bob", LastMessage = "Let's catch up later.", DateSent = DateTime.Now.AddHours(-1), ProfilePicture = "pimage.png", UnreadCount = 0 },
            new ChatList { Id = 3, Name = "Charlie", LastMessage = "Did you see the game last night?", DateSent = DateTime.Now.AddDays(-1), ProfilePicture = "pimage.png", UnreadCount = 1 },
            new ChatList { Id = 1, Name = "Alice", LastMessage = "Hey?", DateSent = DateTime.Now.AddMinutes(-5), ProfilePicture = "pimage.png", UnreadCount = 2 },
            new ChatList { Id = 2, Name = "Bob", LastMessage = "Whats up??", DateSent = DateTime.Now.AddHours(-1), ProfilePicture = "pimage.png", UnreadCount = 0 },
            new ChatList { Id = 3, Name = "Charlie", LastMessage = "Did you see the game last night?", DateSent = DateTime.Now.AddDays(-1), ProfilePicture = "pimage.png", UnreadCount = 1 },
            new ChatList { Id = 1, Name = "Alice", LastMessage = "Hey, how are you?", DateSent = DateTime.Now.AddMinutes(-5), ProfilePicture = "pimage.png", UnreadCount = 2 },
            new ChatList { Id = 2, Name = "Bob", LastMessage = "Let's catch up later.", DateSent = DateTime.Now.AddHours(-1), ProfilePicture = "pimage.png", UnreadCount = 0 },
            new ChatList { Id = 3, Name = "Charlie", LastMessage = "Did you see the game last night?", DateSent = DateTime.Now.AddDays(-1), ProfilePicture = "pimage.png", UnreadCount = 1 },
            new ChatList { Id = 1, Name = "Alice", LastMessage = "Hey?", DateSent = DateTime.Now.AddMinutes(-5), ProfilePicture = "pimage.png", UnreadCount = 2 },
            new ChatList { Id = 2, Name = "Bob", LastMessage = "Whats up??", DateSent = DateTime.Now.AddHours(-1), ProfilePicture = "pimage.png", UnreadCount = 0 },
            new ChatList { Id = 3, Name = "Charlie", LastMessage = "Did you see the game last night?", DateSent = DateTime.Now.AddDays(-1), ProfilePicture = "pimage.png", UnreadCount = 1 },
            new ChatList { Id = 1, Name = "Alice", LastMessage = "Hey, how are you?", DateSent = DateTime.Now.AddMinutes(-5), ProfilePicture = "pimage.png", UnreadCount = 2 },
            new ChatList { Id = 2, Name = "Bob", LastMessage = "Let's catch up later.", DateSent = DateTime.Now.AddHours(-1), ProfilePicture = "pimage.png", UnreadCount = 0 },
            new ChatList { Id = 3, Name = "Charlie", LastMessage = "Did you see the game last night?", DateSent = DateTime.Now.AddDays(-1), ProfilePicture = "pimage.png", UnreadCount = 1 },
            new ChatList { Id = 1, Name = "Alice", LastMessage = "Hey?", DateSent = DateTime.Now.AddMinutes(-5), ProfilePicture = "pimage.png", UnreadCount = 2 },
            new ChatList { Id = 2, Name = "Bob", LastMessage = "Whats up??", DateSent = DateTime.Now.AddHours(-1), ProfilePicture = "pimage.png", UnreadCount = 0 },
            new ChatList { Id = 3, Name = "Charlie", LastMessage = "Did you see the game last night?", DateSent = DateTime.Now.AddDays(-1), ProfilePicture = "pimage.png", UnreadCount = 1 }
        };
        return recentChats;
    }
}
