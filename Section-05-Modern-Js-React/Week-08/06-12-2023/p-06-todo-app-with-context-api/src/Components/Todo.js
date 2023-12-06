import React, { useContext } from 'react'
import { TodoContext } from '../Contexts/TodoContext'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPenToSquare, faTrashCan } from '@fortawesome/free-regular-svg-icons';
const Todo = ({ task }) => {
    const context = useContext(TodoContext);
    return (
        <div>
            <li className={task.isCompleted ? "d-flex justify-content-between list-group-item rounded-2 mb-1 text-decoration-line-through text-success align-items-center" : "d-flex align-items-center justify-content-between list-group-item rounded-2 mb-1"}>
                <div onClick={() => { context.toggleComplete(task.id) }} className='w-75' role='button'>
                    {task.desc}
                </div>
                <div>
                    <button className='btn btn-warning btn-sm me-2' onClick={() => { context.toggleEditing(task.id) }}><FontAwesomeIcon className='fs-4 text-white' icon={faPenToSquare} /></button>
                    <button className='btn btn-danger btn-sm' onClick={() => { context.deleteTask(task.id) }}><FontAwesomeIcon className='fs-4' icon={faTrashCan} /></button>

                </div>

            </li>

        </div >
    )
}

export default Todo