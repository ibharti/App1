function callMethod() {
    DotNet.invokeMethodAsync("BlazorApp", "GetValueFromMethod").then(result => {
        alert("Message from the method : " + result);
    })
}

function callInstanceMethod(instanceObject) {
    instanceObject.invokeMethodAsync("GetValueFromInstance").then(result => {
        alert("Message from the instance : " + result);
    })
    //since we are calling from the instance so need of the project 
    //name as done in the abovr function.
}