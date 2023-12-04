import React from "react";
import "./ProductsContainer.css";
import Product from "../Product/Product";

function ProductsContainer() {
  return (
    <>
      <div className="Products">
    <Product />
    <Product />
    <Product />
    <Product />
    <Product />

      </div>
    </>
  );
}

export default ProductsContainer;
