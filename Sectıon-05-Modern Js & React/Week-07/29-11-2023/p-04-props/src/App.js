import './App.css';
import ProductList from './Components/ProductList/ProductList.js';
import TickTock from './Components/TickTock/TickTock';

function App() {
  // const firstName = "Cagdas"
  // const lastName = "Tas"
  // const age = 28;
  let products = [
    { id: 1, name: "iphone14", desc: "Koselı bir telefon", price: 43000 },
    { id: 2, name: "iphone15", desc: "Oval Bir telefon", price: 63000 },
    { id: 3, name: "iphone16", desc: "Soylentisi olan telefon", price: 83000 },
    { id: 4, name: "iphone17", desc: "Henuz var olmayan bir telefon", price: 103000 },
  ];
  return (
    <>
      <div>
        {/* <TickTock firstName={firstName} lastName={lastName} age={age} />
        <TickTock firstName={"engin"} lastName={"Ergul"} age={48} /> */}
        <ProductList products={products} />
      </div>
    </>
  );
};

export default App;
