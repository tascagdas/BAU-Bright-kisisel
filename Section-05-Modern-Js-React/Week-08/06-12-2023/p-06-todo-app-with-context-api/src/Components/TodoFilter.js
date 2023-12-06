import React, { useContext } from 'react'
import { TodoContext } from '../Contexts/TodoContext'

const TodoFilter = () => {
    const context = useContext(TodoContext)

    return (
        <>
            <div className="btn-group mb-4" role="group">
                <button onClick={() => { context.setFilterMode('all') }} type="button" className="btn btn-outline-primary" >All</button>
                <button onClick={() => { context.setFilterMode(false) }} type="button" className="btn btn-outline-warning" >Pending</button>
                <button onClick={() => { context.setFilterMode(true) }} type="button" className="btn btn-outline-success">Completed</button>
            </div>

        </>
    )
}
export default TodoFilter