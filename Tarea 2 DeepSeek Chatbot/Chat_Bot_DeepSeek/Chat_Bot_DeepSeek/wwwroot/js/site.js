LoadScript();
function LoadScript() {
    $("#sendButton").click(SendMessage);
}

function LoadMessages_Chat(msg) {

    $("#chat-box").append('<div class="chat chat_message"><h6>' + msg + '</h6></div>');
    $("#chat-box").scrollTop($("#chat-box")[0].scrollHeight);

}
function LoadMessages_User(msg) {
    $("#chat-box").append('<div class="chat user_message"><h6>' + msg + '</h6></div>');
    $("#messageInput").val("")
}
function SendMessage() {
    var message = $("#messageInput").val();
    LoadMessages_User(message);

    $("#sendButton").prop("disabled", true);
    $("#loader").show();
    postAction(
        "Home/SendMessage",
        JSON.stringify({ Message: message }),
        (rsp) => {
            $("#loader").hide()
            $("#sendButton").prop("disabled", false);
            LoadMessages_Chat(rsp.respuesta)
        },
        (rsp) => {
            console.log("Error en la solicitud")
        }
    )
}

function postAction(URL, objectParams, successFunction, failFunction) {
    $.ajax({
        url: URL, // URL del endpoint
        method: "POST", // Método HTTP (POST)
        contentType: "application/json", // Tipo de contenido enviado (JSON)
        data: objectParams,
        success: (rsp => { successFunction(rsp) }),
        error: (rsp => { failFunction(rsp) })
    });
}
