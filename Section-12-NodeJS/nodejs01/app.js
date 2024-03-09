// console.log("Hello Nodejs")



// let number1 = 50;
// let number2 = 40;
// let number3 = 60;
// let result = (number1 / 2) + number2 - number3;
// console.log(`İşlemin sonucu: ${result}`);



const products = [
    {
        id: 1,
        name: 'Iphone15',
        price: 89000
    },
    {
        id: 2,
        name: 'Iphone16',
        price: 130000
    },
    {
        id: 2,
        name: 'Iphone17',
        price: 150000
    },
    {
        id: 3,
        name: 'Iphone18',
        price: 210000
    }
]
let total = 0;


products.forEach(product => {
    total += product.price;
});

console.log(total)