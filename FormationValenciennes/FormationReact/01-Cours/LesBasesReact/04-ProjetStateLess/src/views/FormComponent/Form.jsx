import React from 'react';
import { useState } from 'react';
import './form.style.css';



const Form = () => {
    function handleSumit(e) {
        e.preventDefault();
        alert(e.target['nom'].value)
    }

    const [nom, setNom] = useState();
    const [prenom, setPrenom] = useState();
    const [email, setEmail] = useState();
    const [type, setType] = useState();
    const [text, setText] = useState();
    return (
        <div className="container">

            <h1>Les Formulaires en react </h1>
            <div className='card'>
                <form onSubmit={handleSumit}>
                    <div className='form-control formulaire'>
                        <div className="mb-3">
                            <label htmlFor="nom">Nom : </label>
                            <input type="text" name="nom" id="nom" onChange={(e) => setNom(e.target.value)} className="form-control" />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="prenom">Prénom : </label>
                            <input type="text" name="prenom" id="prenom" onChange={(e) => setPrenom(e.target.value)} className="form-control" />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="email">Email : </label>
                            <input type="email" name="email" id="email" onChange={(e) => setEmail(e.target.value)} className="form-control" />
                        </div>
                        <select className='form-select' onChange={(e) => setType(e.target.value)} >
                            <option selected disabled>Choississez le type de demande</option>
                            <option value="1">Renseignement à propos d'une formation</option>
                            <option value="2">Demande de rendez-vous</option>
                            <option value="3">Autre demandes...</option>
                        </select>
                        <div className="mb-3">
                            <label htmlFor="FormTextArea">Rédigez votre demande : </label>
                            <textarea name="FormTextArea" id="FormTextArea" rows="30" className='form-control' onChange={(e) => setText(e.target.value)} />
                        </div>
                        <button type="submit" className='btn btn-secondary form-control'>Valider</button>
                    </div>
                </form>
            </div>
            <div className='card'>
                <div className='form-control formulaire'>
                    <div className="mb-3">
                        <label htmlFor="nom">Nom : </label>
                        <input type="text" name="nom" id="nom" placeholder={nom} className="form-control" />
                    </div>
                    <div className="mb-3">
                        <label htmlFor="prenom">Prénom : </label>
                        <input type="text" name="prenom" id="prenom" placeholder={prenom} className="form-control" />
                    </div>
                    <div className="mb-3">
                        <label htmlFor="email">Email : </label>
                        <input type="text" name="email" id="email" placeholder={email} className="form-control" />
                    </div>
                    <select className='form-select' value={type}  >
                        <option selected disabled>Choississez le type de demande</option>
                        <option value="1">Renseignement à propos d'une formation</option>
                        <option value="2">Demande de rendez-vous</option>
                        <option value="3">Autre demandes...</option>
                    </select>
                    <div className="mb-3">
                        <label htmlFor="FormTextArea">Rédigez votre demande : </label>
                        <textarea name="FormTextArea" id="FormTextArea" rows="30" placeholder={text} className='form-control' />
                    </div>
                </div>

            </div>
        </div>
    );
};

export default Form;