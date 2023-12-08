import React from 'react'
import { Container } from 'react-bootstrap'

const HomePage = () => {
    return (
        <>
            <Container fluid className=''>
                <div style={{ height: '88vh' }} className=' d-flex justify-content-center align-items-center flex-column'>
                    <h1 className='display-4 text-secondary text-center'>Welcome!</h1>
                    <p className='display-2 text-secondary-emphasis text-center'>Github User Finder</p>
                </div>
            </Container>
        </>
    )
}

export default HomePage