import React, { PureComponent } from 'react';

class FormTodo extends PureComponent {
    constructor(props){
        super(props)
        this.state = {
            contentTask : undefined
        }
    }

    submit = (e) => {
        e.preventDefault();
        if (this.state.contentTask != undefined)
        {
            this.props.addTodo(this.state.contentTask)
            this.setState({
                contentTask : undefined
            })
        }
    }

    ChangeTask = (e) => {
        this.setState({
            contentTask : e.target.value
        })
    }


    render() {
        return (
            <form className='row m-1' onSubmit={this.submit}>
                <div className="col-9">
                    <input type="text" onChange={this.ChangeTask} className='form-control' placeholder='Contenu de la todo' />
                </div>
                <div className="col-3">
                    <button type='submit' className='form-control btn btn-secondary'>Ajouter</button>
                </div>
            </form>
        );
    }
}

export default FormTodo;