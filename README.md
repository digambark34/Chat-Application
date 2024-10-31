
# Chat Console Application

A simple console-based chat application written in C#. This application allows multiple users to join a chat, send messages to each other or to the whole chat room, view active users, and clear chat history.

## Features
- **Add and Remove Users**: Users can join and leave the chat room.
- **Send Messages**: Users can send direct messages to specific users or broadcast messages to all users in the chat room.
- **Display Messages**: View all messages in the chat history.
- **View Active Users**: Check a list of active users in the chat room.
- **Clear Chat History**: Clear the entire chat history.

## Requirements
- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 3.1 or later)

## Getting Started

### Clone the Repository
```bash
git clone https://github.com/your-username/ChatConsoleApp.git
cd ChatConsoleApp
```

### Build and Run
1. **Open the project in your preferred IDE (e.g., Visual Studio or Visual Studio Code) or in the terminal.**
2. **Run the application:**
   ```bash
   dotnet run
   ```

## Usage
1. **Enter Your Username**: When the application starts, enter your username to join the chat.
2. **Select Options**: Choose from the available options to send messages, view chat history, view active users, clear chat history, or exit.
3. **Send a Message**:
   - Enter a recipient username to send a direct message or enter `all` to send a message to everyone.
4. **Clear Chat History**: Clear all messages by selecting the clear chat history option.

## Example Usage
```plaintext
Enter Username:
> Alice

Options:
1: Send Message
2: View Chat
3: View Active Users
4: Clear Chat History
5: Exit
Select an Option:
> 1

Enter recipient username (or 'all' for public):
> Bob

Enter your Message:
> Hello, Bob!
Message sent to Bob

Options:
> 2
Chat Messages:
[14:23:45] Alice --> Bob Hello, Bob!
```

## Code Structure
- **Message Class**: Represents each chat message with sender, receiver, timestamp, and text.
- **Chat Class**: Handles chat logic, including adding/removing users, sending messages, displaying users, and clearing the chat.
- **Program Class**: Entry point of the application where user interactions are handled in a loop.

## Contributions
Feel free to fork this repository, open issues, and submit pull requests to improve the project. Contributions are welcome!

Let me know if you'd like to add more details or customize any section!
