document.addEventListener('DOMContentLoaded', function () {

    var messageInput = document.getElementById('message');

    // Get the user name and store it to prepend to messages.
    var name = document.getElementById("username").value;
    // Set initial focus to message input box.

    // Start the connection.
    var connection = new signalR.HubConnectionBuilder()
        .withUrl('/chat')
        .build();
    var newMassage = false;
    // Create a function that the hub can call to broadcast messages.
    connection.on('broadcastMessage', function (name, message) {
        // Html encode display name and message.
        var encodedName = name;
        var encodedMsg = message;
        if (newMassage == false) {
            // Add the message to the page.
            var liElement = document.createElement('h2');
            liElement.innerHTML = "У вас нове повідомлення";
            document.getElementById('discussion').appendChild(liElement);
            newMassage = true;

        }
        

    });

    // Transport fallback functionality is now built into start.
    connection.start()
        .then(function () {
            console.log('connection started');
            document.getElementById('sendmessage').addEventListener('click', function (event) {
                // Call the Send method on the hub.
                connection.invoke('send', name, messageInput.value);

                event.preventDefault();
            });
        })
        .catch(error => {
            
        });
});