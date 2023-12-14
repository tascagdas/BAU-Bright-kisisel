import React, { useContext, useEffect, useState } from 'react'
import { Button, Container, Form, InputGroup } from 'react-bootstrap'
import { AppContext } from '../Contexts/AppContext';

const SearchForm = () => {

    const context = useContext(AppContext);
    const [keyword, setKeyword] = useState("");

    const handleSubmit = (e) => {
        e.preventDefault();
        context.searchUsers(keyword);
        context.setIsClearButtonShow(false);
    };

    useEffect(() => {
        context.setUsers([]);
        context.setIsClearButtonShow(false);

    }, []);

    return (
        <>
            <Container className='py-4'>
                <Form onSubmit={handleSubmit}>
                    <InputGroup>
                        <Form.Control value={keyword} onChange={(e) => setKeyword(e.target.value)} placeholder='Please enter username...'>

                        </Form.Control>
                        <Button type='submit' variant='danger'>Search</Button>
                    </InputGroup>
                    {context.isClearButtonShow &&
                        <div className='d-grid mt-4'>
                            <Button onClick={() => { context.setUsers([]); setKeyword(""); context.setIsClearButtonShow(false) }} variant='warning'>Clear</Button>
                        </div>
                    }
                </Form>
            </Container>
        </>
    );
};

export default SearchForm