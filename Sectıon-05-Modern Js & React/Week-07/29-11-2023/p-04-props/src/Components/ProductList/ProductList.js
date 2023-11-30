import React from 'react'
import Product from '../Product/Product.js'

function ProductList({ products }) {
    return (
        <>
            {
                products.map(p => <Product key={p.id} product={p} />)
            }
        </>
    )
}

export default ProductList;