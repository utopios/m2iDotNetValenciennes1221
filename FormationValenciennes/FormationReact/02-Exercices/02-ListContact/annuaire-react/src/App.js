import { useState } from 'react';
import { ListPerson } from './datas/ListPerson';
import './App.css';

function App() {
  const [PersonList , updatePersonList] = useState(ListPerson);
  return (
    <div className="App">
      
    </div>
  );
}

export default App;
