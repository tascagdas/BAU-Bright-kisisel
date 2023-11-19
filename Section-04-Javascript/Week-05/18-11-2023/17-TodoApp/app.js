"use strict";
const txtTaskDescription = document.getElementById("txt-task-description");
const btnAddTask = document.getElementById("btn-add-task");
const taskList = document.getElementById("task-list");

let taskListArray = [
    { id: 1, taskDescription: "Netflix izle", status: "completed" },
    { id: 2, taskDescription: "Pilavı unutma", status: "pending" },
    { id: 3, taskDescription: "Eceye kendini affettir", status: "pending" },
    { id: 4, taskDescription: "Pazar günü için toplantı planla", status: "completed" },
    { id: 15, taskDescription: "Çok kilo verdin, yemek yemeyi unutma!", status: "pending" }
];


btnAddTask.addEventListener("click", function (event) {
    event.preventDefault();//ilgili olayın default davranışlarını iptal ediyor.
    let value = txtTaskDescription.value.trim();
    if (value != "") {
        let id = taskListArray.length == 0 ? 1 : taskListArray[taskListArray.length - 1].id + 1;
        taskListArray.push(
            {
                "id": id,
                "taskDescription": value,
                "status": "pending"
            }
        );
        console.log(taskListArray);
    } else {
        alert("Lütfen görev açıklamasını boş bırakmayınız.")
    }
    txtTaskDescription.value = "";
    txtTaskDescription.focus();
});

function displayTasks() {
    // Bu function, her ihtiyaç duyulduğunda tüm görevleri yeniden okuyup ekranda göstermek için kullanılacak.
    taskList.innerHTML = "";
    if (taskListArray.length == 0) {
        taskList.innerHTML = `<div class="alert alert-warning mb-0">Tanımlı görev bulunmamaktadır.</div>`;
    } else {

    }
}

displayTasks();
