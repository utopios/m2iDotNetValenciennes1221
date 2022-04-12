import React from 'react';
import NavBar from '../components/NavBar';
import '../style/Home.style.css'

const Home = () => { 
    // logique métier du composant
    return (
        <div>
            <NavBar/>
            <h2>Home Components Works...!</h2>
            <img src="./img/logo192.png" alt="React-logo" />
            <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Ipsa tempore aliquam adipisci ratione molestias, suscipit officia enim voluptates soluta nesciunt rem quaerat corporis voluptatibus repellat hic, atque ex corrupti sequi!</p>
        </div>
    );
};

export default Home;