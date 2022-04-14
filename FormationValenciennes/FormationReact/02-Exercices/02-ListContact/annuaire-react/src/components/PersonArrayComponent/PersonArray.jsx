import React from 'react';
import './PersonArray.css';

const PersonArray = ({ PersonList, updatePersonList }) => {
    return (
        <table className="table table-striped">

            <thead>
                <tr>
                    <th scope="col">#</th>
                    <th scope="col">Nom</th>
                    <th scope="col">Prénom</th>
                    <th scope="col">Email</th>
                    <th scope="col">Téléphone</th>
                </tr>
            </thead>
            <tbody>
                {
                    PersonList.map((toto, index) => (
                        <tr key={index}>
                            <th scope="row">{index + 1}</th>
                            <td>{toto.nom}</td>
                            <td>{toto.prenom}</td>
                            <td>{toto.email}</td>
                            <td>{toto.telephone}</td>
                        </tr>
                    ))
                }

            </tbody>
        </table>
    );
};

export default PersonArray;