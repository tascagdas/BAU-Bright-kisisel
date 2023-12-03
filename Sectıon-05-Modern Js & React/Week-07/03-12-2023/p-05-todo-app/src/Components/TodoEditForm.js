import React, { useState } from 'react';

const TodoEditForm = (task, saveTodo) => {
    const [value, setValue] = useState(task.desc);
    const handleSubmit = (e) => {
        e.preventDefault();
        saveTodo(task.id, value);
        //Buraya edit islemi yapilacak fonksiyonu cagiracagiz.
    }

    return (
        <>
            <form onSubmit={handleSubmit} className='TodoFrom'>
                <input
                    type="text"
                    value={value}
                    onChange={
                        (e) => { setValue(e.target.value) }
                    }
                    className='TodoInput'
                    placeholder='Waiting for input...'
                />
                <button type='submit' className='TodoBtn editSaveBtn'>Save</button>
            </form>
        </>
    )
}

export default TodoEditForm;