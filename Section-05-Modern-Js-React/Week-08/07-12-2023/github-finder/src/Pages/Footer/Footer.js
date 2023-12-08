import React from 'react'
import { Alert, Container } from 'react-bootstrap'

const Footer = () => {
    return (
        <>

            <Alert variant='dark' className='text-center'>
                <Container>
                    Bu uygulama FS-2310-13 sinifi tarafindan gelistirilmistir.
                </Container>
            </Alert >

        </>
    )
}

export default Footer