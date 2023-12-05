import React, { useContext } from 'react'
import { TodoContext } from '../Contexts/TodoContext'
const Todo = ({ task }) => {
    const context = useContext(TodoContext);
    console.log(task.desc)
    return (
        <div>
            <li className={task.isCompleted ? "d-flex justify-content-between list-group-item rounded-2 mb-1 text-decoration-line-through" : "d-flex justify-content-between list-group-item rounded-2 mb-1"}>
                <div>
                    {task.desc}
                </div>
                <div>
                    <button className='btn btn-warning btn-sm me-2'>E</button>
                    <button className='btn btn-danger btn-sm' onClick={() => { context.deleteTask(task.id) }}>D</button>

                </div>

            </li>

        </div >
    )
}

export default Todo