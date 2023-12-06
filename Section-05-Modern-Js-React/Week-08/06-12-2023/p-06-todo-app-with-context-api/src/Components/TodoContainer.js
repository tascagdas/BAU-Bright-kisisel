import React, { useContext } from 'react'
import { TodoContext } from '../Contexts/TodoContext'
import Todo from './Todo';
import TodoEditForm from './TodoEditForm';
import TodoFilter from './TodoFilter';

const TodoContainer = () => {
    const context = useContext(TodoContext);
    return (
        <>
            <ul className='list-group'>
                {
                    context.taskList.map(task => {
                        if (context.filterMode == 'all') {
                            if (task.isEditing) {
                                return <TodoEditForm key={task.id} task={task} />
                            } else {
                                return <Todo key={task.id} task={task} />
                            }
                        } else {
                            if (task.isCompleted == context.filterMode) {
                                if (task.isEditing) {
                                    return <TodoEditForm key={task.id} task={task} />
                                } else {
                                    return <Todo key={task.id} task={task} />
                                }
                            }

                        }


                    })
                }
            </ul>

        </>
    )
}

export default TodoContainer