"use strict"
// function Student() {
//     firstName = "";
//     lastName = "";
//     age = 0;
// };
// let student1 = new Student();
// student1.firstName = "cagdas";
// student1.lastName = "Tas";
// student1.age = 28;

// console.log(student1);

function Product(productName, productPrice) {
    this.productName = productName;
    this.productPrice = productPrice;
};

let p1 = new Product("iphone", 42300);
let p2 = new Product("Samsung Galaxy", 64500);
console.log(p1, p2);