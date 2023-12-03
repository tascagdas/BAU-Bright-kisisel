import React from 'react'
import Todo from './Todo'

const TodoContainer = ({ todos, toggleComplete, deleteTask }) => {
    return (
        <>
            <div className='TodoContainer'>
                {
                    todos.map((todo) => {
                        return <Todo
                            key={todo.id}
                            task={todo}
                            toggleComplete={toggleComplete}
                            deleteTask={deleteTask}
                        />
                    }
                    )
                }
            </div>
        </>
    )
}

export default TodoContainer