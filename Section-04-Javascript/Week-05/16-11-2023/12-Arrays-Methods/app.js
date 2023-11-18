"use strict";
let students = ["aysen", "umay", "ceyda", "begum", "kofte", "heda"];

let result;

result = students.length;

result = students;
result = students.toString();
result = students.join(";");
result = result.split(";");

let products1 = ["urun1", "urun2", "urun3"];
let products2 = ["urun4", "urun5", "urun6"];

result = products1.concat(products2);

// students.push("zeynep");// sona eleman eklemek icin
// students.pop(); //sondan eleman silmek icin
// students.shift();//ilk elemani siler
// students.unshift("ece");//dizinin basina eleman ekler
// students[1]="haydar";// dizinin 1. elamanina atama yapmak icin (degistirmek)


//Students dizisindeki ceyda degerini tasiyan elemanin icerigini ece olarak degistirin

// let arananindex = students.indexOf("ceyda");
// students[arananindex] = "ece";




students.splice(students.indexOf("ceyda"), 1)
result = students;


console.log(result);
