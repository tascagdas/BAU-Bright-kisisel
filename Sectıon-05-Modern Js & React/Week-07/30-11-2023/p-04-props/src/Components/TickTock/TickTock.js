import React from 'react'

function TickTock(props) {
    return (
        <>
            <h1>Hello React!</h1>
            <h3>firstName: {props.firstName} </h3>
            <h3>lastName: {props.lastName} </h3>
            <h3>Age: {props.age} </h3>

        </>
    )
}

export default TickTock