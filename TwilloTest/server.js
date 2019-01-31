var express = require('express');
var app = express();

app.get('/', function (req, res) {
    res.send('Hello,There!!');
});

var server = app.listen(1337, function () {
    var host = server.address().address
    var port = server.address().port

    console.log("App listening at http://%s at port %s",host,port)
});