import React, { useState } from 'react'
import { TodoContext } from '../Contexts/TodoContext';
import TodoAddForm from './TodoAddForm';
import TodoContainer from './TodoContainer';
import { v4 as idGenerate } from 'uuid';

const TodoWrapper = ({ tasks }) => {
    const [taskList, setTaskList] = useState(tasks);
    const [filterMode, setFilterMode] = useState("all");


    const addTask = _desc => {
        setTaskList(
            [...taskList, {
                id: idGenerate(),
                desc: _desc,
                isCompleted: false,
                isEditing: false

            }]
        )
    }
    const clearAll = () => {
        setTaskList([])
    }

    const deleteTask = (id) => {
        setTaskList(
            taskList.filter(task => task.id != id)
        )
    }

    const toggleEditing = (id) => {
        setTaskList(
            taskList.map(task => task.id === id ? { ...task, isEditing: true } : { ...task, isEditing: false })
        )
    }

    const toggleComplete = id => {
        setTaskList(
            taskList.map(task => task.id === id ? { ...task, isCompleted: !task.isCompleted } : task)
        )
    }

    const updateTask = (id, _desc) => {
        setTaskList(
            taskList.map(task => task.id === id ? { ...task, desc: _desc, isEditing: !task.isEditing } : task)
        )
    }

    return (
        <TodoContext.Provider value={{ taskList, addTask, toggleComplete, deleteTask, toggleEditing, updateTask, clearAll, setFilterMode }} >
            <div className='container w-50 py-5'>
                <TodoAddForm />

                <TodoContainer />
            </div>
        </TodoContext.Provider>
    )
}

export default TodoWrapper