//RAFCE snippeti ile olusturuldu
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faPenToSquare, faTrash } from '@fortawesome/free-solid-svg-icons'
import React from 'react'

const Todo = ({ task, toggleComplete, deleteTask, editTodo }) => {


    const confirmFn = (id) => {
        let answer = window.confirm("Gorev silinecektir. Emin misiniz?")
        if (answer) {
            deleteTask(id);
        }
    }

    return (
        <>
            <div className='Todo'>
                <p onClick={() => { toggleComplete(task.id) }} className={task.completed ? "Completed TodoTask" : "TodoTask"}  >
                    {task.desc}
                </p>
                <div className='TodoButtons'>
                    <FontAwesomeIcon icon={faPenToSquare} onClick={() => { editTodo(task.id) }} />
                    <FontAwesomeIcon icon={faTrash} onClick={() => confirmFn(task.id)} />
                </div>

            </div >
        </>
    )
}

export default Todo