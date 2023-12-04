
// let fullName = ["Kemal", "Akademi"];
// // let firstName = fullName[0];
// // let lastName = fullName[1];

// let [firstName, lastName] = fullName;
// console.log(firstName+lastName);

// let fullName = "Mustafa Kemal Ataturk";
// let [name1, name2, name3] = fullName.split(" ");
// console.log(name1);
// console.log(name2);
// console.log(name3);


// let userInfo = ["enginniyazi", "Engin Niyazi", "Ergul", 48, "Istanbul", "Turkiye"];
// let [nick, firstName, lastName, age, ...address] = userInfo;
// let address2 = address.join("/");
// console.log(nick, firstName, lastName, age, address2);

let product = {
    productName: "Adidas",
    price: "2750",
    model: "Runner2023",
    color: "red"
};
let pName = product.productName;
// console.log(pName);
// console.log(product.price);

let { productName, price, model, color, size } = product;

product.color = "yellow";
product.size = "XL"
console.log(productName);
console.log(price);
console.log(model);
console.log(color);
console.log(size);


