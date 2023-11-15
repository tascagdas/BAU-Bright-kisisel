let courseName = "Fullstack Web Developer Egitimi";
let result;


result = courseName.toLowerCase();
result = courseName.toLocaleLowerCase();
result = courseName.toLocaleUpperCase();
result = courseName.toUpperCase();


result = courseName.length;//property-ozellik
result = courseName[14];
result = courseName.slice(14, 23);

result = courseName.replace("Egitimi", "kursu");
result = courseName.trim();
result = courseName.trimStart();

result = courseName.indexOf("F");
result = courseName.split("");
result = courseName.startsWith("f")
result = courseName.endsWith("i")


console.log(result)



//indexof ile ilgili minik bir ornek:

// let message;
// let findedText;
// message = prompt("lutfen metin giriniz: ");
// findedText = prompt("lutfen arayacaginiz metni yada karakteri giriniz");
// result = message.indexOf(findedText);
// if (result == -1) {
//     alert(message + " icinde " + findedText + " bulunamamistir.");
// }
// else (alert("'" + message + "'" + " icinde '" + findedText + "' " + (result + 1) + ". sirada yer almaktadir."))

