import React from 'react'
import { Button, Container, Form, InputGroup } from 'react-bootstrap'

const SearchForm = () => {

    const handleSubmit = (e) => { 
        e.preventDefault();
        
     }

    return (
        <>
            <Container className='py-4'>
                <Form onSubmit={handleSubmit}>
                    <InputGroup>
                        <Form.Control placeholder='Please enter username...'>

                        </Form.Control>
                        <Button type='submit' variant='danger'>Search</Button>
                    </InputGroup>
                </Form>
            </Container>
        </>
    )
}

export default SearchForm