import React, { useState } from 'react'
import TodoForm from './TodoForm'
import { v4 as uuidv4 } from 'uuid';

const TodoWrapper = () => {
    let [todos, setTodos] = useState([]);
    const addTodo = todo => {

        setTodos([...todos, {
            id: uuidv4(),
            desc: todo,
            completed: false
        }]);
    };
    return (
        <>
            <div className='TodoWrapper'>
                <h1>FS-2310-13 Todo App</h1>
                <TodoForm addTodo={addTodo} />
                {/* Buraya yerlestirecegimiz componenti yazmaya gittim gelicem. */}
            </div>
        </>
    )
}

export default TodoWrapper