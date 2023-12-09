import React, { useContext, useEffect } from 'react'
import { useParams } from 'react-router-dom'
import { AppContext } from '../../Contexts/AppContext';
import { Card, CardBody, Col, Container, ListGroup, Row } from 'react-bootstrap';
import UserRepo from '../../Components/UserRepo';

const UserDetailsPage = () => {
    const context = useContext(AppContext);
    const { login } = useParams();
    useEffect(() => {
        context.getUser(login);
        context.getRepos(login);
    }, [])
    return (
        <>
            <Container className='w-75 mt-4'>
                <Card>
                    <Card.Header className='display-6 text-primary'>
                        {context.user.name} ({context.user.login})
                    </Card.Header>
                </Card>
                <Card>
                    <Row className='mt-4 px-4'>
                        <Col xs={4}>
                            <Card.Img className='' src={context.user.avatar_url} />
                            <CardBody>
                                <Card.Title>Followers:</Card.Title>{context.user.followers}
                                <Card.Title className='mt-4'>Following:</Card.Title>{context.user.following}
                                <Card.Title className='mt-4'>Regiostration Date:</Card.Title>{context.user.created_at}
                                <Card.Title className='mt-4'>Last Seen:</Card.Title>{context.user.updated_at}
                            </CardBody>
                        </Col>
                        <Col xs={8}>
                            <Row>

                                <Col xs={12}>
                                    <Card.Header className='mt-4 text-secondary'>
                                        Repos:
                                    </Card.Header>
                                    <Card.Body>
                                        <ListGroup className='flex-row flex-wrap'>
                                            {context.userRepos.map(userRepo => <UserRepo key={userRepo.id} userRepoName={userRepo.name} userRepoUrl={userRepo.html_url} />)}
                                        </ListGroup>
                                    </Card.Body>
                                </Col>
                            </Row>





                        </Col>
                    </Row>
                </Card>
            </Container>
        </>
    )
}

export default UserDetailsPage