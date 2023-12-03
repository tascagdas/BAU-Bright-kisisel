import React, { useState } from 'react'
import TodoForm from './TodoForm'
import { v4 as uuidv4 } from 'uuid';
import Todo from './Todo';
import TodoContainer from './TodoContainer';

const TodoWrapper = () => {
    //ekleme fonksiyonu
    let [todos, setTodos] = useState([]);
    const addTodo = todo => {

        setTodos([...todos, {
            id: uuidv4(),
            desc: todo,
            completed: false
        }]);
    };


    //tamamlandi durumu icin fonsiyon
    const toggleComplete = (id) => {
        setTodos(
            todos.map((todo) => todo.id == id ? { ...todo, completed: !todo.completed } : todo)
        );
    }
    //silme sonksiyonu

    const deleteTask = (id) => { setTodos(todos.filter((todo) => todo.id != id)) }


    // const deleteTaskAlt = (id) => {
    //     for (let i = 0; i < todos.length; i++) {
    //         const newTodos = []
    //         if (todos[i].id != id) {
    //             newTodos.push(todos[i]);
    //         }
    //     }
    // }



    return (
        <>
            <div className='TodoWrapper'>
                <h1>FS-2310-13 Todo App</h1>
                <TodoForm addTodo={addTodo} todos={todos} />
                <TodoContainer todos={todos} toggleComplete={toggleComplete} deleteTask={deleteTask} />




                {/* Buraya yerlestirecegimiz componenti yazmaya gittim gelicem. */}
            </div>
        </>
    )
}

export default TodoWrapper