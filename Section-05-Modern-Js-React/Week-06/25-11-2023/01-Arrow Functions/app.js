function selamVer() {
    console.log("Bu bir klasik fonksiyon")
};


const selamVer2 = () => {
    console.log("Bu bir arrow function")
};

const selamVer3 = (ad) => {
    console.log(`Merhaba ${ad}`)
};

const topla = (sayi1 = 0, sayi2 = 0, sayi3 = 0) => {
    return sayi1 + sayi2 + sayi3;
}



const selamVer4 = ad => {
    console.log(`Merhaba ${ad}`)
}



const topla2 = (sayi1, sayi2) => sayi1 + sayi2;

console.log(topla2(2,5));

// selamVer4("poyraz");

// selamVer3("cagdas");
// console.log(topla(null, 6, 4));

