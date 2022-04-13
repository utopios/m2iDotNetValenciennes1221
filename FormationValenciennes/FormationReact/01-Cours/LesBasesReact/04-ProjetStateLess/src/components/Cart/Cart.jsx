import React from 'react';
import { useState, useEffect } from 'react';
import './cart.style.css';

const Cart = ({ cart, updateCart }) => {
    // State isOpen pour connaitre l'état du panier
    const [isOpen, setIsOpen] = useState(false);

    // Calcul du montant du panier
    const Total = cart.reduce((acc,cours)=> acc + cours.amount * cours.price,0);

    // Propage le montant du panier dans l'onglet du navigateur
    useEffect(()=>{
        document.title=`Panier : ${Total}€`
    },[Total])

    // Retourne deux element en fonction du state isOpen
    return isOpen ? (
        <div className='relative'>
            <div className="cart-list over">
                {cart.length > 0 ?
                    <div>
                        <h2>Panier</h2>
                        <div className="inner-card">
                            {/* Affichage des formations présentes dans le panier */}
                            <div>
                                {
                                    cart.map(({name, price, amount},index)=>(
                                        <div key={`${name}-${index}`}>
                                            {name} : {price}€ x {amount}    
                                            <hr/>
                                        </div>
                                    ))
                                }
                            </div>

                            <h3>Total : {Total}€</h3>

                        </div>
                        <button className='btn btn-secondary spaceTop' onClick={()=>updateCart([])}>Vider le panier</button>
                    </div>    
                    :
                    <div className='vide'>Votre panier est vide</div>
            }
            <button className='btn btn-secondary spaced' onClick={()=>setIsOpen(false)}>fermer le panier</button>
            </div>
        </div>
    ) 
    :
     (<button className='btn btn-secondary' onClick={()=>setIsOpen(true)}>Ouvrir le panier</button>);
};

export default Cart;