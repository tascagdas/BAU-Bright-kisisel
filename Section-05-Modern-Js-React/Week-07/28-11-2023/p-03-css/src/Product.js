import React from 'react'
import { Col, Card, Button } from "react-bootstrap";

function Product({ productName, productImageUrl }) {
    return (
        <Col>
            <Card >
                <Card.Img variant="top" src={productImageUrl} />
                <Card.Body>
                    <Card.Title>{productName}</Card.Title>
                    <Card.Text>
                        Some quick example text to build on the card title and make up the
                        bulk of the card's content.
                    </Card.Text>
                    <Button variant="primary">Go somewhere</Button>
                </Card.Body>
            </Card>
        </Col>
    )
}

export default Product