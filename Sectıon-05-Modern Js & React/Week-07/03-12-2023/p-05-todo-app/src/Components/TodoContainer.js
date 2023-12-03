import React from 'react'
import Todo from './Todo'
import TodoEditForm from './TodoEditForm'

const TodoContainer = ({ todos, toggleComplete, deleteTask, editTodo, saveTodo }) => {
    return (
        <>
            <div className='TodoContainer'>
                {
                    todos.map((todo) => {


                        //buraya turnary if ilede yazilabilirdi ben asagidaki gibi yazdim.


                        if (todo.isEditing) {
                            return <TodoEditForm
                                task={todo}
                                key={todo.id}
                                saveTodo={saveTodo}
                            />
                        } else {
                            return <Todo
                                key={todo.id}
                                task={todo}
                                toggleComplete={toggleComplete}
                                deleteTask={deleteTask}
                                editTodo={editTodo}
                            />
                        }

                    }
                    )
                }
            </div>
        </>
    )
}

export default TodoContainer