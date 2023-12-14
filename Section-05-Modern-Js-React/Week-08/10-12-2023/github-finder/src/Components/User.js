import React, { useContext } from 'react'
import { Card, Col } from 'react-bootstrap'
import { NavLink } from 'react-router-dom'
import { AppContext } from '../Contexts/AppContext';

const User = ({ user }) => {
    const context = useContext(AppContext);
    const lgCol = context.user.login ? 4 : 2
    const mdCol = context.user.login ? 6 : 3
    const smCol = context.user.login ? 12 : 6


    return (
        <>
            <Col lg={lgCol} md={mdCol} sm={smCol} className='mb-2'>
                <Card>
                    <Card.Img src={user.avatar_url} />
                    <Card.Body>
                        <Card.Title>
                            <h6 className='display-6 fs-6 fw-normal text-secondary'>{user.login}</h6>
                        </Card.Title>
                        <a href={user.html_url} className='btn btn-primary  mt-2 btn-sm' target='blank'>Profile</a>
                        <button type='button' onClick={() => context.getUser(user.login)} className='btn btn-link btn-sm'>Details</button>
                    </Card.Body>
                </Card>
            </Col>
        </>
    )
}

export default User