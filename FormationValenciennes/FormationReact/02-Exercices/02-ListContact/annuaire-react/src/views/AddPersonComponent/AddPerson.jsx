import React from 'react';
import {useState} from 'react';
import './AddPerson.css';

const AddPerson = ({ PersonList, updatePersonList }) => {
    /**
     * States
     */
    const [nom, setNom] = useState('');
    const [prenom, setPrenom] = useState('');
    const [email, setEmail] = useState('');
    const [telephone, setTelephone] = useState('');
    /**
     * Function()
     */
    function addToList(nom, prenom, email, telephone) {
        updatePersonList([...PersonList, {nom, prenom, email, telephone}]);
        alert(`${nom} ${prenom} a été ajouté`);
    }

    /**
     * JSX
     */
    return (
        <div className='container'>
            <h1>Ajouter un contact</h1>
            <div className='card'>
                <form>
                    <div className='form-control formulaire'>
                        <div className="mb-2">
                            <label htmlFor="nom">Nom : </label>
                            <input type="text" name="nom" id="nom" onChange={(e) => setNom(e.target.value)} className="form-control" />
                        </div>
                        <div className="mb-2">
                            <label htmlFor="prenom">Prénom : </label>
                            <input type="text" name="prenom" id="prenom" onChange={(e) => setPrenom(e.target.value)} className="form-control" />
                        </div>
                        <div className="mb-2">
                            <label htmlFor="email">Email : </label>
                            <input type="email" name="email" id="email" onChange={(e) => setEmail(e.target.value)} className="form-control" />
                        </div>
                        <div className="mb-2">
                            <label htmlFor="telephone">Téléphone : </label>
                            <input type="text" name="telephone" id="telephone" onChange={(e) => setTelephone(e.target.value)} className="form-control" />
                        </div>

                        <button className='btn btn-secondary form-control' onClick={() => addToList(nom, prenom, email, telephone)}>Ajouter</button>
                    </div>
                </form>
            </div>
        </div>
    );
};

export default AddPerson;