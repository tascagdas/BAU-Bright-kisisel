const http = require('node:http');
const fs = require('node:fs')

const server = http.createServer((request, response) => {
    if (request.url == "/") {
        fs.readFile("views/index.html", (err, html) => {
            response.writeHead(200, { 'content-type': 'text/html' });
            response.write(html);
            response.end();
        })
    } else if (request.url == "/products") {
        fs.readFile("views/products.html", (err, html) => {
            response.writeHead(200, { 'content-type': 'text/html' });
            response.write(html);
            response.end();
        })
    } else if (request.url == "/categories") {
        fs.readFile("views/categories.html", (err, html) => {
            response.writeHead(200, { 'content-type': 'text/html' });
            response.write(html);
            response.end();
        })
    } else if (request.url == "/create" && request.method == "POST") {
        const data = [];
        request.on('data', (chunk) => {
            data.push(chunk);
        });
        request.on('end', () => {
            const result = Buffer.concat(data).toString();
            const parsedData = result.split('=')[1];
            fs.appendFile('products.txt', parsedData, (err) => {
                if (err) {
                    console.log(err);
                } else {
                    response.statusCode = 201;
                    response.setHeader("Location", "/products");
                    response.end();
                }
            });
        })


    } else if (request.url == "/create") {
        fs.readFile("views/create.html", (err, html) => {
            response.writeHead(200, { 'content-type': 'text/html' });
            response.write(html);
            response.end();
        })
    } else {
        fs.readFile("views/404.html", (err, html) => {
            response.writeHead(200, { 'content-type': 'text/html' });
            response.write(html);
            response.end();
        })
    }
});


server.listen(3000)
console.log("server http://localhost:3000 portundan ayaga kalktı")
