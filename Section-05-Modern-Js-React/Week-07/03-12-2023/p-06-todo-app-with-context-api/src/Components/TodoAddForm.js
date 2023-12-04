import React, { useState, useContext } from 'react'
import { TodoContext } from '../Contexts/TodoContext';

const TodoAddForm = () => {
    const context = useContext(TodoContext);

    const [desc, setDesc] = useState("");

    const handleSubmit = (e) => {
        e.preventDefault();
        if (desc) {
            context.addTask(desc);
            setDesc("");
            e.target.firstChild.firstChild.focus();
        } else {
            alert("Can not add empty task.")
        }
    }

    return (
        <div className='container-fluid g-0'>
            <h1 className='display-5 text-center my-5 text-primary'>Todo App with React</h1>
            <form onSubmit={handleSubmit}>
                <div className="input-group mb-3">
                    <input onChange={(e) => { setDesc(e.target.value) }} value={desc} type="text" className="form-control" placeholder="What Todo?" aria-describedby="button-addon2" />
                    <button className="btn btn-outline-secondary" type="submit" id="btn-add-task">Add Task</button>
                </div>
            </form>
        </div>
    )
}

export default TodoAddForm