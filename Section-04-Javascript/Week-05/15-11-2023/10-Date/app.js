let result;
let now;


now = new Date();
result = now;
//getdate ayin kacinci gunu oldugunu veriyor
result = now.getDate();
//getday haftanin kacinci gunu oldugunu veriyor
result = now.getDay();
let newDate = new Date(2023, 0, 12); // aylar 0dan basliyor 0. ay ocak 1. ay subat 2. ay mart gibi... AYNI SEKILDE HAFTANIN ILK GUNU PAZAR OLUP 0 ile baslamakta
result = newDate.getDay();
result = now.getFullYear();
result = now.getHours();
result = now.getMinutes();
result = now.getTime();

result = new Date(1970, 0, 1, 2, 0, 0);
result = result.getTime();




console.log(result);



//kac gun yasadigimizi bulan kod

let birthDay = new Date(1995, 3, 16)
let milisecond = now - birthDay;

let second = milisecond / 1000;
let minute = second / 60;
let hour = minute / 60;
let day = hour / 24;


console.log(parseInt(day));