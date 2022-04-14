import React, { PureComponent } from 'react';

class Notification extends PureComponent {
    render() {
        return (
            <div className='row'>
                <div className="col alert alert-primary">
                    {this.props.numberTask} {this.props.numberTask > 1 ? 'tasks' : 'task'}
                </div>
            </div>
        );
    }
}

export default Notification;