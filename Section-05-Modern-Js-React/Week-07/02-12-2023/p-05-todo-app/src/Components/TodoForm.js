import React, { useState } from 'react'

const TodoForm = ({ addTodo, todos }) => {
    const [value, setValue] = useState("")

    const handleSubmit = (e) => {
        e.preventDefault();
        if (value) {
            addTodo(value);
            setValue("");
            e.target.firstChild.focus();
        }
    }

    return (
        <>
            <form onSubmit={handleSubmit} className='TodoForm'>
                <input onChange={(e) => { setValue(e.target.value) }} type="text" placeholder='What to do?' className='TodoInput' value={value} />
                <button type='submit' className='TodoBtn'>Add Task</button>
            </form>
        </>
    )
}

export default TodoForm