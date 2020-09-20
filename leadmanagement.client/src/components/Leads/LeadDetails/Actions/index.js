import React from 'react';

import Price from '../Price';
import './style.css';

const Actions = (props) => {
    const { lead, onStatusUpdate } = props;
    const { status } = lead;

    if (status !== 0) {
        return null;
    }

    return (
        <div className='action-list'>
            <div>
                <button className='active-button' onClick={() => onStatusUpdate(lead.id, 1)}>Accept</button>
            </div>
            <div>
                <button className='deactive-button' onClick={() => onStatusUpdate(lead.id, 2)}>Decline</button>
            </div>
            <div>
                <Price price={lead.price} bold />
            </div>
        </div>
    );
};

export default Actions;