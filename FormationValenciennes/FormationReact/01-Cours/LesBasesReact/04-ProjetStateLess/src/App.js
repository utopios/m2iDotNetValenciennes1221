import { useEffect, useState } from 'react';
import Banner from './components/BannerComponent/Banner';
import NavBar from './components/NavBarComponent/NavBar';
import Footer from './components/FooterComponent/Footer';
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';



function App() {
  //const [cart,updateCart] = useState([]);
  const savedCard = localStorage.getItem('cart')

  const [cart,updateCart] = useState(savedCard?JSON.parse(savedCard):[]);

  useEffect(()=>{
    localStorage.setItem('cart', JSON.stringify(cart))
  },[cart])

  return (
    <div className="App">
      <Banner/>
      <NavBar cart={cart} updateCart = {updateCart}/>
      <Footer/>
    </div>
  );
}

export default App;
