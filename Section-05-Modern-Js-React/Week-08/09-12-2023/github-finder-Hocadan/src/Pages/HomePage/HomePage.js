import React from 'react';
import { Container } from 'react-bootstrap';
import Users from '../../Components/Users';

const HomePage = () => {
    return (
        <>
            <Container fluid>
                <div style={{ height: "80vh" }} className='d-flex justify-content-center align-items-center flex-column'>
                    <h1 className='display-4 text-primary text-center'>Welcome!</h1>
                    <p className='display-2 text-success text-center'>Github Finder</p>
                </div>
            
            </Container>
        </>
    )
}

export default HomePage;