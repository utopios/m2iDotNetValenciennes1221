import { useState } from 'react';
import { ListPerson } from './datas/ListPerson';
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';
import Navbar from './components/NavbarComponent/Navbar';

function App() {
  const [PersonList , updatePersonList] = useState(ListPerson);
  return (
    <div className="App">
      <Navbar PersonList={PersonList} updatePersonList={updatePersonList} />
    </div>
  );
}

export default App;
