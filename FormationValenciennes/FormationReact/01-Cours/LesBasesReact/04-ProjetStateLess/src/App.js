import Banner from './components/BannerComponent/Banner';
import NavBar from './components/NavBarComponent/NavBar';
import Footer from './components/FooterComponent/Footer';
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';



function App() {
  return (
    <div className="App">
      <Banner/>
      <NavBar/>
      <Footer/>
    </div>
  );
}

export default App;
