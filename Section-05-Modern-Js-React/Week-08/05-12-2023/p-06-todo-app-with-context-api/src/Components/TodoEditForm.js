import React, { useState, useContext } from 'react'
import { TodoContext } from '../Contexts/TodoContext';

const TodoEditForm = ({ task }) => {
    const context = useContext(TodoContext);

    const [desc, setDesc] = useState(task.desc);

    const handleSubmit = (e) => {
        e.preventDefault();
        if (desc) {
            context.updateTask(task.id, desc);
        } else {
            alert("Can not add empty task.")
        }
    }

    return (

        <form onSubmit={handleSubmit}>
            <div className="input-group mb-3">
                <input onChange={(e) => { setDesc(e.target.value) }} value={desc} type="text" className="form-control bg-light" placeholder="What Todo?" aria-describedby="button-addon2" />
                <button className="btn btn-success" type="submit" id="btn-add-task">Update</button>
            </div>
        </form>

    )
}

export default TodoEditForm