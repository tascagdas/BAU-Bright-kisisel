import ProductsContainer from "../ProductContainer/ProductsContainer";
import "./Content.css";

import React from "react";

function Content() {
  return (
    <>
      <h1 className="Title">Hosgeldiniz</h1>
      <div className="Text-Container">
        <p className="Text">
          lorem asjfhafj af asdfafsdfg wserdgtwrkl;whjgluiwr piwehowhiu
          ouegiouqwgef gyquiegfryi ieqwtgfio ajksdlfajklshakl aaljsflajs
        </p>
      </div>
      <button type="button" className="Btn-Detail">
        Detay
      </button>
      <ProductsContainer />
    </>
  );
}

export default Content;

// import React, { Component } from 'react'

// export class Content extends Component {
//   render() {
//     return (
//       <div>Content</div>
//     )
//   }
// }

// export default Content
