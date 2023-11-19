"use strict";
const txtTaskDescription = document.getElementById("txt-task-description");
const btnAddTask = document.getElementById("btn-add-task");
const taskList = document.getElementById("task-list");
const btnClearAll = document.getElementById("btn-clear-all");
const filters = document.querySelectorAll("#filters span");

let isEditMode = false; // eger bu degisken false ise yeni kayit modundayiz, true ise duzenleme modundayiz.

let editedTaskId; //o anda hangi gorev duzenleniyor ise uygulama boyunca gecerli olacak sekilde o gorevin id'sini tutmaya yarar.
let filterMode = "all";
let taskListArray = [];

//btnAddTask elementine click ayapildiginda calisacak fonksiyonun adi addTask'dir. 
btnAddTask.addEventListener("click", addTask);

//btnClearAll elementine click yapildiginda caliscak fonks. clearAll dur
btnClearAll.addEventListener("click", clearAll);

//Yeni gorev ekleyen fonsiyon
function addTask(event) {
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
        displayTasks(filterMode);
        setTasks();
    } else {
        alert("Lütfen görev açıklamasını boş bırakmayınız.")
    }
    txtTaskDescription.value = "";
    txtTaskDescription.focus();
};

// Bu function, her ihtiyaç duyulduğunda tüm görevleri yeniden okuyup ekranda göstermek için kullanılacak.
function displayTasks(filter) {

    taskList.innerHTML = "";
    if (taskListArray.length == 0) {
        taskList.innerHTML = `<div class="alert alert-warning mb-0">Tanımlı görev bulunmamaktadır.</div>`;
    } else {

        for (const task of taskListArray) {
            if (filter == "all" || filter == task.status) {
                let completed = task.status == "completed" ? "checked" : "";
                let taskLi = `
            <li class="task list-group-item" id="${task.id}">
                <div class="form-check d-flex justify-content-between align-items-center">
                    <input onclick="updateStatus(this);" type="checkbox" id="${task.id}" class="form-check-input" ${completed}>
                    <div class="input-group">
                        <input id="${task.id}" class="form-control ${completed}" type="text" value="${task.taskDescription}"
                            disabled />
                        <button onclick="editTask(this);" id="${task.id}" class="btn btn-warning"><i class="fa-solid fa-pen-to-square"></i></button>
                        <button onclick="deleteTask(this);" id="${task.id}" class="btn btn-danger"><i class="fa-solid fa-trash"></i></button>
                    </div>
                </div>
            </li>
        `;
                taskList.insertAdjacentHTML("beforeend", taskLi);
            };


        };
    };
};

//Task update (tamamlandi/devam ediyor)islemini yapan fonksiyon
function updateStatus(activeTask) {
    let newStatus = activeTask.checked == true ? "completed" : "pending";
    for (const task of taskListArray) {
        if (activeTask.id == task.id) {
            task.status = newStatus;
            break;
        }

    }
    setTasks();

    displayTasks(filterMode);

};
//ODEV bir texte odaklanildiginda icindeki metinin sonuna yada secili halde odaklanmanin yolu?

// Ilgili gorevin duzenlenmesini yapan fonksiyon
function editTask(clickedButton) {
    editedTaskId = clickedButton.id;
    let editedTask = clickedButton.previousElementSibling;
    let checked;
    for (const task of taskListArray) {
        if (task.id == editedTaskId) {
            checked = task.status;
        }

    }
    if (!isEditMode) {


        editedTask.removeAttribute("disabled");
        if (checked == "completed") editedTask.classList.remove("checked");
        // editedTask.classList.remove("checked");
        clickedButton.classList.remove("btn-warning");
        clickedButton.classList.add("btn-primary");
        // clickedButton.firstElementChild.classList.remove("fa-pen-to-square");
        // clickedButton.firstElementChild.classList.remove("fa-solid");
        // clickedButton.firstElementChild.classList.add("fa-regular");
        // clickedButton.firstElementChild.classList.add("fa-circle-check");
        clickedButton.innerHTML = `<i class="fa-regular fa-circle-check"></i>`
        editedTask.focus();
        isEditMode = true;
    } else {
        editedTask.setAttribute("disabled", "disabled");
        clickedButton.classList.remove("btn-primary");
        clickedButton.classList.add("btn-warning");
        clickedButton.innerHTML = `<i class="fa-solid fa-pen-to-square"></i>`;
        for (const task of taskListArray) {
            if (editedTaskId == task.id) {
                task.taskDescription = editedTask.value;
                break;
            }
        }
        isEditMode = false;
        setTasks();
        displayTasks(filterMode);

    }
};

//Ilgili gorevi siler
function deleteTask(clickedButton) {
    let deletedTaskId = clickedButton.id;
    let deletedTask = taskListArray.filter(function (task) {
        if (deletedTaskId == task.id) return true;
    });
    let deletedTaskDescription = deletedTask[0].taskDescription;
    let answer = confirm(`'${deletedTaskDescription}' gorevi silinecektir!`);
    if (answer) {
        let index = taskListArray.indexOf(deletedTask[0]);
        taskListArray.splice(index, 1);
        setTasks();
        displayTasks(filterMode);
        alert('Silme islemi basariyla gerceklesmistir.');
    }
};

//Tum Gorevleri siler
function clearAll() {
    let answer = confirm("Tum gorevler silinecektir!");
    if (answer) {
        // taskListArray = [];
        taskListArray.splice(0);
        setTasks();
        displayTasks(filterMode);
    }
};

// filters icindeki spanlara click eventleri atar.
function assignSpansEvents() {
    for (const span of filters) {
        span.addEventListener("click", function () {
            let activeSpan = document.querySelector("span.active");
            activeSpan.classList.remove("active");
            span.classList.add("active");
            filterMode = span.id;
            displayTasks(filterMode);
        });
    };
};

//Localstorage deki datamizi okuyupp dizimizin icine aktaracak.
function getTasks() {
    let TaskListItem = localStorage.getItem("TaskList");
    // Task'lerimiz Localstorage'de TaskList adinda bir key'in icinde tutulacak.
    if (TaskListItem != null) {
        taskListArray = JSON.parse(TaskListItem);
    }
};

function setTasks() {
    localStorage.setItem("TaskList", JSON.stringify(taskListArray));
};

getTasks();
assignSpansEvents();
displayTasks(filterMode);

// Arastirma ODEV: Gorev adina tikladigimizda da completed yada pending seklinde status degisimi yapma