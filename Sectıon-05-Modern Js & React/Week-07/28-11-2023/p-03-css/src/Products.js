import { Container, Row, Col, Nav, Navbar, Image, Button, Card } from "react-bootstrap";
import React from 'react'
import Product from "./Product";

function Products() {
    return (
        <Container>
            <Row>
                <Product productName={"Iphone 14"} productImageUrl={"https://picsum.photos/id/132/100/180"} />
                <Product productName={"Vestel Buzdolabi"} productImageUrl={"https://picsum.photos/id/136/100/180"} />
                <Product productName={"Logitech Mouse"} productImageUrl={"https://picsum.photos/id/237/100/180"} />
                <Product productName={"Macbook Pro"} productImageUrl={"https://picsum.photos/id/37/100/180"} />
                <Product productName={"Linak Masa"} productImageUrl={"https://picsum.photos/id/36/100/180"} />

            </Row>

        </Container>
    )
}

export default Products