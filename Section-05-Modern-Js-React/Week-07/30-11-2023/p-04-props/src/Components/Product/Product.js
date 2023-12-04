import React from 'react'

function Product({ product }) {
    return (
        <>
            <h1>{product.name}</h1>
            <p>{product.desc}</p>
            <p>{product.price}</p>
        </>
    )
}

export default Product;