const http = require('node:http');

const server = http.createServer((request, response) => {
    if (request.url == "/") {
        response.write("<h1>Hoş geldiniz</h1>");
        response.end();
    }
    else if (request.url == "/product") {
        response.write("<h1>Ürünler</h1>");
        response.end();
    } else if (request.url == "/categories") {
        response.write("<h1>Kategoriler</h1>");
        response.end();
    } else {
        response.write("<h1>404 Not found!</h1>");
        response.end();
    }
});


server.listen(3000)
console.log("server http://localhost:3000 portundan ayaga kalktı")
