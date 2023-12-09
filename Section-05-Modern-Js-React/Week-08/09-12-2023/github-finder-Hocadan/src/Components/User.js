import React from 'react'
import { Card, Col } from 'react-bootstrap'
import { NavLink } from 'react-router-dom'

const User = ({ user }) => {
    return (
        <>
            <Col lg={2} md={3} sm={4} xs={6} className='mb-2'>
                <Card>
                    <Card.Img src={user.avatar_url} />
                    <Card.Body>
                        <Card.Title>
                            <h6 className='display-6 fs-6 fw-normal text-primary'>{user.login}</h6>
                        </Card.Title>
                        <a href={user.html_url} className='btn btn-primary btn-sm text-white mt-2' target='_blank'>Profile</a>
                        <NavLink to={`/getuser/${user.login}`} className="btn btn-link btn-sm" >
                            Details
                        </NavLink>
                    </Card.Body>
                </Card>
            </Col>
        </>
    )
}

export default User