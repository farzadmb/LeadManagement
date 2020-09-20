import React from 'react';
import './style.css';

const Actions = (props) => {
    const { lead } = props;
    const { status } = lead;

    if (status === 1) {
        return null;
    }

    return (
        <div className='action-list'>
            <div>
                <button className='active-button'>Accept</button>
            </div>
            <div>
                <button className='deactive-button'>Decline</button>
            </div>
        </div>
    );
};

export default Actions;