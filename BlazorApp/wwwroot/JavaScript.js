function testj(){
    DotNet.invokeMethodAsnc("BlazorApp", "testJS")
        .then(resultado => {
            console.log('test' + resultado)
        })
}