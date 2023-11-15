let result;

result = parseInt(10.7);
result = parseInt("10.4sad");

result = parseFloat("101.56sadddad");

let num = 10.37853;
result = parseFloat(num.toFixed(4));
result = num.toFixed(3);
result = num.toPrecision(4);

result = Math.PI;
result = Math.round(2.4179238120312083490183);
result = Math.round(2.5);
result = Math.ceil(2.1);
result = Math.floor(2.9);
result = Math.round()

result = Math.pow(5, 2);
result = Math.pow(2, 6);
result = Math.sqrt(25);
result = Math.sqrt(64);

result = Math.abs(-123.23);
result = Math.min(2, 4, 3, 6, 7);
result = Math.max(3, 4, 5, 2, 7, 9);

result = Math.random();
result = parseInt(Math.random() * 1000000);



console.log(result, typeof result);
