using System;
using System.Collections.Generic;

public class Message
{
    public string sender { get; set; }
    public string receiver { get; set; }
    public string text { get; set; }
    public DateTime timestamp { get; set; }

    public Message(string sender, string receiver, string text)
    {
        this.sender = sender;
        this.receiver = receiver;
        this.text = text;
        timestamp = DateTime.Now;
    }

    public override string ToString()
    {
        return $"[{timestamp:HH:mm:ss}] {sender} --> {receiver} {text}";
    }
}

public class Chat
{
    private List<Message> messages = new List<Message>();
    private List<string> users = new List<string>();

    public void Adduser(string user)
    {
        if (!users.Contains(user))
        {
            users.Add(user);
            Console.WriteLine($"{user} has joined the chat.");
        }
    }

    public void Removeuser(string user)
    {
        if (users.Contains(user))
        {
            users.Remove(user);
            Console.WriteLine($"{user} has left the chat.");
        }
    }

    public void Sendmessage(string sender, string receiver, string text)
    {
        var message = new Message(sender, receiver, text);
        messages.Add(message);
        Console.WriteLine($"{sender} sent a message to {receiver}: {text}");
    }

    public void Displaymessages()
    {
        Console.Clear();
        Console.WriteLine("Chat Messages");
        foreach (var message in messages)
        {
            Console.WriteLine(message);
        }
    }

    public void Displayusers()
    {
        Console.WriteLine("Active Users");
        foreach (var user in users)
        {
            Console.WriteLine($"-- {user}");
        }
    }

    public void Clearmessage()
    {
        messages.Clear();
        Console.WriteLine("Chat History Cleared.");
    }

    public bool Userexists(string user)
    {
        return users.Contains(user);
    }
}

public class Program
{
    private static void Main(string[] args)
    {
        Chat chat = new Chat();
        Console.WriteLine("Enter Username:");
        string username = Console.ReadLine();
        chat.Adduser(username);
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nOptions");
            Console.WriteLine("1: Send Message");
            Console.WriteLine("2: View Chat");
            Console.WriteLine("3: View Active Users");
            Console.WriteLine("4: Clear Chat History");
            Console.WriteLine("5: Exit");
            Console.Write("Select an Option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter recipient username (or 'all' for public):");
                    string recipient = Console.ReadLine();
                    if (recipient == "all")
                    {
                        Console.WriteLine("Enter your Message:");
                        string messageText = Console.ReadLine();
                        chat.Sendmessage(username, "All", messageText);
                    }
                    else if (chat.Userexists(recipient))
                    {
                        Console.WriteLine("Enter your Message:");
                        string directMessageText = Console.ReadLine();
                        chat.Sendmessage(username, recipient, directMessageText);
                        Console.WriteLine($"Message sent to {recipient}");
                    }
                    else
                    {
                        Console.WriteLine("User doesn't exist. Please try again.");
                    }
                    break;

                case "2":
                    chat.Displaymessages();
                    break;

                case "3":
                    chat.Displayusers();
                    break;

                case "4":
                    Console.WriteLine("Are you sure you want to clear the chat history? (yes/no)");
                    string confirm = Console.ReadLine().ToLower();
                    if (confirm == "yes")
                    {
                        chat.Clearmessage();
                    }
                    break;

                case "5":
                    Console.WriteLine("Are you sure you want to exit? (yes/no)");
                    string exitConfirm = Console.ReadLine().ToLower();
                    if (exitConfirm == "yes")
                    {
                        chat.Removeuser(username);
                        exit = true;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
        Console.WriteLine("Thank you for chatting!");
    }
}