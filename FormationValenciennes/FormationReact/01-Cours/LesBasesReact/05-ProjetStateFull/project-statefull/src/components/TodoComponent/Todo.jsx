import React, { PureComponent } from 'react';

class Todo extends PureComponent {

    constructor(props) {
        super(props)
        this.state = {
            edit: false,
            editTodoContent: undefined
        }
    }

    changeStatus = () => {        
        const status = this.props.todo.status === 'done' ? 'undone' : 'done'
        this.props.changeStatus(this.props.todo.id, status)
    }

    renderDoneOrUndoneButton = () => {
        console.log(this.props.todo);
        if (this.props.todo.status === 'done') {
            return (
                <button onClick={this.changeStatus} className="btn btn-success m-1">done</button>
            )
        }
        else {
            return (
                <button onClick={this.changeStatus} className="btn btn-danger m-1">undone</button>
            )
        }
    }

    validEditTodo = (e) => {
        e.preventDefault();
        this.props.editTodo(this.props.todo.id, this.state.editTodoContent)
        this.setState({
            edit: false
        })
    }

    EditTodo = () => {
        return (
            <form onSubmit={this.validEditTodo} className="col-6">
                <input onChange={(e) => {
                    this.setState({
                        editTodoContent: e.target.value
                    })
                }} type="text" className='form-control' defaultValue={this.props.todo.content} />
            </form>
        )
    }

    renderTodo = () => {
        if (!this.state.edit) {
            return this.renderContentTodo();
        }
        else {
            return this.EditTodo();
        }
    }

    renderContentTodo = () =>{
        return(
            <div onClick={this.changeStatus} className={this.props.todo.status === 'done'? 'btn col-6 text-success' : 'btn col-6 text-danger'}>
                {this.props.todo.content}
            </div>
        )
    }


    render() {
        return (
            <div className='row'>
               {this.renderTodo()}
               <div className="col-2">
                   {this.renderDoneOrUndoneButton()}
               </div>
               <div className="col-2">
                   <button className='btn btn-primary' onClick={ () => {
                       this.setState({
                           edit:true
                       })
                   }}>Edit</button>
               </div>
               <div className='col-2'>
                    <button className='btn btn-primary' onClick={() => {
                        this.props.deleteTodo(this.props.todo.id)
                    }}>delete</button>
                </div>
            </div>
        );
    }
}

export default Todo;