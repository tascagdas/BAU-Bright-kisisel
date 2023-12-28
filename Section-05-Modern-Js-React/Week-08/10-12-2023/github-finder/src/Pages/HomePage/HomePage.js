import React, { useContext, useEffect } from 'react'
import { Container } from 'react-bootstrap'
import Users from '../../Components/Users'
import { AppContext } from '../../Contexts/AppContext'
import { Link } from 'react-router-dom'

const HomePage = () => {
    const context = useContext(AppContext);
    useEffect(() => {
        context.setUsers([])
    }, [])
    return (
        <>
            <Container fluid className=''>
                <div style={{ height: '88vh' }} className=' d-flex justify-content-center align-items-center flex-column'>
                    <h1 className='display-4 text-secondary text-center'>Welcome!</h1>
                    <p className='display-2 text-secondary-emphasis text-center'>Github User Finder</p>
                    <Link to="/Search">Gitmek istedigim link</Link>
                </div>
            </Container>
        </>
    )
}

export default HomePage