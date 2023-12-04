import React, { useContext } from 'react'
import { TodoContext } from '../Contexts/TodoContext'
import Todo from './Todo';

const TodoContainer = () => {
    const context = useContext(TodoContext);
    return (
        <>
            <ul className='list-group'>
                {
                    context.taskList.map(task => <Todo key={task.id} task={task} />)
                }
            </ul>
        </>
    )
}

export default TodoContainer