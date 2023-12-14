import React from 'react'
import { ListGroup, ListGroupItem, NavLink } from 'react-bootstrap'

const UserRepo = ({ userRepoName, userRepoUrl }) => {
    return (
        <>
            <ListGroup.Item className='w-auto mx-1 ' action href={userRepoUrl} target="_blank">
                {userRepoName}
            </ListGroup.Item>
        </>
    )
}

export default UserRepo