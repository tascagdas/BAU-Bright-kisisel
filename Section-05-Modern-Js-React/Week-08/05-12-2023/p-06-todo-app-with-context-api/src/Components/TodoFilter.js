import React from 'react'

const TodoFilter = () => {


    return (
        <>
            <div className="btn-group mb-4" role="group">
                <button type="button" className="btn btn-outline-primary" value={"all"}>All</button>
                <button type="button" className="btn btn-outline-primary" value={"pending"}>Pending</button>
                <button type="button" className="btn btn-outline-primary" value={"completed"}>Completed</button>
            </div>
        </>
    )
}
export default TodoFilter