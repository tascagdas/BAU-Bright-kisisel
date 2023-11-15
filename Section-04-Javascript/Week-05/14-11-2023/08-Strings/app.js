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



console.log(result)