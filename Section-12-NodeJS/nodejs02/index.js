// http işlemleri için http adındaki node module kullanılır.

const http = require('http');
const server = http.createServer((request, response) => {
    response.write('<h1> Hello Node Js Server! </h1>');
    response.end();
});


server.listen(3000);

console.log("Server 3000 numaralı porttan ayağa kalktı")
console.log("http://localhost:3000 yazarak ulaşabilirisiniz.")