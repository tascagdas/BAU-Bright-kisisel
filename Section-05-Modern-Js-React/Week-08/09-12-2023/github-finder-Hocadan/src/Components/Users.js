import React, { useContext } from 'react'
import { AppContext } from '../Contexts/AppContext'
import { Container, Row } from 'react-bootstrap';
import User from './User';

const Users = () => {
    const context = useContext(AppContext);
    return (
        <>
            <Container>
                <Row>
                    {context.users.map(user => <User key={user.id} user={user} />)}
                </Row>
            </Container>
        </>
    )
}

export default Users