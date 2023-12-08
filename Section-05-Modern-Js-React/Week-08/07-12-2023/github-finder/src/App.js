import { BrowserRouter, Route, Routes } from 'react-router-dom';
import './App.css';
import Header from './Components/Header';
import HomePage from './Pages/HomePage/HomePage.js'
import SearchPage from './Pages/SearchPage/SearchPage.js'
import Footer from './Pages/Footer/Footer.js';
import { AppContext } from './Contexts/AppContext.js';
import { useState } from 'react';
import { Axios } from 'axios';

function App() {
  const [users, setUsers] = useState([]);
  const searchUsers = (keyword) => {
    Axios
      .get('https://api.github.com/user')
      .then((second) => {
        // istegi tamamladiktan sonra buradaki kodlari calistir.
      })
  };
  return (
    <>
      <AppContext.Provider>
        <BrowserRouter>
          <Header />
          <Routes>
            <Route path='/' element={<HomePage />} />
            <Route path='/search' element={<SearchPage />} />
          </Routes>
          <Footer />
        </BrowserRouter>
      </AppContext.Provider>
    </>
  );
}

export default App;